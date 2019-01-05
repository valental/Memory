using System;
using System.Globalization;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    class ZeroToDashConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int cardNumber = (int)value;

            if (cardNumber == 0)
                return "-";

            else
                return cardNumber.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
