using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wumpus.WinFormsApp
{
    public partial class MainForm : Form
    {
        PictureBox[] doorButtons;

        public MainForm()
        {
            InitializeComponent();
            doorButtons = new PictureBox[6];
            doorButtons[0] = door0;
            doorButtons[1] = door1;
            doorButtons[2] = door2;
            doorButtons[3] = door3;
            doorButtons[4] = door4;
            doorButtons[5] = door5;
        }

        // called to update the room display
        public void UpdateRoomDisplay()
        {
            Room r = GameControl.GetCurrentRoom();
            // check to see which connected doors we have
            for (int i = 0; i < 6; i++)
            {
                // is there a connected room?
                int cr = r.GetConnectedRoomNumber(i);
                // show or hide the door button
                doorButtons[i].Visible = (cr != -1);
            }

            UpdateGameStatistics();
        }

        // called to update the counts for (coins, turns, arrows)
        public void UpdateGameStatistics()
        {
            roomNumberLabel.Text = GameControl.GetCurrentRoom().RoomNumber.ToString();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateRoomDisplay();
        }

        private void MoveThroughDoor(int DoorNumber)
        {
            GameControl.MoveThroughDoor(DoorNumber);
            UpdateRoomDisplay();
        }

        private void door0_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(0);
        }

        private void door1_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(1);   
        }

        private void door2_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(2);        
        }

        private void door3_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(3);
        }

        private void door4_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(4);
        }

        private void door5_Click(object sender, EventArgs e)
        {
            MoveThroughDoor(5);
        }
    }
}
