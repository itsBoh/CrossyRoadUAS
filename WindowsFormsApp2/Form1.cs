using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int vertikal = 0;
        int horizontal = 0;
        int hitungSkor = 0;
        int nyawa = 3;
        Random rand = new Random();
        List<string> listObj = new List<string>();
        List<string> listObs = new List<string>();
        List<int> listKecepatan = new List<int>();
        int pilih;
        int kecepatan = 20;
        int tinggi1 = 57;
        int tinggi2 = 138;
        int tinggi3 = 219;
        int tinggi4 = 301;
        int tambah = 0;
        int hilang = 500;
        int hitunglevel = 1;
        int awal = 0;
        int tabrak = 0;
        public Form1()
        {
            InitializeComponent();
            tulisannyawa.Text = "LIFE";
            listObj.Add("obj1");
            listObj.Add("obj2");
            listObj.Add("obj3");
            listObj.Add("obj4");
            listObj.Add("obj5");
            listObj.Add("obj6");
            listObj.Add("obj7");
            listObj.Add("obj8");

            for (int i = 1; i <= 4; i++)
            {
                pilih = rand.Next(0, listObj.Count);
                listObs.Add(listObj[pilih]);
                listObj.RemoveAt(pilih);
                listKecepatan.Add(rand.Next(kecepatan - 5, kecepatan + 1));
            }
            listObs.Add("");
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
                if (awal == 0)
                {
                    pilih = rand.Next(0, listObj.Count - 1);
                    listObs.Add(listObj[pilih]);
                    listObj.RemoveAt(pilih);
                    listKecepatan.Add(rand.Next(kecepatan - 5, kecepatan + 1));
                    awal = 1;
                }
                else
                {
                    listObj.Add(listObs[0]);
                    listObs.RemoveAt(0);
                    pilih = rand.Next(0, listObj.Count); //kalau listobs eror
                    listObs.Add(listObj[pilih]);
                    listObj.RemoveAt(pilih);
                    listKecepatan.RemoveAt(0);
                    listKecepatan.Add(rand.Next(kecepatan - 5, kecepatan));
                }
                if (hitungSkor % 4 == 0 && hitungSkor > 1)
                {
                    kecepatan += 2;
                    hitunglevel++;
                }
                tabrak = 0;
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
            if (Player.Bounds.IntersectsWith(obj1.Bounds) ||
                Player.Bounds.IntersectsWith(obj2.Bounds) ||
                Player.Bounds.IntersectsWith(obj3.Bounds) ||
                Player.Bounds.IntersectsWith(obj4.Bounds) ||
                Player.Bounds.IntersectsWith(obj5.Bounds) ||
                Player.Bounds.IntersectsWith(obj6.Bounds) ||
                Player.Bounds.IntersectsWith(obj7.Bounds) ||
                Player.Bounds.IntersectsWith(obj8.Bounds))
            {
                nyawa--;
                nyawalive.Left += 45;
                //reset posisi player
                Player.Top = 365;
                Player.Left = 270;
                tabrak = 100;
            }
            if (awal != 0)
                tambah = 81;
            if (nyawa == 0)
                gametimer.Stop();
            skor.Text = "SCORE : " + hitungSkor.ToString();

            //0
            if (listObs[0] == "obj1")
            {
                obj1.Top = tinggi4 + tambah + tabrak;
                obj1.Left -= listKecepatan[0];
            }
            else
                obj1.Top = hilang;
            if (listObs[0] == "obj2")
            {
                obj2.Top = tinggi4 + tambah + tabrak;
                obj2.Left += listKecepatan[0];
            }
            else
                obj2.Top = hilang;
            if (listObs[0] == "obj3")
            {
                obj3.Top = tinggi4 + tambah + tabrak;
                obj3.Left -= listKecepatan[0];
            }
            else
                obj3.Top = hilang;
            if (listObs[0] == "obj4")
            {
                obj4.Top = tinggi4 + tambah + tabrak;
                obj4.Left += listKecepatan[0];
            }
            else
                obj4.Top = hilang;
            if (listObs[0] == "obj5")
            {
                obj5.Top = tinggi4 + tambah + tabrak;
                obj5.Left -= listKecepatan[0];
            }
            else
                obj5.Top = hilang;
            if (listObs[0] == "obj6")
            {
                obj6.Top = tinggi4 + tambah + tabrak;
                obj6.Left += listKecepatan[0];
            }
            else
                obj6.Top = hilang;
            if (listObs[0] == "obj7")
            {
                obj7.Top = tinggi4 + tambah + tabrak;
                obj7.Left -= listKecepatan[0];
            }
            else
                obj7.Top = hilang;
            if (listObs[0] == "obj8")
            {
                obj8.Top = tinggi4 + tambah + tabrak;
                obj8.Left += listKecepatan[0];
            }
            else
                obj8.Top = hilang;


            //1
            if (listObs[1] == "obj1")
            {
                obj1.Top = tinggi3 + tambah;
                obj1.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj2")
            {
                obj2.Top = tinggi3 + tambah;
                obj2.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj3")
            {
                obj3.Top = tinggi3 + tambah;
                obj3.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj4")
            {
                obj4.Top = tinggi3 + tambah;
                obj4.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj5")
            {
                obj5.Top = tinggi3 + tambah;
                obj5.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj6")
            {
                obj6.Top = tinggi3 + tambah;
                obj6.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj7")
            {
                obj7.Top = tinggi3 + tambah;
                obj7.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj8")
            {
                obj8.Top = tinggi3 + tambah;
                obj8.Left += listKecepatan[1];
            }


            //2
            if (listObs[2] == "obj1")
            {
                obj1.Top = tinggi2 + tambah;
                obj1.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj2")
            {
                obj2.Top = tinggi2 + tambah;
                obj2.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj3")
            {
                obj3.Top = tinggi2 + tambah;
                obj3.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj4")
            {
                obj4.Top = tinggi2 + tambah;
                obj4.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj5")
            {
                obj5.Top = tinggi2 + tambah;
                obj5.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj6")
            {
                obj6.Top = tinggi2 + tambah;
                obj6.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj7")
            {
                obj7.Top = tinggi2 + tambah;
                obj7.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj8")
            {
                obj8.Top = tinggi2 + tambah;
                obj8.Left += listKecepatan[2];
            }


            //3
            if (listObs[3] == "obj1")
            {
                obj1.Top = tinggi1 + tambah;
                obj1.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj2")
            {
                obj2.Top = tinggi1 + tambah;
                obj2.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj3")
            {
                obj3.Top = tinggi1 + tambah;
                obj3.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj4")
            {
                obj4.Top = tinggi1 + tambah;
                obj4.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj5")
            {
                obj5.Top = tinggi1 + tambah;
                obj5.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj6")
            {
                obj6.Top = tinggi1 + tambah;
                obj6.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj7")
            {
                obj7.Top = tinggi1 + tambah;
                obj7.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj8")
            {
                obj8.Top = tinggi1 + tambah;
                obj8.Left += listKecepatan[3];
            }
            //4
            if (listObs[4] == "obj1")
            {
                obj1.Top = tinggi1;
                obj1.Left -= listKecepatan[3];
            }
            else if (listObs[4] == "obj2")
            {
                obj2.Top = tinggi1;
                obj2.Left += listKecepatan[3];
            }
            else if (listObs[4] == "obj3")
            {
                obj3.Top = tinggi1;
                obj3.Left -= listKecepatan[3];
            }
            else if (listObs[4] == "obj4")
            {
                obj4.Top = tinggi1;
                obj4.Left += listKecepatan[3];
            }
            else if (listObs[4] == "obj5")
            {
                obj5.Top = tinggi1;
                obj5.Left -= listKecepatan[3];
            }
            else if (listObs[4] == "obj6")
            {
                obj6.Top = tinggi1;
                obj6.Left += listKecepatan[3];
            }
            else if (listObs[4] == "obj7")
            {
                obj7.Top = tinggi1;
                obj7.Left -= listKecepatan[3];
            }
            else if (listObs[4] == "obj8")
            {
                obj8.Top = tinggi1;
                obj8.Left += listKecepatan[3];
            }
            else { }


            if (obj1.Left < 0)
                obj1.Left = 800;
            if (obj2.Left > 900)
                obj2.Left = -110;
            if (obj3.Left < 0)
                obj3.Left = 800;
            if (obj4.Left > 900)
                obj4.Left = -110;
            if (obj5.Left < 0)
                obj5.Left = 800;
            if (obj6.Left > 900)
                obj6.Left = -110;
            if (obj7.Left < 0)
                obj7.Left = 800;
            if (obj8.Left > 900)
                obj8.Left = -110;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;

            //ini buat nyoba
            level.Text = "Level : " + hitunglevel;
        }
    }
}
