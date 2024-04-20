using ezbooking.Models;
using ezbooking.Shared;
using Microsoft.EntityFrameworkCore;

namespace ezbooking.Forms
{
    public partial class AddUpdateDatLichForm : Form
    {
        private readonly AppDbContext _appDbContext;
        public int BenhNhanId = 0;
        public event EventHandler DataChanged;

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
            timeCheckBox.Visible = false;
            timeLabel.Visible = false;
            dvktCheckList.Items.Clear();
            bacsiCheckBox.Items.Clear();
            timeCheckBox.Items.Clear();
        }

        private void dvktCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                bacsiCheckBox.Visible = false;
                bacsiLabel.Visible = false;
                timeLabel.Visible = false;
                timeCheckBox.Visible = false;
                return;
            }

            Helpers.SingleSelect(dvktCheckList, e.Index);
            bacsiCheckBox.Items.Clear();
            timeCheckBox.Items.Clear();

            var dvktSelected = GetDoctorForDvkt();

            if (dvktSelected != null)
            {
                foreach (var bacsi in dvktSelected.BacSiKTVs)
                {
                    bacsiCheckBox.Items.Add(bacsi.TenBacSiKTV);
                }
            }

            bacsiLabel.Visible = true;
            bacsiCheckBox.Visible = true;
        }

        private DichVuKT GetDoctorForDvkt()
        {
            var dvktName = dvktCheckList.SelectedItem.ToString();
            var dvktSelected = _appDbContext.DichVuKTs
                                            .Include(dv => dv.ThietBi)
                                            .Include(dv => dv.BacSiKTVs)
                                            .FirstOrDefault(dv => dv.TenDichVu == dvktName);
            return dvktSelected;
        }

        private void bacsiCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                timeLabel.Visible = false;
                timeCheckBox.Visible = false;
                return;
            }

            Helpers.SingleSelect(bacsiCheckBox, e.Index);
            timeCheckBox.Items.Clear();
            // Show time range
            var time = GetTime();
            timeCheckBox.Items.Add(time);

            timeLabel.Visible = true;
            timeCheckBox.Visible = true;
        }

        private string GetTime()
        {
            var freeTime = "Không có thời gian trống";
            var doctorName = bacsiCheckBox.SelectedItem.ToString();
            var selectedBacSi = _appDbContext.BacSiKTVs
                            .Include(bs => bs.ThoiGianBieus)
                            .FirstOrDefault(bs => bs.TenBacSiKTV == doctorName);

            var startTime = selectedBacSi.GioBatDau;
            var endTime = selectedBacSi.GioKetThuc;
            var thoigianbieu = selectedBacSi.ThoiGianBieus.OrderByDescending(tgb => tgb.ThoiGianBatDau)
                                                          .ToList();
            var dvkt = GetDoctorForDvkt();
            var duration = dvkt.ThoiGian;

            if (dvkt.ThietBi == null)
            {
                freeTime = GetFreeTime(startTime, endTime, thoigianbieu, duration, DateTime.MinValue);
            }
            else
            {
                var (isAvailable, freeTimeThietBi) = CheckAvailableThietBi(startTime, endTime, dvkt);

                if (!isAvailable)
                {
                    MessageBox.Show("Thiết bị không khả dụng trong thời gian này");
                    return "Không có thiết bị";
                }

                freeTime = GetFreeTime(startTime, endTime, thoigianbieu, duration, freeTimeThietBi);
            }

            return freeTime;
        }

        private string GetFreeTime(TimeOnly startTime, TimeOnly endTime, List<ThoiGianBieu> thoigianbieu, int timeDvkt, DateTime thoigianThietBi)
        {
            bool isValidTimeRange = true;
            var today = DateTime.Today;
            var result = "";
            do
            {
                isValidTimeRange = true;
                var startDateTime = new DateTime(today.Year, today.Month, today.Day, startTime.Hour, startTime.Minute, 0);

                if (thoigianThietBi > DateTime.MinValue && today.Date <= thoigianThietBi.Date)
                {
                    startDateTime = thoigianThietBi;
                    today = thoigianThietBi;
                }

                if(startDateTime < DateTime.Now)
                {
                    isValidTimeRange = false;
                    today = today.AddDays(1);
                    continue;
                }

                var endDateTime = new DateTime(today.Year, today.Month, today.Day, endTime.Hour, endTime.Minute, 0);

                var freeStartTime = new DateTime();
                var freeEndTime = new DateTime();
                var time = startDateTime;
                var isStartDay = true;
                while (time < endDateTime)
                {
                    var isFree = true;

                    foreach (var tg in thoigianbieu)
                    {
                        if (time >= tg.ThoiGianBatDau && time <= tg.ThoiGianKetThuc)
                        {
                            isFree = false;
                            isStartDay = false;
                            break;
                        }
                    }

                    if (isFree)
                    {
                        if (!isStartDay)
                        {
                            time = time.AddMinutes(0);
                        }

                        freeStartTime = time;
                        break;
                    }

                    time = time.AddMinutes(5);
                }

                freeEndTime = freeStartTime.AddMinutes(timeDvkt);

                if (freeEndTime > endDateTime)
                {
                    isValidTimeRange = false;
                }

                foreach (var tg in thoigianbieu)
                {
                    if (freeEndTime >= tg.ThoiGianBatDau && freeEndTime <= tg.ThoiGianKetThuc)
                    {
                        isValidTimeRange = false;
                        break;
                    }
                }

                if (isValidTimeRange)
                {
                    result = Helpers.GetWorkingTimeRange(freeStartTime, freeEndTime);
                }

                today = today.AddDays(1);

            }
            while (!isValidTimeRange);

            return result;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // get time range
            var timeRange = timeCheckBox.SelectedItem.ToString();
            var timeRangeArr = timeRange.Split(" - ");
            var startTime = DateTime.Parse(timeRangeArr[0]);
            var endTime = DateTime.Parse(timeRangeArr[1]);

            // get doctor
            var doctorName = bacsiCheckBox.SelectedItem.ToString();
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
            var dvkt = GetDoctorForDvkt();
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

            // close the form
            this.Close();
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

        private (bool, DateTime) CheckAvailableThietBi(TimeOnly startTime, TimeOnly endTime, DichVuKT dichVuKT)
        {
            var now = DateTime.Now;
            var thietBi = dichVuKT.ThietBi;
            var result = DateTime.MinValue;

            var endDateTime = new DateTime(now.Year, now.Month, now.Day, endTime.Hour, endTime.Minute, 0);
            if (thietBi != null)
            {
                var quantity = dichVuKT.ThietBi.SoLuong;
                if (quantity == 0)
                {
                    return (false, result);
                }

                var thoiGianSudungThietBi = _appDbContext.ThoiGianSuDungThietBis
                                                .Include(tb => tb.ThietBi)
                                                .Where(tb => tb.ThietBi.Id == thietBi.Id)
                                                .Where(tb => tb.ThoiGianBatDau >= now)
                                                .OrderByDescending(tgb => tgb.ThoiGianBatDau)
                                                .ToList();

                var groupData = thoiGianSudungThietBi.GroupBy(tg => tg.ThoiGianBatDau)
                                                    .Select(g => new
                                                    {
                                                        ThoiGianBatDau = g.Key,
                                                        ListThoiGian = g.ToList(),
                                                        Count = g.Count()
                                                    })
                                                    .OrderBy(o => o.ThoiGianBatDau);
                var lastTime = DateTime.Now;

                foreach (var data in groupData)
                {
                    if (data.Count >= quantity)
                    {
                        lastTime = data.ListThoiGian.MaxBy(tg => tg.ThoiGianKetThuc).ThoiGianKetThuc;
                        continue;
                    }

                    return (true, data.ThoiGianBatDau);
                }

                var suitableTime = lastTime.AddMinutes(5);

                if (suitableTime.TimeOfDay <= endDateTime.TimeOfDay)
                {
                    result = suitableTime;
                }
                else
                {
                    // move to the next day from suitableTime
                    result = new DateTime(suitableTime.Year, suitableTime.Month, suitableTime.Day + 1, startTime.Hour, startTime.Minute, 0);
                }
            }
            return result > DateTime.MinValue ? (true, result) : (false, result);
        }
    }
}
