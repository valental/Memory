using System;
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
        #region Dependecy Properties
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
            "Theme", typeof(Theme), typeof(CardDeck), new PropertyMetadata(Theme.Animals)
        );

        public static readonly DependencyProperty PairCountProperty = DependencyProperty.Register(
            "PairCount", typeof(int), typeof(CardDeck), new PropertyMetadata(11)
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

            DisplayCards();
        }
        #endregion

        #region Methods
        private void DisplayCards()
        {
            const int pairsInRow = 4;
            int cardRows = (int)Math.Ceiling((double)PairCount / (double)pairsInRow);
            int cardCols = 2 * (PairCount < pairsInRow ? PairCount : pairsInRow);

            AddRows(cardRows);
            AddCols(cardCols);

            for (int i = 0; i < cardRows; i++)
            {
                for (int j = 0; (j < cardCols) && (2 * i * pairsInRow + j < 2 * PairCount); j++)
                {
                    Card card = new Card();
                    card.Theme = Theme.Animals;
                    card.ID = 0;
                    Grid.SetRow(card, 2 * i + 2);
                    Grid.SetColumn(card, 2 * j + 2);
                    Children.Add(card);
                }
            }
        }

        private void AddRows(int count)
        {
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
    }
}
