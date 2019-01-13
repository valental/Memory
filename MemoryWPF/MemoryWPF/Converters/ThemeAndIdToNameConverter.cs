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
            Theme theme = Theme.WildAnimals;
            int id = 0;
            Language language = Language.English;
            if (values[0] != DependencyProperty.UnsetValue)
            {
                theme = (Theme)values[0];
            }
            if (values[1] != DependencyProperty.UnsetValue)
            {
                id = (int)values[1];
            }
            if (values[2] != DependencyProperty.UnsetValue)
            {
                language = (Language)values[2];
            }
            return language == Language.English ? CardData.ThemeCardNamesEnglish[theme][id] : CardData.ThemeCardNamesCroatian[theme][id];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
