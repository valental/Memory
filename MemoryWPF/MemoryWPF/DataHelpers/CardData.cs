using System.Collections.Generic;
using System.Windows.Media;

namespace MemoryWPF.DataHelpers
{
    public enum Theme
    {
        WildAnimals,
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
            ThemeColors[Theme.WildAnimals] = Brushes.Red;
            ThemeColors[Theme.Math] = Brushes.DarkBlue;

            // Add colors for new themes here 
            #endregion

            #region WildAnimals
            theme = "Wild_Animals/";
            ThemeCardNamesEnglish[Theme.WildAnimals] = new List<string>()
            {
                "Lion",
                "Bear",
                "Elephant",
                "Gazelle",
                "Giraffe",
                "Gorilla",
                "Hippo",
                "Orca",
                "Panda",
                "Penguin",
                "Tiger",
                "Zebra",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.WildAnimals] = new List<string>()
            {
                "Lav",
                "Medvjed",
                "Slon",
                "Gazela",
                "Žirafa",
                "Gorila",
                "Nilski konj",
                "Orka",
                "Panda",
                "Pingvin",
                "Tigar",
                "Zebra",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.WildAnimals] = new List<string>()
            {
                path + theme + "wild_animals_lion.png",
                path + theme + "wild_animals_bear.jpg",   
                path + theme + "wild_animals_elephant.jpg", 
                path + theme + "wild_animals_gazelle.png",  
                path + theme + "wild_animals_giraffe.jpg",   
                path + theme + "wild_animals_gorilla.jpg",
                path + theme + "wild_animals_hippo.png",
                path + theme + "wild_animals_orca.jpg",
                path + theme + "wild_animals_panda.jpg",
                path + theme + "wild_animals_penguin.jpg",
                path + theme + "wild_animals_tiger.jpg",
                path + theme + "wild_animals_zebra.jpg",


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
