using System.Collections.Generic;
using System.Windows.Media;

namespace MemoryWPF.DataHelpers
{
    public enum Theme
    {
        WildAnimals,
        FarmAnimals,
        Math,
        Actors,
        Cities,
        Instruments,
        Singers,
        Sports,

        // Add new themes here
    }

    public enum Language { English, Croatian }

    public static class CardData
    {
        public static Dictionary<Theme, SolidColorBrush> ThemeColors { get; } = new Dictionary<Theme, SolidColorBrush>();
        public static Dictionary<Theme, List<string>> ThemeCardImages { get; } = new Dictionary<Theme, List<string>>();

        public static Dictionary<Theme, List<string>> ThemeCardNamesEnglish { get;  } = new Dictionary<Theme, List<string>>();
        public static Dictionary<Theme, List<string>> ThemeCardNamesCroatian { get; } = new Dictionary<Theme, List<string>>();

        public static Dictionary<int, string> ExpressionsEnglish { get; } = new Dictionary<int, string>();
        public static Dictionary<int, string> ExpressionsCroatian { get; } = new Dictionary<int, string>();

        static CardData()
        {
            const string path = "Resources/";
            string theme;

            #region ExpressionsEnglish
            ExpressionsEnglish[0] = "Name:";
            ExpressionsEnglish[1] = "Theme:";
            ExpressionsEnglish[2] = "Number of pairs:";
            ExpressionsEnglish[3] = "Start!";
            ExpressionsEnglish[4] = "RANK";
            ExpressionsEnglish[5] = "NAME";
            ExpressionsEnglish[6] = "TIME (s)";
            ExpressionsEnglish[7] = "PAIRS OPENED";
            #endregion

            #region ExpressionsCroatian
            ExpressionsCroatian[0] = "Ime:";
            ExpressionsCroatian[1] = "Tema:";
            ExpressionsCroatian[2] = "Broj parova:";
            ExpressionsCroatian[3] = "Kreni!";
            ExpressionsCroatian[4] = "RANG";
            ExpressionsCroatian[5] = "IME";
            ExpressionsCroatian[6] = "VRIJEME (s)";
            ExpressionsCroatian[7] = "OTVORENI PAROVI";
            #endregion

            #region Colors
            ThemeColors[Theme.WildAnimals] = Brushes.Red;
            ThemeColors[Theme.FarmAnimals] = Brushes.SaddleBrown;
            ThemeColors[Theme.Actors] = Brushes.DarkRed;
            ThemeColors[Theme.Cities] = Brushes.DarkOrange;
            ThemeColors[Theme.Instruments] = Brushes.ForestGreen;
            ThemeColors[Theme.Singers] = Brushes.Purple;
            ThemeColors[Theme.Sports] = Brushes.CornflowerBlue;
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

            #region FarmAnimals
            theme = "Farm_Animals/";
            ThemeCardNamesEnglish[Theme.FarmAnimals] = new List<string>()
            {
                "Cat",
                "Chicken",
                "Cow",
                "Dog",
                "Donkey",
                "Duck",
                "Goat",
                "Goose",
                "Horse",
                "Pig",
                "Rabbit",
                "Sheep",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.FarmAnimals] = new List<string>()
            {
                "Mačka",
                "Kokoš",
                "Krava",
                "Pas",
                "Majmun",
                "Patka",
                "Koza",
                "Guska",
                "Konj",
                "Svinja",
                "Zec",
                "Ovca",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.FarmAnimals] = new List<string>()
            {
                path + theme + "farm_animals_cat.png",
                path + theme + "farm_animals_chicken.jpg",
                path + theme + "farm_animals_cow.png",
                path + theme + "farm_animals_dog.png",
                path + theme + "farm_animals_donkey.png",
                path + theme + "farm_animals_duck.png",
                path + theme + "farm_animals_goat.jpg",
                path + theme + "farm_animals_goose.png",
                path + theme + "farm_animals_horse.png",
                path + theme + "farm_animals_pig.png",
                path + theme + "farm_animals_rabbit.png",
                path + theme + "farm_animals_sheep.png",


            };
            #endregion

            #region Actors
            theme = "Actors/";
            ThemeCardNamesEnglish[Theme.Actors] = new List<string>()
            {
                "Angelina Jolie",
                "Anne Hathaway",
                "Brad Pitt",
                "Christian Bale",
                "Emma Watson",
                "George Clooney",
                "Jim Carrey",
                "Julia Roberts",
                "Leonardo Di Caprio",
                "Natalie Portman",
                "Rowan Atkinson",
                "Tom Hanks",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Actors] = new List<string>()
            {
                "Angelina Jolie",
                "Anne Hathaway",
                "Brad Pitt",
                "Christian Bale",
                "Emma Watson",
                "George Clooney",
                "Jim Carrey",
                "Julia Roberts",
                "Leonardo Di Caprio",
                "Natalie Portman",
                "Rowan Atkinson",
                "Tom Hanks",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Actors] = new List<string>()
            {
                path + theme + "actors_angelinajolie.png",
                path + theme + "actors_annehathaway.png",
                path + theme + "actors_bradpitt.png",
                path + theme + "actors_christianbale.png",
                path + theme + "actors_emmawatson.png",
                path + theme + "actors_georgeclooney.png",
                path + theme + "actors_jimcarrey.png",
                path + theme + "actors_juliaroberts.png",
                path + theme + "actors_leonardodicaprio.png",
                path + theme + "actors_natalieportman.png",
                path + theme + "actors_rowanatkinson.png",
                path + theme + "actors_tomhanks.png",


            };
            #endregion

            #region Cities
            theme = "Cities/";
            ThemeCardNamesEnglish[Theme.Cities] = new List<string>()
            {
                "Agra",
                "Barcelona",
                "Dubai",
                "London",
                "Moscow",
                "New York",
                "Paris",
                "Rio de Janeiro",
                "Rome",
                "San Francisco",
                "Sydney",
                "Zagreb",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Cities] = new List<string>()
            {
                "Agra",
                "Barcelona",
                "Dubai",
                "London",
                "Moscow",
                "New York",
                "Paris",
                "Rio de Janeiro",
                "Rome",
                "San Francisco",
                "Sydney",
                "Zagreb",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Cities] = new List<string>()
            {
                path + theme + "cities_agra.png",
                path + theme + "cities_barcelona.png",
                path + theme + "cities_dubai.png",
                path + theme + "cities_london.jpg",
                path + theme + "cities_moscow.png",
                path + theme + "cities_newyork.png",
                path + theme + "cities_paris.jpg",
                path + theme + "cities_riodejaneiro.png",
                path + theme + "cities_rome.png",
                path + theme + "cities_sanfrancisco.png",
                path + theme + "cities_sydney.png",
                path + theme + "cities_zagreb.jpg",


            };
            #endregion

            #region Instruments
            theme = "Instruments/";
            ThemeCardNamesEnglish[Theme.Instruments] = new List<string>()
            {
                "Accordion",
                "Cello",
                "Clarinet",
                "Drum",
                "Flute",
                "Guitar",
                "Harp",
                "Piano",
                "Saxophone",
                "Triangle",
                "Trumpet",
                "Violin",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Instruments] = new List<string>()
            {
                "Harmonika",
                "Violončelo",
                "Klarinet",
                "Bubanj",
                "Flauta",
                "Gitara",
                "Harfa",
                "Glasovir",
                "Saksofon",
                "Triangl",
                "Truba",
                "Violina",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Instruments] = new List<string>()
            {
                path + theme + "instruments_accordion.png",
                path + theme + "instruments_cello.png",
                path + theme + "instruments_clarinet.png",
                path + theme + "instruments_drum.png",
                path + theme + "instruments_flute.png",
                path + theme + "instruments_guitar.png",
                path + theme + "instruments_harp.png",
                path + theme + "instruments_piano.png",
                path + theme + "instruments_saxophone.png",
                path + theme + "instruments_triangle.png",
                path + theme + "instruments_trumpet.png",
                path + theme + "instruments_violin.png",


            };
            #endregion

            #region Singers
            theme = "Singers/";
            ThemeCardNamesEnglish[Theme.Singers] = new List<string>()
            {
                "Adele",
                "Beyonce",
                "Enrique Iglesias",
                "Freddie Mercury",
                "Justin Bieber",
                "Justin Timberlake",
                "Madonna",
                "Michael Jackson",
                "Rihanna",
                "Selena Gomez",
                "Shakira",
                "Snoop Dogg",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Singers] = new List<string>()
            {
                "Adele",
                "Beyonce",
                "Enrique Iglesias",
                "Freddie Mercury",
                "Justin Bieber",
                "Justin Timberlake",
                "Madonna",
                "Michael Jackson",
                "Rihanna",
                "Selena Gomez",
                "Shakira",
                "Snoop Dogg",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Singers] = new List<string>()
            {
                path + theme + "singers_adele.png",
                path + theme + "singers_beyonce.png",
                path + theme + "singers_enriqueiglesias.png",
                path + theme + "singers_freddiemercury.png",
                path + theme + "singers_justinbieber.png",
                path + theme + "singers_justintimberlake.png",
                path + theme + "singers_madonna.png",
                path + theme + "singers_michaeljackson.png",
                path + theme + "singers_rihanna.png",
                path + theme + "singers_selenagomez.png",
                path + theme + "singers_shakira.png",
                path + theme + "singers_snoopdogg.png",


            };
            #endregion

            #region Sports
            theme = "Sports/";
            ThemeCardNamesEnglish[Theme.Sports] = new List<string>()
            {
                "Basketball",
                "Boxing",
                "Cycling",
                "Football",
                "Golf",
                "High jump",
                "Ice Skating",
                "Running",
                "Skiing",
                "Tennis",
                "Volleyball",
                "Waterpolo",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Sports] = new List<string>()
            {
                "Košarka",
                "Boks",
                "Biciklizam",
                "Nogomet",
                "Golf",
                "Skok u vis",
                "Klizanje",
                "Trčanje",
                "Skijanje",
                "Tenis",
                "Odbojka",
                "Vaterpolo",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Sports] = new List<string>()
            {
                path + theme + "sports_basketball.png",
                path + theme + "sports_boxing.png",
                path + theme + "sports_cycling.png",
                path + theme + "sports_football.png",
                path + theme + "sports_golf.png",
                path + theme + "sports_highjump.png",
                path + theme + "sports_iceskating.png",
                path + theme + "sports_running.png",
                path + theme + "sports_skiing.png",
                path + theme + "sports_tennis.png",
                path + theme + "sports_volleyball.png",
                path + theme + "sports_waterpolo.png",


            };
            #endregion

            #region Math
            theme = "Math/";
            ThemeCardNamesEnglish[Theme.Math] = new List<string>()
            {
                "Absolute",
                "Cosine",
                "Cotangent",
                "Cubed function",
                "Exponential",
                "Identity",
                "Natural logarithm",
                "Reciprocal",
                "Sine",
                "Squared function",
                "Square root",
                "Tangent",
                
                // Add new animals here and don't forget the ','
            };

            ThemeCardNamesCroatian[Theme.Math] = new List<string>()
            {
                "Absolute",
                "Cosine",
                "Cotangent",
                "Cubed function",
                "Exponential",
                "Identity",
                "Natural logarithm",
                "Reciprocal",
                "Sine",
                "Squared function",
                "Square root",
                "Tangent",

                // Add new animals here and don't forget the ','
            };

            ThemeCardImages[Theme.Math] = new List<string>()
            {
                path + theme + "math_absolute.png",
                path + theme + "math_cosine.png",
                path + theme + "math_cotangent.png",
                path + theme + "math_cubed.png",
                path + theme + "math_exponential.png",
                path + theme + "math_identity.png",
                path + theme + "math_naturallogarithm.png",
                path + theme + "math_reciprocal.png",
                path + theme + "math_sine.png",
                path + theme + "math_squared.png",
                path + theme + "math_squareroot.png",
                path + theme + "math_tangent.png",

                // Add new animal images here and don't forget the ','
            };
            #endregion
        }
    }
}
