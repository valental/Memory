using System;

namespace MemoryWPF.DataHelpers
{
    public class GameData
    {

        public string PlayerName { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPairsOpened { get; set; }

        public GameData(string name, TimeSpan t, int number)
        {
            PlayerName = name;
            Time = t;
            NumberOfPairsOpened = number;
        }
    }
}
