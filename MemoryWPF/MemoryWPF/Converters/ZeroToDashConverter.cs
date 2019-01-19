using System;
using System.Globalization;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    public class ZeroToDashConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int cardNumber = (int)value;

            return cardNumber == 0 ? "-" : cardNumber.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
