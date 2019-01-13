using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Controls
{
    /// <summary>
    /// Interaction logic for CardDeck.xaml
    /// </summary>
    public partial class CardDeck : Grid
    {
        private const int cardsInRow = 8;
        private int cardRows;
        private int cardCols;
        private Card firstOpened;
        private Card secondOpened;
        private List<Card> cards = new List<Card>();
        private int pairsMatched = 0;

        #region Dependecy Properties
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
            "Theme", typeof(Theme), typeof(CardDeck), new PropertyMetadata(Theme.WildAnimals)
        );

        public static readonly DependencyProperty PairCountProperty = DependencyProperty.Register(
            "PairCount", typeof(int), typeof(CardDeck), new PropertyMetadata(0, OnPairCountChanged)
        );
        #endregion

        #region Public Properties
        public Theme Theme
        {
            get { return (Theme)GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }

        public int PairCount
        {
            get { return (int)GetValue(PairCountProperty); }
            set { SetValue(PairCountProperty, value); }
        }
        #endregion

        #region Constructor
        public CardDeck()
        {
            InitializeComponent();

            Loaded += (sender, args) => DisplayCards();
        }
        #endregion

        #region Methods
        private void DisplayCards()
        {
            pairsMatched = 0;
            firstOpened = null;
            secondOpened = null;
            cardRows = (int)Math.Ceiling((double)(2 * PairCount) / (double)cardsInRow);
            cardCols = 2 * PairCount < cardsInRow ? 2 * PairCount : cardsInRow;

            AddRows(cardRows);
            AddCols(cardCols);

            List<int> cardIDs = new List<int>();
            for (int i = 0; i < PairCount; i++)
            {
                cardIDs.Add(i);
                cardIDs.Add(i);
            }
            cardIDs.Shuffle();

            Children.Clear();
            for (int i = 0; i < cardRows; i++)
            {
                for (int j = 0; (j < cardCols) && (i * cardsInRow + j < 2 * PairCount); j++)
                {
                    Card card = new Card();
                    card.Theme = Theme;
                    card.ID = cardIDs[i * cardsInRow + j];
                    Grid.SetRow(card, 2 * i + 2);
                    Grid.SetColumn(card, 2 * j + 2);
                    card.OnCardClick += CardOpenedHandler;
                    cards.Add(card);
                    Children.Add(card);
                }
            }
        }

        private void AddRows(int count)
        {
            RowDefinitions.Clear();
            RowDefinition firstRow = new RowDefinition();
            firstRow.Height = new GridLength(1, GridUnitType.Star);
            RowDefinitions.Add(firstRow);

            for (int i = 0; i < count; i++)
            {
                RowDefinition spaceBetween = new RowDefinition();
                spaceBetween.Height = new GridLength(20);
                RowDefinitions.Add(spaceBetween);

                RowDefinition cards = new RowDefinition();
                cards.Height = GridLength.Auto;
                RowDefinitions.Add(cards);
            }

            RowDefinition lastSpaceBetween = new RowDefinition();
            lastSpaceBetween.Height = new GridLength(20);
            RowDefinitions.Add(lastSpaceBetween);

            RowDefinition lastRow = new RowDefinition();
            lastRow.Height = new GridLength(1, GridUnitType.Star);
            RowDefinitions.Add(lastRow);
        }

        private void AddCols(int count)
        {
            ColumnDefinitions.Clear();
            ColumnDefinition firstColumn = new ColumnDefinition();
            firstColumn.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinitions.Add(firstColumn);

            for (int i = 0; i < count; i++)
            {
                ColumnDefinition spaceBetween = new ColumnDefinition();
                spaceBetween.Width = new GridLength(20);
                ColumnDefinitions.Add(spaceBetween);

                ColumnDefinition cards = new ColumnDefinition();
                cards.Width = GridLength.Auto;
                ColumnDefinitions.Add(cards);
            }

            ColumnDefinition lastSpaceBetween = new ColumnDefinition();
            lastSpaceBetween.Width = new GridLength(20);
            ColumnDefinitions.Add(lastSpaceBetween);

            ColumnDefinition lastColumn = new ColumnDefinition();
            lastColumn.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinitions.Add(lastColumn);
        }
        #endregion

        #region Event Handlers
        private void CardOpenedHandler(object sender, EventArgs e)
        {
            CurrentGameData.Game.NumberOfPairsOpened++;

            Card card = sender as Card;
            if (firstOpened != null && secondOpened == null)
            {
                secondOpened = card;
                if (firstOpened.ID == secondOpened.ID)
                {
                    firstOpened.IsMatched = true;
                    secondOpened.IsMatched = true;
                    firstOpened = null;
                    secondOpened = null;
                    pairsMatched++;
                    if (pairsMatched == PairCount)
                    {
                        CurrentGameData.Game.NumberOfPairsOpened /= 2;
                        CurrentGameData.Game.Time = DateTime.Now - CurrentGameData.StartTime;
                        ScoresManager.UpdateRankList(Theme, PairCount, CurrentGameData.Game);

                        GameFinishedMessage gameFinishedMessage = new GameFinishedMessage();
                        gameFinishedMessage.Theme = Theme;
                        Grid.SetRow(gameFinishedMessage, 0);
                        Grid.SetRowSpan(gameFinishedMessage, 2 * cardRows + 3);
                        Grid.SetColumn(gameFinishedMessage, 0);
                        Grid.SetColumnSpan(gameFinishedMessage, 2 * cardCols + 3);
                        Children.Add(gameFinishedMessage);
                    }
                }
            }
            else
            {
                if (firstOpened != null) firstOpened.IsOpen = false;
                if (secondOpened != null) secondOpened.IsOpen = false;
                firstOpened = card;
                secondOpened = null;
            }
        }

        private static void OnPairCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CardDeck cardDeck = d as CardDeck;
            cardDeck.DisplayCards();
        }
        #endregion
    }
}
