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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();

            // show the high score list 
            Score[] highScores = GameControl.GetHighScores();
            foreach (Score score in highScores)
            {
                ListViewItem lvi = new ListViewItem(score.Name);
                lvi.SubItems.Add(score.HighScore.ToString());
                scoreListView.Items.Add(lvi);           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGameForm f = new NewGameForm();
            f.ShowDialog(this);
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
