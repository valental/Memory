using System;
using System.Collections.Generic;
using System.IO;

namespace MemoryWPF.DataHelpers
{
    public static class ScoresManager
    {
        public static List<GameData> GetRankList(Theme t, int size)
        {
            string filename = @"RankingData/" + t + "_" + size.ToString() + ".txt";
            string line;
            List<GameData> list = new List<GameData>();

            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    list.Add( new GameData (parts[0], TimeSpan.Parse(parts[1]), int.Parse(parts[2]), list.Count+1) );
                }
                file.Close();
            }
            return list;
        }

        public static void UpdateRankList(Theme t, int size, GameData data)
        {
            Directory.CreateDirectory("RankingData");
            string filename = @"RankingData/" + t + "_" + size.ToString() + ".txt";

            if (!File.Exists(filename))
            {
                string line = data.PlayerName + "," + data.Time.ToString() + "," + data.NumberOfPairsOpened.ToString();
                File.WriteAllText(filename, line); // creates a file as well so we don't have to create it separately
            }
            else
            {
                List<GameData> list = GetRankList(t, size);
                int index = list.FindIndex(player => player.PlayerName == data.PlayerName);

                if (index != -1 && list[index].Time > data.Time)
                {
                    list[index].Time = data.Time;
                    list[index].NumberOfPairsOpened = data.NumberOfPairsOpened;
                }
                else
                {
                    if(list.Count < 10)
                    {
                        list.Add(new GameData(data.PlayerName, data.Time, data.NumberOfPairsOpened));
                    }
                    else if(list[9].Time > data.Time)
                    {
                        list.RemoveAt(9);
                        list.Add(new GameData(data.PlayerName, data.Time, data.NumberOfPairsOpened));
                    }
                }

                list.Sort((a, b) => a.Time.CompareTo(b.Time));

                using (StreamWriter sw = File.CreateText(filename))
                {
                    foreach (GameData player in list)
                        sw.WriteLine(player.PlayerName + "," + player.Time + "," + player.NumberOfPairsOpened);
                }  
            }
        }
    }
}
