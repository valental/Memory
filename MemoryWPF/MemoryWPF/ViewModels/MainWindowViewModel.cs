using MemoryWPF.DataHelpers;

namespace MemoryWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Theme theme = Theme.Animals;
        public Theme Theme
        {
            get => theme;
            set
            {
                theme = value;
                OnPropertyChanged("Theme");
            }
        }

        private int pairCount = 1;
        public int PairCount
        {
            get => pairCount;
            set
            {
                pairCount = value;
                OnPropertyChanged("PairCount");
            }
        }
    }
}
