using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ezbooking.Forms
{
    public partial class AddUpdateDatLichForm : Form
    {
        private readonly AppDbContext _appDbContext;
        public int BenhNhanId = 0;
        public event EventHandler DataChanged;

        public TimeOnly MorningEndTime = new(12, 0);
        public TimeOnly MorningStartTime = new(8, 0);
        public TimeOnly AfternoonEndTime = new(17, 0);
        public TimeOnly AfternoonStartTime = new(13, 0);

        public AddUpdateDatLichForm(AppDbContext appDbContext)
        {
            InitializeComponent();

            _appDbContext = appDbContext;
        }

        private void AddUpdateDatLichForm_Load(object sender, EventArgs e)
        {
            var benhNhan = _appDbContext.BenhNhans
                                        .Include(a => a.DichVuKTs)
                                        .FirstOrDefault(a => a.Id == BenhNhanId);
            tenbenhnhan.Text = benhNhan.TenBenhNhan;

            foreach (var dvkt in benhNhan.DichVuKTs)
            {
                dvktCheckList.Items.Add(dvkt.TenDichVu);

            }
        }

        private void AddUpdateDatLichForm_Close(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            tenbenhnhan.Text = "";
            bacsiLabel.Visible = false;
            bacsiCheckBox.Visible = false;
            dvktCheckList.Items.Clear();
            bacsiCheckBox.Items.Clear();
        }

        private void dvktCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                bacsiCheckBox.Visible = false;
                bacsiLabel.Visible = false;
                return;
            }

            Helpers.SingleSelect(dvktCheckList, e.Index);
            bacsiCheckBox.Items.Clear();

            var bacsiFree = GetTime();

            foreach (var item in bacsiFree)
            {
                bacsiCheckBox.Items.Add(item);
            }

            bacsiLabel.Visible = true;
            bacsiCheckBox.Visible = true;
        }

        private DichVuKT GetDvkt()
        {
            var dvktName = dvktCheckList.SelectedItem.ToString();
            var dvktSelected = _appDbContext.DichVuKTs
                                            .Include(dv => dv.ThietBi)
                                            .FirstOrDefault(dv => dv.TenDichVu == dvktName);
            return dvktSelected;
        }

        private void bacsiCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Helpers.SingleSelect(bacsiCheckBox, e.Index);


        }

        private List<string> GetTime()
        {
            var listBacsiFree = new List<string>();

            var dvkt = GetDvkt();

            if (dvkt.ThietBi == null)
            {
                listBacsiFree = GetListTimeRangeBacSi(DateTime.MinValue, DateTime.MaxValue, dvkt);
            }
            else
            {

                var (thietBiStart, thietbiEnd) = GetTimeRangeThietBi(dvkt);

                if (dvkt.ThietBi.SoLuong == 0)
                {
                    MessageBox.Show("Thiết bị không khả dụng trong thời gian này");
                    return new List<string>();
                }

                listBacsiFree = GetListTimeRangeBacSi(thietBiStart, thietbiEnd, dvkt);
            }

            return listBacsiFree;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var doctorTime = bacsiCheckBox.SelectedItem.ToString(); // "Pham Van A--date - date"
                var arr = doctorTime.Split(Constants.Divider);

                var timeRange = arr[1];
                var timeRangeArr = timeRange.Split(" - ");
                var startTime = DateTime.Parse(timeRangeArr[0]);
                var endTime = DateTime.Parse(timeRangeArr[1]);

                // get doctor
                var doctorName = arr[0];
                var doctor = _appDbContext.BacSiKTVs
                                        .Include(bs => bs.ThoiGianBieus)
                                        .FirstOrDefault(bs => bs.TenBacSiKTV == doctorName);

                var (isThuNhapTrungBinh, thunhap, tongthunhaptrungbinh) = CompareThuNhapTrungBinh(doctor.Id, startTime);

                if (isThuNhapTrungBinh)
                {
                    DialogResult result = MessageBox.Show("Thu nhập của bác sĩ vượt quá mức trung bình trong tuần này. Bạn có chắc chắn muốn đặt lịch cho bác sĩ này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                }

                // dvkt
                var dvkt = GetDvkt();
                var thoigianbieu = new ThoiGianBieu()
                {
                    ThoiGianBatDau = startTime,
                    ThoiGianKetThuc = endTime,
                    BacSiKTV = doctor,
                    BenhNhan = _appDbContext.BenhNhans.FirstOrDefault(bn => bn.Id == BenhNhanId),
                    DichVuKT = dvkt,
                };
                _appDbContext.ThoiGianBieus.Add(thoigianbieu);

                // add thoi gian su dung thiet bi
                if (dvkt.ThietBi != null)
                {
                    var thietBi = dvkt.ThietBi;
                    var thoiGianSuDungThietBi = new ThoiGianSuDungThietBi()
                    {
                        ThoiGianBatDau = startTime,
                        ThoiGianKetThuc = endTime,
                        ThietBi = thietBi,
                    };

                    if (thietBi.ThoiGianCachNhau > 0)
                    {
                        thoiGianSuDungThietBi.ThoiGianKetThuc = startTime.AddMinutes(thietBi.ThoiGianCachNhau);
                    }

                    _appDbContext.ThoiGianSuDungThietBis.Add(thoiGianSuDungThietBi);
                }

                _appDbContext.SaveChanges();

                // Trigger the DataInserted event
                OnDataChanged(EventArgs.Empty);


                MessageBox.Show("Thao tác thành công!");

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại!");
            }
            finally
            {
                this.Close();
            }

        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        private (bool, int, int) CompareThuNhapTrungBinh(int IdBacSi, DateTime startTime)
        {
            var startOfWeek = Helpers.GetStartOfWeek(startTime);
            var endOfWeek = startOfWeek.AddDays(6);
            var numberofBacsiktv = _appDbContext.BacSiKTVs.Count();
            var thunhap = _appDbContext.ThoiGianBieus
                                                .Include(tgb => tgb.DichVuKT)
                                                .Include(tgb => tgb.BacSiKTV)
                                                .Where(tgb => tgb.BacSiKTV.Id == IdBacSi)
                                                .Where(tgb => tgb.ThoiGianBatDau >= startOfWeek)
                                                .Where(tgb => tgb.ThoiGianKetThuc <= endOfWeek)
                                                .Sum(tgb => tgb.DichVuKT.ChiPhi);

            var tongthunhap = _appDbContext.ThoiGianBieus.Include(tgb => tgb.DichVuKT)
                                                .Where(tgb => tgb.ThoiGianBatDau >= startOfWeek)
                                                .Where(tgb => tgb.ThoiGianKetThuc <= endOfWeek)
                                                .Sum(tgb => tgb.DichVuKT.ChiPhi);

            var tongthunhaptrungbinh = tongthunhap / numberofBacsiktv;

            if (thunhap > tongthunhaptrungbinh)
            {
                return (true, thunhap, tongthunhaptrungbinh);
            }
            else
            {
                return (false, thunhap, tongthunhaptrungbinh);

            }
        }

        private (DateTime, DateTime) GetTimeRangeThietBi(DichVuKT dichVuKT)
        {
            var thietBi = dichVuKT.ThietBi;
            var soLuong = dichVuKT.ThietBi.SoLuong;

            var nextDay = DateTime.Now.AddDays(1);
            var startNextDay = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);

            var duration = dichVuKT.ThoiGian;

            if (thietBi.ThoiGianCachNhau > 0)
            {
                duration = thietBi.ThoiGianCachNhau;
            }

            var thoiGianSudungThietBi = _appDbContext.ThoiGianSuDungThietBis
                                                .Include(tb => tb.ThietBi)
                                                .Where(tb => tb.ThietBi.Id == thietBi.Id)
                                                .Where(tb => tb.ThoiGianBatDau >= startNextDay)
                                                .OrderBy(tgb => tgb.ThoiGianBatDau)
                                                .ToList();

            var groupData = thoiGianSudungThietBi.GroupBy(tg => tg.ThoiGianBatDau)
                                                .Select(g => new
                                                {
                                                    ThoiGianBatDau = g.Key,
                                                    ThoiGianKetThuc = g.MaxBy(tg => tg.ThoiGianKetThuc).ThoiGianKetThuc,
                                                    Count = g.Count()
                                                })
                                                .OrderBy(o => o.ThoiGianBatDau);

            var lastTime = startNextDay;

            foreach (var item in groupData)
            {
                if (item.Count >= soLuong)
                {
                    lastTime = item.ThoiGianKetThuc;
                    continue;
                }

                return (item.ThoiGianBatDau, item.ThoiGianKetThuc);
            }

            // Nếu tìm hết groupData mà không có thời gian trống thì lấy thời gian kết thúc gần nhất + 5 phút
            var suitableTime = lastTime.AddMinutes(5);
            var timeEnd = suitableTime.AddMinutes(duration);

            if (timeEnd.TimeOfDay >= MorningEndTime.ToTimeSpan() && timeEnd.TimeOfDay <= AfternoonStartTime.ToTimeSpan())
            {
                var start = new DateTime(timeEnd.Year, timeEnd.Month, timeEnd.Day, AfternoonStartTime.Hour, AfternoonStartTime.Minute, 0);

                return (start, start.AddMinutes(duration));
            }

            if (timeEnd.TimeOfDay >= AfternoonEndTime.ToTimeSpan())
            {
                var nextDayTime = suitableTime.AddDays(1);
                var start = new DateTime(nextDayTime.Year, nextDayTime.Month, nextDayTime.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);
                return (start, start.AddMinutes(duration));
            }

            return (suitableTime, suitableTime.AddMinutes(duration));
        }

        private List<string> GetListTimeRangeBacSi(DateTime thietbiStart, DateTime thietbiEnd, DichVuKT dvkt)
        {
            var result = new List<string>();

            var nextDayStart = DateTime.Now.AddDays(1);
            var nextDayStartTime = new DateTime(nextDayStart.Year, nextDayStart.Month, nextDayStart.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);
            if (dvkt.ThietBi == null)
            {
                var bacsiFree = new List<BacSiFreeTime>();
                var bacsis = _appDbContext.BacSiKTVs
                           .Include(bs => bs.ThoiGianBieus)
                           .Include(bs => bs.DichVuKTs)
                           .Where(bs => bs.DichVuKTs.Any(dv => dv.Id == dvkt.Id))
                           .ToList();

                foreach (var item in bacsis)
                {
                    if (item.ThoiGianBieus.Count == 0)
                    {
                        bacsiFree.Add(new BacSiFreeTime
                        {
                            Id = item.Id,
                            Name = item.TenBacSiKTV,
                            TimeStart = nextDayStartTime,
                            TimeEnd = nextDayStartTime.AddMinutes(dvkt.ThoiGian)
                        });
                    }
                    else
                    {
                        bacsiFree.Add(new BacSiFreeTime
                        {
                            Id = item.Id,
                            Name = item.TenBacSiKTV,
                            TimeStart = item.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5),
                            TimeEnd = item.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5).AddMinutes(dvkt.ThoiGian)
                        });
                    }
                }

                foreach (var item in bacsiFree)
                {
                    if (item.TimeEnd.TimeOfDay >= MorningEndTime.ToTimeSpan() && item.TimeEnd.TimeOfDay <= AfternoonStartTime.ToTimeSpan())
                    {
                        var start = new DateTime(item.TimeEnd.Year, item.TimeEnd.Month, item.TimeEnd.Day, AfternoonStartTime.Hour, AfternoonStartTime.Minute, 0);
                        var end = start.AddMinutes(dvkt.ThoiGian);
                        result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(start, end));
                        continue;
                    }

                    if (item.TimeEnd.TimeOfDay >= AfternoonEndTime.ToTimeSpan())
                    {
                        var nextDayTime = item.TimeEnd.AddDays(1);
                        var start = new DateTime(nextDayTime.Year, nextDayTime.Month, nextDayTime.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);
                        var end = start.AddMinutes(dvkt.ThoiGian);
                        result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(start, end));
                        continue;
                    }

                    result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(item.TimeStart, item.TimeEnd));
                }
                return result;
            }
            var bacsi = _appDbContext.BacSiKTVs
                                            .Include(bs => bs.ThoiGianBieus)
                                            .Include(bs => bs.DichVuKTs)
                                            .Where(bs => bs.DichVuKTs.Any(dv => dv.Id == dvkt.Id))
                                            .Where(bs => bs.ThoiGianBieus.All(tgb => tgb.ThoiGianKetThuc <= thietbiStart))
                                            .ToList();
            if (bacsi.Count == 0)
            {
                var bacsiFree = _appDbContext.BacSiKTVs
                                           .Include(bs => bs.ThoiGianBieus)
                                           .Include(bs => bs.DichVuKTs)
                                           .Where(bs => bs.DichVuKTs.Any(dv => dv.Id == dvkt.Id))
                                           .Select(bs => new BacSiFreeTime
                                           {
                                               Id = bs.Id,
                                               Name = bs.TenBacSiKTV,
                                               TimeStart = bs.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5),
                                               TimeEnd = bs.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5).AddMinutes(dvkt.ThoiGian)
                                           })
                                           .ToList();

                foreach (var item in bacsiFree)
                {
                    if (item.TimeEnd.TimeOfDay >= MorningEndTime.ToTimeSpan() && item.TimeEnd.TimeOfDay <= AfternoonStartTime.ToTimeSpan())
                    {
                        var start = new DateTime(item.TimeEnd.Year, item.TimeEnd.Month, item.TimeEnd.Day, AfternoonStartTime.Hour, AfternoonStartTime.Minute, 0);
                        var end = start.AddMinutes(dvkt.ThoiGian);
                        result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(start, end));
                        continue;
                    }

                    if (item.TimeEnd.TimeOfDay >= AfternoonEndTime.ToTimeSpan())
                    {
                        var nextDayTime = item.TimeEnd.AddDays(1);
                        var start = new DateTime(nextDayTime.Year, nextDayTime.Month, nextDayTime.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);
                        var end = start.AddMinutes(dvkt.ThoiGian);
                        result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(start, end));
                        continue;
                    }

                    result.Add(item.Name + "--" + Helpers.GetWorkingTimeRange(item.TimeStart, item.TimeEnd));
                }
            }
            else
            {
                foreach (var item in bacsi)
                {
                    result.Add(item.TenBacSiKTV + "--" + Helpers.GetWorkingTimeRange(thietbiStart, thietbiStart.AddMinutes(dvkt.ThoiGian)));
                }
            }

            return result;
        }
    }
}
