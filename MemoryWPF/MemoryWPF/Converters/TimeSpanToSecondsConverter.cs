using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    class TimeSpanToSecondsConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan time = (TimeSpan)value;
            double temp = (double)time.Seconds + ((double)time.Milliseconds / 1000);
            return temp.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
