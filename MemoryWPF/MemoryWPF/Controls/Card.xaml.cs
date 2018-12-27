using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Controls
{
    /// <summary>
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class Card : Button
    {
        #region Dependecy Properties
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
            "SelectedTheme", typeof(Theme), typeof(Card), new PropertyMetadata(Theme.WildAnimals)
        );

        public static readonly DependencyProperty IDProperty = DependencyProperty.Register(
            "ID", typeof(int), typeof(Card), new PropertyMetadata(0)
        );

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register(
            "IsOpen", typeof(bool), typeof(Card), new PropertyMetadata(false)
        );

        public static readonly DependencyProperty IsMatchedProperty = DependencyProperty.Register(
            "IsMatched", typeof(bool), typeof(Card), new PropertyMetadata(false)
        );
        #endregion

        #region Public Properties
        public event EventHandler OnCardClick;

        public Theme Theme
        {
            get { return (Theme)GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }

        public int ID
        {
            get { return (int)GetValue(IDProperty); }
            set { SetValue(IDProperty, value); }
        }

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public bool IsMatched
        {
            get { return (bool)GetValue(IsMatchedProperty); }
            set { SetValue(IsMatchedProperty, value); }
        }
        #endregion

        #region Commands
        private RelayCommand flipCommand;
        public ICommand FlipCommand
        {
            get
            {
                if (flipCommand == null)
                    flipCommand = new RelayCommand(Flip);
                return flipCommand;
            }
        }
        #endregion

        #region Constructor
        public Card()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        public void Flip()
        {
            if (!IsMatched && !IsOpen)
            {
                OnCardClick(this, new EventArgs());
                IsOpen = true;
            }
        }
        #endregion
    }
}
