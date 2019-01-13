using System;

namespace MemoryWPF.DataHelpers
{
    public class GameData
    {
        public string PlayerName { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPairsOpened { get; set; }
        public int Rank { get; set; }

        public GameData(string name, TimeSpan t, int number = 0, int rank = 0)
        {
            PlayerName = name;
            Time = t;
            NumberOfPairsOpened = number;
            Rank = rank;
        }
    }
}
