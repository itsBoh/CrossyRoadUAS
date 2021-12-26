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
        int kecepatanOb = 20;
        int hitungSkor = 0;
        int nyawa = 3;

        public Form1()
        {
            InitializeComponent();
            tulisannyawa.Text = "LIFE";
        }
        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && Player.Top > 300)
            {
                vertikal = -80;
            }
            else if (e.KeyCode == Keys.Up && Player.Top <300)
            {
                hitungSkor++;
                if (hitungSkor % 4 == 0 && hitungSkor > 1)
                    kecepatanOb += 2;
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
            {
                nyawa--;
                nyawalive.Left += 60;
                //reset posisi player
                Player.Top = 365;
                Player.Left = 270;
            }
            if (nyawa == 0)
                gametimer.Stop();

            skor.Text = "SCORE : " + hitungSkor.ToString();

            ob1.Left -= kecepatanOb;
            if (ob1.Left < 0)
                ob1.Left = 800;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;
        }
    }
}
