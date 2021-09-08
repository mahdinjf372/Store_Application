using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Common.Extentions
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date).ToString() + "/" + pc.GetMonth(date).ToString("00") + "/" +
                   pc.GetDayOfMonth(date).ToString("00");
        }

        public static DateTime ToMiladi(this DateTime date)
        {
            Calendar pc = new PersianCalendar();
            DateTime dt = new DateTime(date.Year,date.Month,date.Day,date.Hour,date.Minute,date.Second,pc);
            return dt;
        }
    }
}