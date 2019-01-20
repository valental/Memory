using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class LanguageToMessageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Language language = values[0] == DependencyProperty.UnsetValue ? UserSettings.Language : (Language)values[0];
            string messageEng = (string)values[1];
            string messageCro = (string)values[2];

            return language == Language.English ? messageEng : messageCro;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
