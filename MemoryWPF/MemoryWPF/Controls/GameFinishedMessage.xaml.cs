using System.Windows;
using System.Windows.Controls;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Controls
{
    /// <summary>
    /// Interaction logic for GameFinishedMessage.xaml
    /// </summary>
    public partial class GameFinishedMessage : Border
    {
        #region Dependency Properties
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
            "Theme", typeof(Theme), typeof(GameFinishedMessage), new PropertyMetadata(Theme.WildAnimals)
        );
        #endregion

        #region Public Properties
        public Theme Theme
        {
            get { return (Theme)GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }
        double temp = (double)CurrentGameData.Game.Time.Seconds + ((double)CurrentGameData.Game.Time.Milliseconds / 1000);
        public string Message => "Game completed!\nTime: " + temp.ToString() + "s\nPairs opened: "
                                + CurrentGameData.Game.NumberOfPairsOpened;
        #endregion

        public GameFinishedMessage()
        {
            InitializeComponent();
        }
    }
}
