using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {   
        //declare variable
        int vertikal = 0; //pergerakan naik turun
        int horizontal = 0; //pergerakan ke samping
        int hitungSkor = 0; //score
        int nyawa = 3; 
        int pilih; //remove obstacle
        int kecepatan = 10; //kec.awal obstacle
        int tinggi1 = 57; //obstacle paling atas
        int tinggi2 = 138; //obstacle kedua dr atas
        int tinggi3 = 219; //obstacle kedua dr bwh
        int tinggi4 = 301; //obstacle plg bwh
        int hilang = 500; //obstacle yg ga kepake (di luar map)
        int hitunglevel = 1; //level
        int timerMati = 0; //game over
        Random rand = new Random(); //random obstacle dan kecepatan
        List<string> listObj = new List<string>(); //list objek (kendaraan)
        List<string> listObs = new List<string>(); //list obstacle (rintangan)
        List<int> listKecepatan = new List<int>(); //list kecepatan masing-masing obstacle
        public Form1()
        {
            InitializeComponent();
            tulisannyawa.Text = "LIFE"; //text box pojok kanan atas

            // memasukkan 8 objek ke dalam list objek
            listObj.Add("obj1");
            listObj.Add("obj2");
            listObj.Add("obj3");
            listObj.Add("obj4");
            listObj.Add("obj5");
            listObj.Add("obj6");
            listObj.Add("obj7");
            listObj.Add("obj8");
            
            //memilih objek yang muncul sebagai obstacle
            for (int i = 1; i <= 4; i++)
            {
                pilih = rand.Next(0, listObj.Count); //variable pilih objek
                listObs.Add(listObj[pilih]); //memasukkan objek yang terpilih dari random ke dalam list obstacle
                listObj.RemoveAt(pilih); //menghapus objek yang sudah terpilih dari list objek agar tidak muncul lebih dari sekali dalam satu level
                listKecepatan.Add(rand.Next(kecepatan - 5, kecepatan + 1)); 
            }
        }
        private void keydownevent(object sender, KeyEventArgs e)
        {
            //pergerakan ke atas
            if (e.KeyCode == Keys.Up)
            {
                vertikal = -80;
                hitungSkor++;
                timerMati = 0; 
            }
            //pergerakan ke bawah
            if (e.KeyCode == Keys.Down && Player.Top < 300)
            {
                vertikal = 80;
                timerMati = 0;
            }
            //pergerakan ke kiri
            if (e.KeyCode == Keys.Left && Player.Left > 60)
            {
                horizontal = -60;
                timerMati = 0;
            }
            //pergerakan ke kanan
            if (e.KeyCode == Keys.Right && Player.Left <= 480)
            {
                horizontal = 60;
                timerMati = 0;
            }
        }
        private void gametimerevent(object sender, EventArgs e)
        {
            if (Player.Top < 40) //kalau posisi player sudah melewati obstacle plg atas
            {
                Player.Top = 365; //reset posisi player
                Player.Left = 270; //reset posisi player
                kecepatan += 1;
                hitunglevel++;
                //reset list obstacle
                for (int i = listObs.Count-1; i >= 0; i--)
                {
                    listObj.Add(listObs[i]);
                    listObs.RemoveAt(i);
                }
                listKecepatan.Clear();
                for (int i = 1; i <= 4; i++)
                {
                    pilih = rand.Next(0, listObj.Count);
                    listObs.Add(listObj[pilih]);
                    listObj.RemoveAt(pilih);
                    listKecepatan.Add(rand.Next(kecepatan - 5, kecepatan + 1));
                }
            }
            timerMati++; 

            //jika player bertabrakan dengan objek
            if (Player.Bounds.IntersectsWith(obj1.Bounds) ||
                Player.Bounds.IntersectsWith(obj2.Bounds) ||
                Player.Bounds.IntersectsWith(obj3.Bounds) ||
                Player.Bounds.IntersectsWith(obj4.Bounds) ||
                Player.Bounds.IntersectsWith(obj5.Bounds) ||
                Player.Bounds.IntersectsWith(obj6.Bounds) ||
                Player.Bounds.IntersectsWith(obj7.Bounds) ||
                Player.Bounds.IntersectsWith(obj8.Bounds) ||
                timerMati > 200)
            {
                nyawa--; //nyawa berkurang 1
                nyawalive.Left += 45;
                Player.Top = 365; //reset posisi player
                Player.Left = 270; //reset posisi player
                timerMati = 0;
            }
            //game over
            if (nyawa == 0)
            {
                nyawalive.Left += 135;
                gameover();
                gametimer.Stop();
            }
            skor.Text = "SCORE : " + hitungSkor.ToString(); //text box game over

            //objek ganjil keluar dari kanan menuju ke kiri, objek genap sebaliknya
            //0
            if (listObs[0] == "obj1")
            {
                obj1.Top = tinggi4;
                obj1.Left -= listKecepatan[0];
            }
            else
                obj1.Top = hilang;
            if (listObs[0] == "obj2")
            {
                obj2.Top = tinggi4;
                obj2.Left += listKecepatan[0];
            }
            else
                obj2.Top = hilang;
            if (listObs[0] == "obj3")
            {
                obj3.Top = tinggi4;
                obj3.Left -= listKecepatan[0];
            }
            else
                obj3.Top = hilang;
            if (listObs[0] == "obj4")
            {
                obj4.Top = tinggi4;
                obj4.Left += listKecepatan[0];
            }
            else
                obj4.Top = hilang;
            if (listObs[0] == "obj5")
            {
                obj5.Top = tinggi4;
                obj5.Left -= listKecepatan[0];
            }
            else
                obj5.Top = hilang;
            if (listObs[0] == "obj6")
            {
                obj6.Top = tinggi4;
                obj6.Left += listKecepatan[0];
            }
            else
                obj6.Top = hilang;
            if (listObs[0] == "obj7")
            {
                obj7.Top = tinggi4;
                obj7.Left -= listKecepatan[0];
            }
            else
                obj7.Top = hilang;
            if (listObs[0] == "obj8")
            {
                obj8.Top = tinggi4;
                obj8.Left += listKecepatan[0];
            }
            else
                obj8.Top = hilang;


            //1
            if (listObs[1] == "obj1")
            {
                obj1.Top = tinggi3;
                obj1.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj2")
            {
                obj2.Top = tinggi3;
                obj2.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj3")
            {
                obj3.Top = tinggi3;
                obj3.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj4")
            {
                obj4.Top = tinggi3;
                obj4.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj5")
            {
                obj5.Top = tinggi3;
                obj5.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj6")
            {
                obj6.Top = tinggi3;
                obj6.Left += listKecepatan[1];
            }
            else if (listObs[1] == "obj7")
            {
                obj7.Top = tinggi3;
                obj7.Left -= listKecepatan[1];
            }
            else if (listObs[1] == "obj8")
            {
                obj8.Top = tinggi3;
                obj8.Left += listKecepatan[1];
            }


            //2
            if (listObs[2] == "obj1")
            {
                obj1.Top = tinggi2;
                obj1.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj2")
            {
                obj2.Top = tinggi2;
                obj2.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj3")
            {
                obj3.Top = tinggi2;
                obj3.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj4")
            {
                obj4.Top = tinggi2;
                obj4.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj5")
            {
                obj5.Top = tinggi2;
                obj5.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj6")
            {
                obj6.Top = tinggi2;
                obj6.Left += listKecepatan[2];
            }
            else if (listObs[2] == "obj7")
            {
                obj7.Top = tinggi2;
                obj7.Left -= listKecepatan[2];
            }
            else if (listObs[2] == "obj8")
            {
                obj8.Top = tinggi2;
                obj8.Left += listKecepatan[2];
            }


            //3
            if (listObs[3] == "obj1")
            {
                obj1.Top = tinggi1;
                obj1.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj2")
            {
                obj2.Top = tinggi1;
                obj2.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj3")
            {
                obj3.Top = tinggi1;
                obj3.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj4")
            {
                obj4.Top = tinggi1;
                obj4.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj5")
            {
                obj5.Top = tinggi1;
                obj5.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj6")
            {
                obj6.Top = tinggi1;
                obj6.Left += listKecepatan[3];
            }
            else if (listObs[3] == "obj7")
            {
                obj7.Top = tinggi1;
                obj7.Left -= listKecepatan[3];
            }
            else if (listObs[3] == "obj8")
            {
                obj8.Top = tinggi1;
                obj8.Left += listKecepatan[3];
            }

            //reset posisi obstacle
            if (obj1.Left < -200)
                obj1.Left = 800;
            if (obj2.Left > 900)
                obj2.Left = -110;
            if (obj3.Left < -200)
                obj3.Left = 800;
            if (obj4.Left > 900)
                obj4.Left = -110;
            if (obj5.Left < -200)
                obj5.Left = 800;
            if (obj6.Left > 900)
                obj6.Left = -110;
            if (obj7.Left < -200)
                obj7.Left = 800;
            if (obj8.Left > 900)
                obj8.Left = -110;

            Player.Top += vertikal;
            Player.Left += horizontal;
            vertikal = 0;
            horizontal = 0;
            level.Text = "Level : " + hitunglevel;
        }

        //text box game over
        private void gameover()
        {
            boxgameover.Left = 129; //posisi text box game over
            skorakhir.Text = "Score = " + hitungSkor;
            skorakhir.Left = 188; //posisi score akhir
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
