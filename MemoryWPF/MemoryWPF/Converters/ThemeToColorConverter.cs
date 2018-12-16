using MemoryWPF.DataHelpers;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MemoryWPF.Converters
{
    class ThemeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Theme theme = (Theme)value;
            switch(theme)
            { 
                case Theme.Animals:
                    return Brushes.Red;
                case Theme.Math:
                    return Brushes.Blue;
                default: 
                    return Brushes.Red;
           }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
