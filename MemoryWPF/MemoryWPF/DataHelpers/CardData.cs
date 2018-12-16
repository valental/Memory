using System.Collections.Generic;
using System.Windows.Media;

namespace MemoryWPF.DataHelpers
{
    public static class CardData
    {
        public static Dictionary<Theme, SolidColorBrush> ThemeColors = new Dictionary<Theme, SolidColorBrush>();
        public static Dictionary<Theme, List<string>> ThemeCardImages = new Dictionary<Theme, List<string>>();
        public static Dictionary<Theme, List<string>> ThemeCardNames = new Dictionary<Theme, List<string>>();

        static CardData()
        {
            #region Animals
            string path = "../Resources/";
            ThemeColors[Theme.Animals] = Brushes.Red;
            ThemeCardImages[Theme.Animals] = new List<string>();
            ThemeCardImages[Theme.Animals].Add(path + "animals_lion.png");
            // TODO add more here

            ThemeCardNames[Theme.Animals] = new List<string>();
            ThemeCardNames[Theme.Animals].Add("Lion");
            // TODO add more here

            #endregion

            #region Math
            ThemeColors[Theme.Math] = Brushes.DarkBlue;
            ThemeCardImages[Theme.Math] = new List<string>();
            // TODO add more here

            ThemeCardNames[Theme.Math] = new List<string>();
            ThemeCardNames[Theme.Math].Add("Sinus");
            // TODO add more here

            #endregion

        }
    }
}
