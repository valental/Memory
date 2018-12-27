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
        
        public string Message => "Game completed!";
        #endregion

        public GameFinishedMessage()
        {
            InitializeComponent();
        }
    }
}
