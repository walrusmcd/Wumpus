using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.WinFormsApp
{
    static class GameControl
    {
        static private HighScore highScore = new HighScore();
        static public Player Player = new Player();

        public static Room GetCurrentRoom()
        {
            return new Room();
        }

        public static void MoveThroughDoor(int DoorNumber)
        {
            // moving through a tunnel counts as a turn
            Player.NumberOfTurns += 1;
            // you get a gold coin each tunnel
            Player.GoldCoins += 1;
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

        public static List<Score> GetHighScores()
        {
            return highScore.GetHighScores();
        }
    }
}
