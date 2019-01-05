﻿using System;
using System.Collections;
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

        private string btnText = "Show scores!";
        public string BtnText
        {
            get => btnText;
            set { btnText = value; OnPropertyChanged("BtnText"); }
        }

        public IEnumerable Themes => Enum.GetValues(typeof(Theme)).Cast<Theme>();

        private Theme selectedTheme = Theme.WildAnimals;
        public Theme SelectedTheme
        {
            get => selectedTheme;
            set
            {
                selectedTheme = value;
                PairCounts = SetPairCounts(selectedTheme);
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
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
        }
        #endregion

        #region Methods
        private static ObservableCollection<int> SetPairCounts(Theme theme)
        {
            ObservableCollection<int> counts = new ObservableCollection<int>();
            Enum.TryParse(Properties.Settings.Default.Language, out Language language);
            int max = language == Language.English ? CardData.ThemeCardNamesEnglish[theme].Count : CardData.ThemeCardNamesCroatian[theme].Count;
            for (int i = 2; i <= max; i++)
            {
                counts.Add(i);
            }
            return counts;
        }

        private void StartTheGame()
        {
            if (ShowScores)
            {
                ShowScores = false;
                BtnText = "Show scores!";
            }

            CurrentTheme = SelectedTheme;
            CurrentPairCount = 0;
            CurrentPairCount = SelectedPairCount;
            CurrentGameData.Game = new GameData(PlayerName, TimeSpan.Zero, 0);
            CurrentGameData.StartTime = DateTime.Now;
        }

        private void ShowHighscores()
        {
            ShowScores = !ShowScores;
            RankList = new ObservableCollection<GameData>(ScoresManager.GetRankList(SelectedTheme, SelectedPairCount));
            if(RankList.Count < 10)
            {
                int count = RankList.Count;
                for(int i = 0; i < 10-count; i++)
                {
                    RankList.Add(new GameData("-",TimeSpan.Zero,0));
                    RankList[RankList.Count - 1].Rank = RankList.Count;
                }
            }

            if (BtnText == "Show scores!")
                BtnText = "Hide scores!";
            else
                BtnText = "Show scores!";
        }

        #endregion
    }
}
