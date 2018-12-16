using System.Collections.Generic;
using System.Windows.Media;

namespace MemoryWPF.DataHelpers
{
    public enum Theme
    {
        Animals,
        Math,
        // Add new themes here
    }

    public static class CardData
    {
        public static Dictionary<Theme, SolidColorBrush> ThemeColors = new Dictionary<Theme, SolidColorBrush>();
        public static Dictionary<Theme, List<string>> ThemeCardNames = new Dictionary<Theme, List<string>>();
        public static Dictionary<Theme, List<string>> ThemeCardImages = new Dictionary<Theme, List<string>>();

        static CardData()
        {
            const string path = "Resources/";
            string theme;

            #region Colors
            ThemeColors[Theme.Animals] = Brushes.Red;
            ThemeColors[Theme.Math] = Brushes.DarkBlue;

            // Add colors for new themes here 
            #endregion

            #region Animals
            theme = "Animals/";
            ThemeCardNames[Theme.Animals] = new List<string>()
            {
                "Lion",
                
                // Add new animals here and don't forget the ','
            };
            
            ThemeCardImages[Theme.Animals] = new List<string>()
            {
                path + theme + "animals_lion.png",

                // Add new animal images here and don't forget the ','
            };
            #endregion

            #region Math
            theme = "Math/";
            ThemeCardNames[Theme.Math] = new List<string>()
            {
                "Sinus",
                
                // Add new animals here and don't forget the ','
            };
            
            ThemeCardImages[Theme.Math] = new List<string>()
            {
                path + theme + "math_sinus.png", // this picture still has to be created and added to Resources/Math

                // Add new animal images here and don't forget the ','
            };
            #endregion
        }
    }
}
