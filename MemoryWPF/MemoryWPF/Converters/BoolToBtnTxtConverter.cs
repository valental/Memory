using System;
using System.Globalization;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    class BoolToBtnTxtConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? "Hide scores!" : "Show scores!";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
