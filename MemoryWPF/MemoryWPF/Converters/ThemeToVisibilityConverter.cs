using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class ThemeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Theme theme = (Theme)value;
            return theme == Theme.Math ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
