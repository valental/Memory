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

    public enum Language { English, Croatian }

    public static class CardData
    {
        public static Dictionary<Theme, SolidColorBrush> ThemeColors = new Dictionary<Theme, SolidColorBrush>();
        public static Dictionary<Theme, List<string>> ThemeCardNamesEnglish = new Dictionary<Theme, List<string>>();
        public static Dictionary<Theme, List<string>> ThemeCardNamesCroatian = new Dictionary<Theme, List<string>>();
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
            ThemeCardNamesEnglish[Theme.Animals] = new List<string>()
            {
                "Lion",
                "Giraffe",
                "Crocodile",
                "Elephant",
                "Hippo",
                "Antelope",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Animals] = new List<string>()
            {
                "Lav",
                "Žirafa",
                "Krokodil",
                "Slon",
                "Nilski konj",
                "Antilopa",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Animals] = new List<string>()
            {
                path + theme + "animals_lion.png",
                path + theme + "animals_giraffe.png",   // this picture still has to be created and added to Resources/Animals
                path + theme + "animals_crocodile.png", // this picture still has to be created and added to Resources/Animals
                path + theme + "animals_elephant.png",  // this picture still has to be created and added to Resources/Animals
                path + theme + "animals_hippo.png",     // this picture still has to be created and added to Resources/Animals
                path + theme + "animals_antelope.png",  // this picture still has to be created and added to Resources/Animals

                // Add new animal images here and don't forget the ','
            };
            #endregion

            #region Math
            theme = "Math/";
            ThemeCardNamesEnglish[Theme.Math] = new List<string>()
            {
                "Sinus",
                "Cosinus",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Math] = new List<string>()
            {
                "Sinus",
                "Kosinus",

                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Math] = new List<string>()
            {
                path + theme + "math_sinus.png", // this picture still has to be created and added to Resources/Math
                path + theme + "math_cosinus.png", // this picture still has to be created and added to Resources/Math,

                // Add new animal images here and don't forget the ','
            };
            #endregion
        }
    }
}
