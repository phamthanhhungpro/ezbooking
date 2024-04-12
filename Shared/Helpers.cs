using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach(var item in checkedListBox.Items)
            {
                item.Checked = false;
            }
        }
    }
}
