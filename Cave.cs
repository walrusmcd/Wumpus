using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.WinFormsApp
{
    class Room
    {
        int[] ConnectedRooms;

        public Room()
        {
            Random r = new Random();
            ConnectedRooms = new int[6];
            ConnectedRooms[0] = -1;
            ConnectedRooms[1] = -1;
            ConnectedRooms[2] = -1;
            ConnectedRooms[3] = -1;
            ConnectedRooms[4] = -1;
            ConnectedRooms[5] = -1;

            ConnectedRooms[r.Next(0, 5)] = r.Next(0, 29);
            ConnectedRooms[r.Next(0, 5)] = r.Next(0, 29);
            ConnectedRooms[r.Next(0, 5)] = r.Next(0, 29);

            RoomNumber = r.Next(1, 30);
        }

        // the numer of this room
        public int RoomNumber;
        
        // for a given DoorNumber, where 0 starts at the top
        // and goes clockwise around the hexagon
        // this will return if you can get to a room through that door, 
        // where -1 == no door
        public int GetConnectedRoomNumber(int DoorNumber)
        {
            return ConnectedRooms[DoorNumber];
        }
    }

    class Cave
    {

    }
}
