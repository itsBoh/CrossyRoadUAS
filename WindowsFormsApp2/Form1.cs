﻿using System;
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
        int kecepatanOb = 20;


        public Form1()
        {
            InitializeComponent();

        }
        public void DrawRectangle(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0,0,200,200);
        }
        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && Player.Top > 300)
            {
                vertikal = -80;
            }
            else if (e.KeyCode == Keys.Up && Player.Top <300)
            {

            }
            if (e.KeyCode == Keys.Down && Player.Top < 300)
            {
                vertikal = 80;
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
            if (Player.Bounds.IntersectsWith(ob1.Bounds))
                gametimer.Stop();

            ob1.Left -= kecepatanOb;
            if (ob1.Left < 0)
                ob1.Left = 800;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;
        }
        private static Graphics CreateGraphocs()
        {
            throw new NotImplementedException();
        }
    }
}
