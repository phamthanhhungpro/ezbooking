using MaterialSkin.Controls;

namespace ezbooking.Shared
{
    public static class Helpers
    {
        public static string GetTimeRange(string startTime, string endTime)
        {
            return $"{startTime} - {endTime}";
        }

        public static TimeOnly GetTime(string time)
        {
            var timeParts = time.Split(':');
            if (timeParts.Length != 2)
            {
                throw new ArgumentException("Invalid time format");
            }

            return TimeOnly.Parse(time);
        }

        public static string GetWorkingTimeRange(TimeOnly startTime, TimeOnly endTime)
        {
            var start = startTime.ToShortTimeString();
            var end = endTime.ToShortTimeString();
            return start + " - " + end;
        }

        public static void UnCheckAllItems(MaterialCheckedListBox checkedListBox)
        {
            foreach (var item in checkedListBox.Items)
            {
                item.Checked = false;
            }
        }

        public static void UnCheckAllItems(CheckedListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetItemChecked(i, false);
            }
        }

        public static void SingleSelect(CheckedListBox listBox, int index)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // Bỏ chọn tất cả các mục ngoại trừ mục mới được chọn
                if (i != index)
                {
                    listBox.SetItemChecked(i, false);
                }
            }
        }

        public static string RemoveSign4VietnameseString(this string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str.Trim().ToLower();
        }

        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
        };

        public static string GetWorkingTimeRange(DateTime startTime, DateTime endTime)
        {
            var start = startTime.ToString("g");
            var end = endTime.ToString("g");
            return start + " - " + end;
        }

        public static DateTime GetStartOfWeek(DateTime date)
        {
            int delta = DayOfWeek.Monday - date.DayOfWeek;
            if (delta > 0)
                delta -= 7;
            return date.AddDays(delta);
        }
    }
}
