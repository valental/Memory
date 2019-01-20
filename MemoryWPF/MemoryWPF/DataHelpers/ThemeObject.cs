namespace MemoryWPF.DataHelpers
{
    public class ThemeObject : DataObjectBase
    {
        #region Public Properties
        private Theme theme;
        public Theme Theme
        {
            get => theme;
            set { theme = value; OnPropertyChanged("Theme"); }
        }

        public string English
        {
            get
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
        }

        public string Croatian
        {
            get
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
        #endregion

        public ThemeObject(Theme theme)
        {
            this.theme = theme;
        }
    }
}
