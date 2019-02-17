using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    public class TimeSpanToSecondsConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan time = (TimeSpan)value;

            if (time == TimeSpan.Zero)
                return "-";

            string min = addZeros((int)Math.Floor(time.TotalMinutes), 2);
            string sec = addZeros(time.Seconds, 2);
            string milisec = addZeros(time.Milliseconds, 3);
            return min + ":" + sec + ":" + milisec;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private string addZeros(int x, int n)
        {
            StringBuilder s = new StringBuilder();
            for (int i = x.ToString().Length; i < n; i++)
                s.Append("0");
            s.Append(x.ToString());
            return s.ToString();
        }
    }
}
