using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.WinFormsApp
{
    static class GameControl
    {
        public static Room GetCurrentRoom()
        {
            return new Room();
        }

        public static void MoveThroughDoor(int DoorNumber)
        {

        }

        public static string[] GetAvailableCaves()
        {
            string[] AvailableCaves = new string[5];

            AvailableCaves[0] = "Cave1";
            AvailableCaves[1] = "Cave2";
            AvailableCaves[2] = "Cave3";
            AvailableCaves[3] = "Cave4";
            AvailableCaves[4] = "Cave5";

            return AvailableCaves;
        }

        public static Score[] GetHighScores()
        {
            Score[] HighScores = new Score[5];

            HighScores[0] = new Score("Tim", 50);
            HighScores[1] = new Score("Dana", 30);
            HighScores[2] = new Score("Paul", 20);
            HighScores[3] = new Score("JoFo", 90);
            HighScores[4] = new Score("Adam", 50);

            return HighScores;
        }
    }
}
