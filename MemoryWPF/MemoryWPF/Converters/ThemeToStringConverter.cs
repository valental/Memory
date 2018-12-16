using MemoryWPF.DataHelpers;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MemoryWPF.Converters
{
    class ThemeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Theme theme = (Theme)value;
            return theme.ToString();
            //switch(theme)
            //{
            //    case Theme.Animals:
            //        return
            //        break;
            //}
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string theme = (string)value;
            switch(theme)
            {
                case "Animals":
                    return Theme.Animals;
                case "Math":
                    return Theme.Math;
                default:
                    return Theme.Animals;
            }
        }
    }
}
