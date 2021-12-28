using System;
using System.Collections.Generic;
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
        int randomObj;
        Random rand = new Random();
        List<string> listObj = new List<string>();
        List<int> kecepatan = new List<int>();


        public Form1()
        {
            InitializeComponent();

            

            tulisannyawa.Text = "LIFE";
            listObj.Add("");
            listObj.Add("mobil1");
            listObj.Add("mobil2");
            listObj.Add("mobil3");
            listObj.Add("mobil4");
            for (int i = 0; i < 5; i++)
                kecepatan.Add(rand.Next(kecepatanOb - 10, kecepatanOb + 1));
        }
        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && Player.Top > 300)
            {
                vertikal = -80;
            }
            else if (e.KeyCode == Keys.Up && Player.Top < 300)
            {
                hitungSkor++;
                if (hitungSkor % 4 == 0 && hitungSkor > 1)
                    kecepatanOb += 2;
                randomObj = rand.Next(1, 9);
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
            if (Player.Bounds.IntersectsWith(mobil1.Bounds))
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

            //gerak obj
            mobil1.Left -= kecepatanOb;
            if (mobil1.Left < 0)
                mobil1.Left = 800;
            mobil2.Left += kecepatanOb;
            if (mobil2.Left > 900)
                mobil2.Left = -110;
            mobil3.Left -= kecepatanOb;
            if (mobil3.Left < 0)
                mobil3.Left = 800;
            mobil4.Left += kecepatanOb;
            if (mobil4.Left > 900)
                mobil4.Left = -110;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;

            //ini buat nyoba
            buatnyoba.Text = randomObj.ToString();
        }
    }
}
