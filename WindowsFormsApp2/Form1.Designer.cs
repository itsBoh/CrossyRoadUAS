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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.obj1 = new System.Windows.Forms.PictureBox();
            this.nyawalive = new System.Windows.Forms.PictureBox();
            this.tulisannyawa = new System.Windows.Forms.MaskedTextBox();
            this.obj2 = new System.Windows.Forms.PictureBox();
            this.obj3 = new System.Windows.Forms.PictureBox();
            this.obj4 = new System.Windows.Forms.PictureBox();
            this.level = new System.Windows.Forms.TextBox();
            this.obj5 = new System.Windows.Forms.PictureBox();
            this.obj6 = new System.Windows.Forms.PictureBox();
            this.obj7 = new System.Windows.Forms.PictureBox();
            this.obj8 = new System.Windows.Forms.PictureBox();
            this.objtes = new System.Windows.Forms.PictureBox();
            this.nyawahitam = new System.Windows.Forms.PictureBox();
            this.boxgameover = new System.Windows.Forms.PictureBox();
            this.skorakhir = new System.Windows.Forms.TextBox();
            this.skor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawahitam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxgameover)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(359, 462);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(80, 81);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 50;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // obj1
            // 
            this.obj1.BackColor = System.Drawing.Color.Transparent;
            this.obj1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj1.BackgroundImage")));
            this.obj1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj1.Location = new System.Drawing.Point(820, 700);
            this.obj1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obj1.Name = "obj1";
            this.obj1.Size = new System.Drawing.Size(167, 71);
            this.obj1.TabIndex = 6;
            this.obj1.TabStop = false;
            // 
            // nyawalive
            // 
            this.nyawalive.BackColor = System.Drawing.Color.Transparent;
            this.nyawalive.Image = ((System.Drawing.Image)(resources.GetObject("nyawalive.Image")));
            this.nyawalive.Location = new System.Drawing.Point(612, 1);
            this.nyawalive.Margin = new System.Windows.Forms.Padding(0);
            this.nyawalive.Name = "nyawalive";
            this.nyawalive.Size = new System.Drawing.Size(180, 34);
            this.nyawalive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nyawalive.TabIndex = 9;
            this.nyawalive.TabStop = false;
            // 
            // tulisannyawa
            // 
            this.tulisannyawa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tulisannyawa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tulisannyawa.Enabled = false;
            this.tulisannyawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulisannyawa.Location = new System.Drawing.Point(493, 0);
            this.tulisannyawa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tulisannyawa.Name = "tulisannyawa";
            this.tulisannyawa.Size = new System.Drawing.Size(121, 31);
            this.tulisannyawa.TabIndex = 10;
            // 
            // obj2
            // 
            this.obj2.BackColor = System.Drawing.Color.Transparent;
            this.obj2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj2.BackgroundImage")));
            this.obj2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj2.Image = ((System.Drawing.Image)(resources.GetObject("obj2.Image")));
            this.obj2.Location = new System.Drawing.Point(-109, 700);
            this.obj2.Margin = new System.Windows.Forms.Padding(0);
            this.obj2.Name = "obj2";
            this.obj2.Size = new System.Drawing.Size(167, 71);
            this.obj2.TabIndex = 11;
            this.obj2.TabStop = false;
            // 
            // obj3
            // 
            this.obj3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obj3.BackColor = System.Drawing.Color.Transparent;
            this.obj3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj3.BackgroundImage")));
            this.obj3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj3.Location = new System.Drawing.Point(900, 700);
            this.obj3.Margin = new System.Windows.Forms.Padding(0);
            this.obj3.Name = "obj3";
            this.obj3.Size = new System.Drawing.Size(144, 68);
            this.obj3.TabIndex = 12;
            this.obj3.TabStop = false;
            // 
            // obj4
            // 
            this.obj4.BackColor = System.Drawing.Color.Transparent;
            this.obj4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj4.BackgroundImage")));
            this.obj4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj4.Location = new System.Drawing.Point(-109, 700);
            this.obj4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obj4.Name = "obj4";
            this.obj4.Size = new System.Drawing.Size(144, 68);
            this.obj4.TabIndex = 13;
            this.obj4.TabStop = false;
            // 
            // level
            // 
            this.level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.level.Enabled = false;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(263, 0);
            this.level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(208, 27);
            this.level.TabIndex = 14;
            // 
            // obj5
            // 
            this.obj5.BackColor = System.Drawing.Color.Transparent;
            this.obj5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj5.BackgroundImage")));
            this.obj5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj5.Location = new System.Drawing.Point(820, 700);
            this.obj5.Margin = new System.Windows.Forms.Padding(0);
            this.obj5.Name = "obj5";
            this.obj5.Size = new System.Drawing.Size(181, 76);
            this.obj5.TabIndex = 15;
            this.obj5.TabStop = false;
            // 
            // obj6
            // 
            this.obj6.BackColor = System.Drawing.Color.Transparent;
            this.obj6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj6.BackgroundImage")));
            this.obj6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj6.Location = new System.Drawing.Point(-109, 700);
            this.obj6.Margin = new System.Windows.Forms.Padding(0);
            this.obj6.Name = "obj6";
            this.obj6.Size = new System.Drawing.Size(181, 76);
            this.obj6.TabIndex = 16;
            this.obj6.TabStop = false;
            // 
            // obj7
            // 
            this.obj7.BackColor = System.Drawing.Color.Transparent;
            this.obj7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj7.BackgroundImage")));
            this.obj7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj7.Location = new System.Drawing.Point(820, 700);
            this.obj7.Margin = new System.Windows.Forms.Padding(0);
            this.obj7.Name = "obj7";
            this.obj7.Size = new System.Drawing.Size(208, 75);
            this.obj7.TabIndex = 17;
            this.obj7.TabStop = false;
            // 
            // obj8
            // 
            this.obj8.BackColor = System.Drawing.Color.Transparent;
            this.obj8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obj8.BackgroundImage")));
            this.obj8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obj8.Location = new System.Drawing.Point(-109, 700);
            this.obj8.Margin = new System.Windows.Forms.Padding(0);
            this.obj8.Name = "obj8";
            this.obj8.Size = new System.Drawing.Size(208, 75);
            this.obj8.TabIndex = 18;
            this.obj8.TabStop = false;
            // 
            // objtes
            // 
            this.objtes.BackColor = System.Drawing.SystemColors.Control;
            this.objtes.Location = new System.Drawing.Point(347, 700);
            this.objtes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objtes.Name = "objtes";
            this.objtes.Size = new System.Drawing.Size(91, 60);
            this.objtes.TabIndex = 20;
            this.objtes.TabStop = false;
            // 
            // nyawahitam
            // 
            this.nyawahitam.BackColor = System.Drawing.Color.Transparent;
            this.nyawahitam.Image = ((System.Drawing.Image)(resources.GetObject("nyawahitam.Image")));
            this.nyawahitam.Location = new System.Drawing.Point(612, 1);
            this.nyawahitam.Margin = new System.Windows.Forms.Padding(0);
            this.nyawahitam.Name = "nyawahitam";
            this.nyawahitam.Size = new System.Drawing.Size(180, 34);
            this.nyawahitam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nyawahitam.TabIndex = 21;
            this.nyawahitam.TabStop = false;
            // 
            // boxgameover
            // 
            this.boxgameover.Enabled = false;
            this.boxgameover.Location = new System.Drawing.Point(1200, 151);
            this.boxgameover.Margin = new System.Windows.Forms.Padding(0);
            this.boxgameover.Name = "boxgameover";
            this.boxgameover.Size = new System.Drawing.Size(467, 308);
            this.boxgameover.TabIndex = 22;
            this.boxgameover.TabStop = false;
            // 
            // skorakhir
            // 
            this.skorakhir.Enabled = false;
            this.skorakhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorakhir.Location = new System.Drawing.Point(933, 172);
            this.skorakhir.Margin = new System.Windows.Forms.Padding(4);
            this.skorakhir.Name = "skorakhir";
            this.skorakhir.Size = new System.Drawing.Size(296, 41);
            this.skorakhir.TabIndex = 23;
            // 
            // skor
            // 
            this.skor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skor.Enabled = false;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skor.ForeColor = System.Drawing.Color.Transparent;
            this.skor.Location = new System.Drawing.Point(0, 0);
            this.skor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(259, 31);
            this.skor.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.skorakhir);
            this.Controls.Add(this.boxgameover);
            this.Controls.Add(this.objtes);
            this.Controls.Add(this.obj8);
            this.Controls.Add(this.obj7);
            this.Controls.Add(this.obj6);
            this.Controls.Add(this.obj5);
            this.Controls.Add(this.level);
            this.Controls.Add(this.obj4);
            this.Controls.Add(this.obj3);
            this.Controls.Add(this.obj2);
            this.Controls.Add(this.tulisannyawa);
            this.Controls.Add(this.nyawalive);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.obj1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.nyawahitam);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossy Road";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownevent);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawahitam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxgameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox obj1;
        private System.Windows.Forms.PictureBox nyawalive;
        private System.Windows.Forms.MaskedTextBox tulisannyawa;
        private System.Windows.Forms.PictureBox obj2;
        private System.Windows.Forms.PictureBox obj3;
        private System.Windows.Forms.PictureBox obj4;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.PictureBox obj5;
        private System.Windows.Forms.PictureBox obj6;
        private System.Windows.Forms.PictureBox obj7;
        private System.Windows.Forms.PictureBox obj8;
        private System.Windows.Forms.PictureBox objtes;
        private System.Windows.Forms.PictureBox nyawahitam;
        private System.Windows.Forms.PictureBox boxgameover;
        private System.Windows.Forms.TextBox skorakhir;
        private System.Windows.Forms.TextBox skor;
    }
}

