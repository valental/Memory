using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Public Properties
        private string playerName = "Guest";
        public string PlayerName
        {
            get => playerName;
            set
            { playerName = value == "" ? "Guest" : value; OnPropertyChanged("PlayerName"); }
        }

        private bool showScores = false;
        public bool ShowScores
        {
            get => showScores;
            set { showScores = value; OnPropertyChanged("ShowScores"); }
        }

        private ObservableCollection<ThemeObject> themes = new ObservableCollection<ThemeObject>();
        public ObservableCollection<ThemeObject> Themes => themes;

        private ThemeObject selectedTheme;
        public ThemeObject SelectedTheme
        {
            get => selectedTheme;
            set
            {
                selectedTheme = value;
                PairCounts = SetPairCounts(selectedTheme.Theme);
                SelectedPairCount = 2;
                OnPropertyChanged("SelectedTheme");
            }
        }

        private Theme currentTheme = Theme.WildAnimals;
        public Theme CurrentTheme
        {
            get => currentTheme;
            set { currentTheme = value; OnPropertyChanged("CurrentTheme"); }
        }

        private ObservableCollection<int> pairCounts = SetPairCounts(Theme.WildAnimals);
        public ObservableCollection<int> PairCounts
        {
            get => pairCounts;
            set { pairCounts = value; OnPropertyChanged("PairCounts"); }
        }

        private int selectedPairCount = 2;
        public int SelectedPairCount
        {
            get => selectedPairCount;
            set
            { selectedPairCount = value; OnPropertyChanged("SelectedPairCount"); }
        }

        private int currentPairCount = 0;
        public int CurrentPairCount
        {
            get => currentPairCount;
            set
            { currentPairCount = value; OnPropertyChanged("CurrentPairCount"); }
        }

        private ObservableCollection<GameData> rankList;
        public ObservableCollection<GameData> RankList
        {
            get => rankList;
            set { rankList = value; OnPropertyChanged("RankList"); }
        }
        
        public Language Language
        {
            get => UserSettings.Language;
            set
            {
                UserSettings.Language = value;
                OnPropertyChanged("Language");
            }
        }
        #endregion

        #region Commands
        private RelayCommand startCommand;
        public ICommand StartCommand
        {
            get
            {
                if (startCommand == null)
                    startCommand = new RelayCommand(StartTheGame);
                return startCommand;
            }
        }

        private RelayCommand scoreCommand;
        public ICommand ScoreCommand
        {
            get
            {
                if (scoreCommand == null)
                    scoreCommand = new RelayCommand(ShowHighscores);
                return scoreCommand;
            }
        }

        private RelayCommand languageCommand;
        public ICommand LanguageCommand
        {
            get
            {
                if (languageCommand == null)
                    languageCommand = new RelayCommand(ChangeLanguage);
                return languageCommand;
            }
        }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            foreach (var theme in Enum.GetValues(typeof(Theme)).Cast<Theme>())
                Themes.Add(new ThemeObject(theme));
            SelectedTheme = Themes.First();
        }
        #endregion

        #region Methods
        private static ObservableCollection<int> SetPairCounts(Theme theme)
        {
            ObservableCollection<int> counts = new ObservableCollection<int>();
            int max = UserSettings.Language == Language.English ? CardData.ThemeCardNamesEnglish[theme].Count : CardData.ThemeCardNamesCroatian[theme].Count;
            for (int i = 2; i <= max; i++)
            {
                counts.Add(i);
            }
            return counts;
        }

        private void StartTheGame()
        {
            ShowScores = false;
            CurrentTheme = SelectedTheme.Theme;
            CurrentPairCount = 0;
            CurrentPairCount = SelectedPairCount;
            CurrentGameData.Game = new GameData(PlayerName, TimeSpan.Zero);
            CurrentGameData.StartTime = DateTime.Now;
        }

        private void ShowHighscores()
        {
            ShowScores = !ShowScores;
            RankList = new ObservableCollection<GameData>(ScoresManager.GetRankList(SelectedTheme.Theme, SelectedPairCount));
            if(RankList.Count < 10)
            {
                for(int i = RankList.Count; i <= 10; i++)
                    RankList.Add(new GameData("-",TimeSpan.Zero,0, i));   
            }
        }

        private void ChangeLanguage()
        {
            Language = Language == Language.English ? Language.Croatian : Language.English;
        }

        #endregion
    }
}
