using System;
using System.Globalization;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class LanguageToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Language language = (Language)values[0];
            int id = (int)values[1];

            return language == Language.English ? CardData.ExpressionsEnglish[id] : CardData.ExpressionsCroatian[id];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
