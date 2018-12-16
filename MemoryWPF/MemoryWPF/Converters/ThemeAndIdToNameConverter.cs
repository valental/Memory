using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class ThemeAndIdToNameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Theme theme = Theme.Animals;
            int id = 0;
            if (values[0] != DependencyProperty.UnsetValue)
            {
                theme = (Theme)values[0];
            }
            if (values[1] != DependencyProperty.UnsetValue)
            {
                id = (int)values[1];
            }
            return CardData.ThemeCardNames[theme][id];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
