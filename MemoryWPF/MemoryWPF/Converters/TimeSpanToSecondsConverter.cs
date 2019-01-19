using System;
using System.Globalization;
using System.Windows;
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

            double temp = (double)time.Seconds + ((double)time.Milliseconds / 1000);
            return temp.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
