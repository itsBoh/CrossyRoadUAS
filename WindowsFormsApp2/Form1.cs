using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int vertikal = 0;
        int horizontal = 0;
        int kecepatanObbawah = 20;
        int kecepatanObatas = 25;
        int hitungSkor = 0;
        int nyawa = 3;
        int randomObj;
        int awal = 0;
        Random rand = new Random();
        List<string> listObj = new List<string>();
        List<string> listObst = new List<string>();


        public Form1()
        {
            InitializeComponent();
            tulisannyawa.Text = "LIFE";
            listObj.Add("obj1");
            listObj.Add("obj2");
            listObj.Add("obj3");
            listObj.Add("obj4");
            listObj.Add("obj5");
            listObj.Add("obj5");
            listObj.Add("obj6");
            listObj.Add("obj7");
            listObj.Add("obj8");

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
                {
                    kecepatanObbawah += 2;
                    kecepatanObatas += 2;
                }
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
                nyawalive.Left += 45;
                //reset posisi player
                Player.Top = 365;
                Player.Left = 270;
            }
            if (nyawa == 0)
                gametimer.Stop();

            skor.Text = "SCORE : " + hitungSkor.ToString();

            //gerak obj
            mobil1.Left -= kecepatanObbawah;
            if (mobil1.Left < 0)
                mobil1.Left = 800;
            mobil2.Left += kecepatanObbawah;
            if (mobil2.Left > 900)
                mobil2.Left = -110;
            mobil3.Left -= kecepatanObbawah;
            if (mobil3.Left < 0)
                mobil3.Left = 800;
            mobil4.Left += kecepatanObbawah;
            if (mobil4.Left > 900)
                mobil4.Left = -110;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;

            //ini buat nyoba
            buatnyoba.Text = mobil4.Top.ToString()+ " " + mobil4.Left.ToString();
        }
    }
}
