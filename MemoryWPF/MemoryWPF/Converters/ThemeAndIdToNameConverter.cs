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
            Enum.TryParse(Properties.Settings.Default.Language, out Language language);
            return language == Language.English ? CardData.ThemeCardNamesEnglish[theme][id] : CardData.ThemeCardNamesCroatian[theme][id];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
