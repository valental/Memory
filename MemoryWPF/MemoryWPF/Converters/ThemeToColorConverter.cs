using System;
using System.Globalization;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class ThemeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CardData.ThemeColors[(Theme)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
