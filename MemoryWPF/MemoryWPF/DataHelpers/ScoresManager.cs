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
            //dodati try catch!!!!
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    list.Add( new GameData (parts[0], TimeSpan.Parse(parts[1]), int.Parse(parts[2])) );
                }
                file.Close();
            }

            /*if (list.Count < 10)
            {
                for (int i = 0; i < 10 - list.Count; i++)
                    list.Add(new GameData("", TimeSpan.Zero, 0));
            }*/

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

                if (list[list.Count - 1].Time > data.Time) 
                {
                    int index = list.FindIndex(player => player.PlayerName == data.PlayerName);

                    if (index != -1) // there is already a player with the same playerName in the list
                    {
                        if (list[index].Time > data.Time) // player broke his own record
                        {
                            list[index].Time = data.Time;
                            list[index].NumberOfPairsOpened = data.NumberOfPairsOpened;
                        }
                    }

                    else
                    {
                        list.RemoveAt(list.Count - 1);
                        list.Add(new GameData(data.PlayerName, data.Time, data.NumberOfPairsOpened));
                    }

                    list.Sort((a, b) => a.Time.CompareTo(b.Time));

                    StreamWriter sw = new StreamWriter(filename);
                    for (int i = 0; i < list.Count; i++)
                    {
                        string line = list[i].PlayerName + "," + list[i].Time.ToString() + "," + list[i].NumberOfPairsOpened.ToString();
                        sw.WriteLine(line);
                    }
                }
            }

        }


    }
}
