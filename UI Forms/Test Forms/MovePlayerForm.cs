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
    public partial class MovePlayerForm : Form
    {
        public int DoorNumber;
        public MovePlayerForm()
        {
            InitializeComponent();
            CenterToParent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // remember the number
            DoorNumber = Convert.ToInt32(textBox1.Text);
        }
    }
}
