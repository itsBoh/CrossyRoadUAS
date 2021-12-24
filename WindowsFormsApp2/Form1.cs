using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int vertikal = 0;
        int horizontal = 0;
        int pergerakanHorizontal = 60;
        public Form1()
        {
            InitializeComponent();
        }
        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && Player.Top > 300)
            {
                vertikal = -100;
            }
            if (e.KeyCode == Keys.Down && Player.Top < 300)
            {
                vertikal = 100;
            }
            if (e.KeyCode == Keys.Left && Player.Left > 60)
            {
                horizontal = -60;
            }
            if (e.KeyCode == Keys.Right && Player.Left <= 480)
            {
                horizontal = 60;
            }
        }
        private void gametimerevent(object sender, EventArgs e)
        {
            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;
        }
    }
}
