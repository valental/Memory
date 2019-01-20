using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class LanguageToFlagConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Language language = (Language)value;
            string file = language == Language.English ? "CRO_Flag.png" : "UK_Flag.png";
            return new BitmapImage(new Uri("/MemoryWPF;component/Resources/" + file, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
