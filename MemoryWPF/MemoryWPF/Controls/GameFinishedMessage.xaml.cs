using MemoryWPF.DataHelpers;
using System.Windows;
using System.Windows.Controls;

namespace MemoryWPF.Controls
{
    /// <summary>
    /// Interaction logic for GameFinishedMessage.xaml
    /// </summary>
    public partial class GameFinishedMessage : Border
    {
        #region Dependency Properties
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
            "Theme", typeof(Theme), typeof(GameFinishedMessage), new PropertyMetadata(Theme.Animals)
        );
        #endregion

        #region Public Properties
        public Theme Theme
        {
            get { return (Theme)GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }

        private string message = "Game compleated!";
        public string Message => message;
        #endregion

        public GameFinishedMessage()
        {
            InitializeComponent();
        }
    }
}
