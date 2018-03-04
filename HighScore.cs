using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Wumpus.WinFormsApp
{
    class Score : IComparable
    {
        public string Name;
        public string CavePlayed;
        public int HighScore;
        public int NumberOfTurns;
        public int NumberOfCoins;
        public int NumberOfArrows;

        public int CompareTo(object obj)
        {
            Score s = (Score)obj;
            // Less than zero == this instance precedes other in the sort order.
            return (s.HighScore - HighScore);
        }

        public void CalculateHighScore()
        {
            HighScore = 100 - NumberOfTurns + NumberOfCoins + (10 * NumberOfArrows);
        }
    }

    class HighScore
    {
        List<Score> highScores;

        public HighScore()
        {
            // always use an empty collection (never null)
            highScores = new List<Score>();
            LoadFile();
        }

        public List<Score> GetHighScores()
        {
            return highScores;
        }

        public void AddScore(Score score)
        {
            // add the score
            highScores.Add(score);
            // sort it
            highScores.Sort();
        }

        private void LoadFile()
        {
            try
            {
                var json = File.ReadAllText("highScores.json");
                highScores = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Score>>(json);
            }
            catch (System.IO.FileNotFoundException e)
            {
                // this is ok, we have no file and will just ignore and load nothing
                // the first time we play a game and score will create a new file
            }
        }

        private void SaveFile()
        {
            var json = JsonConvert.SerializeObject(highScores);
            File.WriteAllText("highScores.json", json);
        }
    }
}
