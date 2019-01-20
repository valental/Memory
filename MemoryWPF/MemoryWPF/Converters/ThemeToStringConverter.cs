using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class ThemeToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Language language = values[0] == DependencyProperty.UnsetValue ? UserSettings.Language : (Language)values[0];
            Theme theme = (Theme)values[1];

            if (language == Language.English)
            {
                switch (theme)
                {
                    case Theme.WildAnimals:
                        return "Wild Animals";
                    case Theme.FarmAnimals:
                        return "Farm Animals";
                    default:
                        return theme.ToString();
                }
            }
            else
            {
                switch (theme)
                {
                    case Theme.WildAnimals:
                        return "Divlje životinje";
                    case Theme.FarmAnimals:
                        return "Domaće životinje";
                    case Theme.Math:
                        return "Matematika";
                    case Theme.Actors:
                        return "Glumci";
                    case Theme.Cities:
                        return "Gradovi";
                    case Theme.Instruments:
                        return "Insturmenti";
                    case Theme.Singers:
                        return "Pjevači";
                    case Theme.Sports:
                        return "Sportovi";
                    default:
                        return "Divlje životinje";
                }
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
