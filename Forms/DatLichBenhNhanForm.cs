using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using MaterialSkin;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ezbooking.Forms
{
    public partial class DatLichBenhNhanForm : Form
    {
        private readonly AppDbContext _appDbContext;
        public int BenhNhanId = 0;
        public event EventHandler DataChanged;

        public TimeOnly MorningEndTime = new(12, 0);
        public TimeOnly MorningStartTime = new(8, 0);
        public TimeOnly AfternoonEndTime = new(17, 0);
        public TimeOnly AfternoonStartTime = new(13, 0);

        private List<BacSiAndTime> addedBacsi = new();
        private List<BenhNhanAndTime> addedBenhNhanTime = new();
        public DatLichBenhNhanForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
        }

        private void DatLichBenhNhanForm_Load(object sender, EventArgs e)
        {
            var listDvkt = GetListDvkt();

            // Tự động lấy bác sĩ và thời gian phù hợp
            var rowData = new List<string>();
            foreach (var dvkt in listDvkt)
            {
                var time = GetBacSiLowestIncome(GetTime(dvkt));
                rowData.Add(dvkt.TenDichVu + "          " + time);
                addedBacsi.Add(new BacSiAndTime
                {
                    TenBacSi = time.Split("--")[0],
                    ThoiGianBatDau = DateTime.Parse(time.Split("--")[1].Split("-")[0]),
                    ThoiGianKetThuc = DateTime.Parse(time.Split("--")[1].Split("-")[1])
                });

                addedBenhNhanTime.Add(new BenhNhanAndTime
                {
                    ThoiGianBatDau = DateTime.Parse(time.Split("--")[1].Split("-")[0]),
                    ThoiGianKetThuc = DateTime.Parse(time.Split("--")[1].Split("-")[1])
                });
            }

            FillDataToUI(rowData);
        }

        // get list dvkt of this benhnhan
        private List<DichVuKT> GetListDvkt()
        {
            var dichVuKTs = _appDbContext.BenhNhans
                .Include(a => a.DichVuKTs)
                .Where(a => a.Id == BenhNhanId)
                .FirstOrDefault()
                .DichVuKTs
                .ToList();

            return dichVuKTs;
        }

        private void FillDataToUI(List<string> data)
        {
            datlich_listbox.Items.Clear();
            int stt = 0;
            foreach (var item in data)
            {
                stt++;
                var newItem = new MaterialListBoxItem();

                newItem.Text = item;

                datlich_listbox.Items.Add(newItem);
            }
        }

        private List<string> GetTime(DichVuKT dvkt)
        {
            var listBacsiFree = new List<string>();

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

        private List<string> GetListTimeRangeBacSi(DateTime thietbiStart, DateTime thietbiEnd, DichVuKT dvkt)
        {
            var result = new List<string>();
            var benhnhanTgb = _appDbContext.ThoiGianBieus.Include(tgb => tgb.BenhNhan)
                                            .Where(tgb => tgb.BenhNhan.Id == BenhNhanId)
                                            .Select(a => new BenhNhanAndTime
                                            {
                                                ThoiGianBatDau = a.ThoiGianBatDau,
                                                ThoiGianKetThuc = a.ThoiGianKetThuc
                                            })
                                            .ToList();

            benhnhanTgb.AddRange(addedBenhNhanTime);

            var benhnhanFree = benhnhanTgb.Any() ? benhnhanTgb.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5) : DateTime.MinValue;

            var nextDayStart = DateTime.Now.AddDays(1);

            var nextDayStartTime = new DateTime(nextDayStart.Year, nextDayStart.Month, nextDayStart.Day, MorningStartTime.Hour, MorningStartTime.Minute, 0);

            if (benhnhanFree > nextDayStartTime)
            {
                nextDayStartTime = benhnhanFree;
            }
            if (benhnhanFree > thietbiStart)
            {
                thietbiStart = benhnhanFree;
            }


            if (dvkt.ThietBi == null)
            {
                var bacsiFree = new List<BacSiFreeTime>();
                var bacsis = _appDbContext.BacSiKTVs
                           .Include(bs => bs.ThoiGianBieus)
                           .Include(bs => bs.DichVuKTs)
                           .Where(bs => bs.DichVuKTs.Any(dv => dv.Id == dvkt.Id))
                           .ToList();

                // Vòng for này để lấy danh sách bác sĩ có thể làm dvkt này; và thời gian rảnh gần nhất của họ
                foreach (var item in bacsis)
                {
                    if (addedBacsi.Any(addedBacsi => addedBacsi.TenBacSi == item.TenBacSiKTV))
                    {
                        var addedData = addedBacsi.Where(addedBacsi => addedBacsi.TenBacSi == item.TenBacSiKTV).MaxBy(a => a.ThoiGianKetThuc);

                        var tempBacsi = new BacSiFreeTime
                        {
                            Id = item.Id,
                            Name = item.TenBacSiKTV,
                            TimeStart = addedData.ThoiGianKetThuc.AddMinutes(5) > benhnhanFree ? addedData.ThoiGianKetThuc.AddMinutes(5) : benhnhanFree,
                        };
                        tempBacsi.TimeEnd = tempBacsi.TimeStart.AddMinutes(dvkt.ThoiGian);

                        bacsiFree.Add(tempBacsi);
                    }
                    else
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
                            var tempBacsi = new BacSiFreeTime
                            {
                                Id = item.Id,
                                Name = item.TenBacSiKTV,
                                TimeStart = item.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5) > benhnhanFree ? item.ThoiGianBieus.Max(tgb => tgb.ThoiGianKetThuc).AddMinutes(5) : benhnhanFree,
                            };
                            tempBacsi.TimeEnd = tempBacsi.TimeStart.AddMinutes(dvkt.ThoiGian);

                            bacsiFree.Add(tempBacsi);
                        }
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

            // Dịch vụ có sử dụng thiết bị
            var bacsi = _appDbContext.BacSiKTVs
                                            .Include(bs => bs.ThoiGianBieus)
                                            .Include(bs => bs.DichVuKTs)
                                            .Where(bs => bs.DichVuKTs.Any(dv => dv.Id == dvkt.Id))
                                            .Where(bs => bs.ThoiGianBieus.All(tgb => tgb.ThoiGianKetThuc <= thietbiStart))
                                            .ToList();
            if (bacsi.Count == 0)
            {
                var preBacsiFree = _appDbContext.BacSiKTVs
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

                var bacsiFree = new List<BacSiFreeTime>();
                foreach (var item in preBacsiFree)
                {
                    if (addedBacsi.Any(addedBacsi => addedBacsi.TenBacSi == item.Name))
                    {
                        var addedData = addedBacsi.Where(addedBacsi => addedBacsi.TenBacSi == item.Name).MaxBy(a => a.ThoiGianKetThuc);
                        bacsiFree.Add(new BacSiFreeTime
                        {
                            Id = item.Id,
                            Name = item.Name,
                            TimeStart = addedData.ThoiGianKetThuc.AddMinutes(5),
                            TimeEnd = addedData.ThoiGianKetThuc.AddMinutes(5).AddMinutes(dvkt.ThoiGian)
                        });
                    }
                    else
                    {
                        bacsiFree.Add(item);
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

        private void DatLichBenhNhanForm_Close(object sender, EventArgs e)
        {
            addedBacsi.Clear();
            addedBenhNhanTime.Clear();
            BenhNhanId = 0;
        }

        // lấy bác sĩ có thu nhập tuần thấp nhất từ list string tên bác sĩ
        private string GetBacSiLowestIncome(List<string> listBacSiTimeRange)
        {
            var listBacSi = listBacSiTimeRange.Select(a => a.Split("--")[0]).ToList();
            var bacsi = _appDbContext.BacSiKTVs
                .Where(bs => listBacSi.Contains(bs.TenBacSiKTV))
                .ToList();

            var startOfWeek = Helpers.GetStartOfWeek(DateTime.Now);
            var endOfWeek = startOfWeek.AddDays(6);

            var thoigianbieuInWeek = _appDbContext.ThoiGianBieus
                                                .Include(tgb => tgb.DichVuKT)
                                                .Include(tgb => tgb.BacSiKTV)
                                                .Where(tgb => listBacSi.Contains(tgb.BacSiKTV.TenBacSiKTV))
                                                .Where(tgb => tgb.ThoiGianBatDau >= startOfWeek)
                                                .Where(tgb => tgb.ThoiGianKetThuc <= endOfWeek)
                                                .ToList();

            if (thoigianbieuInWeek.Count == 0)
            {
                return listBacSiTimeRange.GetRandomItem();
            }

            // check if a doctor dont have time range in this week
            var listBacsiHaveIncomeInweek = thoigianbieuInWeek.Select(tgb => tgb.BacSiKTV.TenBacSiKTV).Distinct().ToList();
            var listBacsiDontHaveIncomeInweek = listBacSiTimeRange.Where(bs => !listBacsiHaveIncomeInweek.Contains(bs.Split("--")[0])).ToList();

            if (listBacsiDontHaveIncomeInweek.Count > 0)
            {
                return listBacsiDontHaveIncomeInweek.GetRandomItem();
            }


            var groupData = thoigianbieuInWeek.GroupBy(tgb => tgb.BacSiKTV.TenBacSiKTV)
                .Select(tgb => new BacSiThuNhap
                {
                    TenBacSi = tgb.Key,
                    ThuNhap = tgb.Sum(tgb => tgb.DichVuKT.ChiPhi)
                }).MinBy(x => x.ThuNhap);

            return listBacSiTimeRange.FirstOrDefault(bs => bs.Contains(groupData.TenBacSi));

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var listDvkt = _appDbContext.DichVuKTs.ToList();
                var listBenhNhan = _appDbContext.BenhNhans.ToList();
                var listBacsi = _appDbContext.BacSiKTVs.ToList();
                // get data from listbox
                foreach (var row in datlich_listbox.Items)
                {
                    var dvkt = row.Text.Split("          ")[0];
                    var splitToGetBsiTime = row.Text.Split("          ")[1];

                    var tenbacsi = splitToGetBsiTime.Split("--")[0];
                    var timeRange = splitToGetBsiTime.Split("--")[1];
                    var thoigianbatdau = DateTime.Parse(timeRange.Split("-")[0]);
                    var thoigianketthuc = DateTime.Parse(timeRange.Split("-")[1]);

                    var thoigianbieu = new ThoiGianBieu()
                    {
                        ThoiGianBatDau = thoigianbatdau,
                        ThoiGianKetThuc = thoigianketthuc
                    };

                    thoigianbieu.DichVuKT = listDvkt.FirstOrDefault(dv => dv.TenDichVu == dvkt);
                    thoigianbieu.BenhNhan = listBenhNhan.FirstOrDefault(bn => bn.Id == BenhNhanId);
                    thoigianbieu.BacSiKTV = listBacsi.FirstOrDefault(bs => bs.TenBacSiKTV == tenbacsi);

                    _appDbContext.Add(thoigianbieu);

                    // add thoi gian su dung thiet bi
                    if (thoigianbieu.DichVuKT != null)
                    {
                        var thietBi = thoigianbieu.DichVuKT.ThietBi;
                        if (thietBi != null)
                        {
                            var thoiGianSuDungThietBi = new ThoiGianSuDungThietBi()
                            {
                                ThoiGianBatDau = thoigianbatdau,
                                ThoiGianKetThuc = thoigianketthuc,
                                ThietBi = thietBi,
                            };

                            if (thietBi.ThoiGianCachNhau > 0)
                            {
                                thoiGianSuDungThietBi.ThoiGianKetThuc = thoigianbatdau.AddMinutes(thietBi.ThoiGianCachNhau);
                            }

                            _appDbContext.ThoiGianSuDungThietBis.Add(thoiGianSuDungThietBi);
                        }

                    }
                }

                _appDbContext.SaveChanges();

                // Trigger the DataInserted event
                OnDataChanged(EventArgs.Empty);


                MessageBox.Show("Thao tác thành công!");

                // close the form
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }
    }
}
