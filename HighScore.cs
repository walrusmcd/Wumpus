using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.WinFormsApp
{
    class Score
    {
        public Score(string name, int highScore)
        {
            Name = name;
            HighScore = highScore;
        }
        public string Name;
        public int HighScore;
    }

    class HighScore
    {
    }
}
