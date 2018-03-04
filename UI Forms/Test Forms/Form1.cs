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
    public partial class Form1 : Form
    {
        private UserInterface ui;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ui = new UserInterface();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ui.StartNewGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // which door?
            MovePlayerForm f = new MovePlayerForm();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                ui.MovePlayer(f.DoorNumber);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // which door?
            MovePlayerForm f = new MovePlayerForm();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                ui.ShootArrow(f.DoorNumber);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ui.PurchaseArrows();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ui.PurchaseSecret();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowTriviaForm f = new ShowTriviaForm();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                ui.ShowTrivia(f.QuestionsToWin, f.TotalQuestions);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ui.UpdateHints();
        }
    }
}
