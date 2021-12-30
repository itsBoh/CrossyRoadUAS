namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.back = new System.Windows.Forms.PictureBox();
            this.mobil1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.skor = new System.Windows.Forms.TextBox();
            this.nyawalive = new System.Windows.Forms.PictureBox();
            this.tulisannyawa = new System.Windows.Forms.MaskedTextBox();
            this.mobil2 = new System.Windows.Forms.PictureBox();
            this.mobil3 = new System.Windows.Forms.PictureBox();
            this.mobil4 = new System.Windows.Forms.PictureBox();
            this.buatnyoba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil4)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.DimGray;
            this.Player.Location = new System.Drawing.Point(360, 450);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(80, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 50;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(0, 55);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(800, 500);
            this.back.TabIndex = 1;
            this.back.TabStop = false;
            // 
            // mobil1
            // 
            this.mobil1.Location = new System.Drawing.Point(820, 360);
            this.mobil1.Name = "mobil1";
            this.mobil1.Size = new System.Drawing.Size(90, 60);
            this.mobil1.TabIndex = 6;
            this.mobil1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 55);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // skor
            // 
            this.skor.Font = new System.Drawing.Font("8BIT WONDER", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skor.Location = new System.Drawing.Point(0, 0);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(257, 34);
            this.skor.TabIndex = 8;
            // 
            // nyawalive
            // 
            this.nyawalive.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nyawalive.Location = new System.Drawing.Point(602, 0);
            this.nyawalive.Name = "nyawalive";
            this.nyawalive.Size = new System.Drawing.Size(180, 34);
            this.nyawalive.TabIndex = 9;
            this.nyawalive.TabStop = false;
            // 
            // tulisannyawa
            // 
            this.tulisannyawa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tulisannyawa.Font = new System.Drawing.Font("8BIT WONDER", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulisannyawa.Location = new System.Drawing.Point(490, 0);
            this.tulisannyawa.Name = "tulisannyawa";
            this.tulisannyawa.Size = new System.Drawing.Size(120, 34);
            this.tulisannyawa.TabIndex = 10;
            // 
            // mobil2
            // 
            this.mobil2.Location = new System.Drawing.Point(-110, 260);
            this.mobil2.Name = "mobil2";
            this.mobil2.Size = new System.Drawing.Size(90, 60);
            this.mobil2.TabIndex = 11;
            this.mobil2.TabStop = false;
            // 
            // mobil3
            // 
            this.mobil3.Location = new System.Drawing.Point(900, 170);
            this.mobil3.Name = "mobil3";
            this.mobil3.Size = new System.Drawing.Size(90, 60);
            this.mobil3.TabIndex = 12;
            this.mobil3.TabStop = false;
            // 
            // mobil4
            // 
            this.mobil4.Location = new System.Drawing.Point(-110, 70);
            this.mobil4.Name = "mobil4";
            this.mobil4.Size = new System.Drawing.Size(90, 60);
            this.mobil4.TabIndex = 13;
            this.mobil4.TabStop = false;
            // 
            // buatnyoba
            // 
            this.buatnyoba.Location = new System.Drawing.Point(328, 14);
            this.buatnyoba.Name = "buatnyoba";
            this.buatnyoba.Size = new System.Drawing.Size(100, 22);
            this.buatnyoba.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buatnyoba);
            this.Controls.Add(this.mobil4);
            this.Controls.Add(this.mobil3);
            this.Controls.Add(this.mobil2);
            this.Controls.Add(this.tulisannyawa);
            this.Controls.Add(this.nyawalive);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mobil1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.back);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownevent);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox mobil1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox skor;
        private System.Windows.Forms.PictureBox nyawalive;
        private System.Windows.Forms.MaskedTextBox tulisannyawa;
        private System.Windows.Forms.PictureBox mobil2;
        private System.Windows.Forms.PictureBox mobil3;
        private System.Windows.Forms.PictureBox mobil4;
        private System.Windows.Forms.TextBox buatnyoba;
    }
}

