using ezbooking.Models;
using ezbooking.Shared;
using Microsoft.EntityFrameworkCore;

namespace ezbooking.Forms
{
    public partial class AddUpdateDatLichForm : Form
    {
        private readonly AppDbContext _appDbContext;
        public int BenhNhanId = 0;
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

            if (dvkt.ThietBi == null)
            {
                var duration = dvkt.ThoiGian;
                freeTime = GetFreeTime(startTime, endTime, thoigianbieu, duration);
            }
            else
            {
                if (dvkt.ThietBi.ThoiGianCachNhau != 0)
                {
                    // logic here
                }
                else
                {
                    // logic here
                }
            }

            return freeTime;
        }

        private string GetFreeTime(TimeOnly startTime, TimeOnly endTime, List<ThoiGianBieu> thoigianbieu, int timeDvkt)
        {
            bool isValidTimeRange = true;
            var today = DateTime.Today;
            var startDateTime = new DateTime(today.Year, today.Month, today.Day, startTime.Hour, startTime.Minute, 0);
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
                        time = time.AddMinutes(5);
                    }

                    freeStartTime = time;
                    break;
                }

                time = time.AddMinutes(10);
            }

            freeEndTime = freeStartTime.AddMinutes(timeDvkt);

            if(freeEndTime > endDateTime)
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
                return Helpers.GetWorkingTimeRange(freeStartTime, freeEndTime);
            }
            else
            {
                return "Không có thời gian trống";
            }
        }
    }
}
