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
            this.obj1 = new System.Windows.Forms.PictureBox();
            this.bgtop = new System.Windows.Forms.PictureBox();
            this.skor = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgtop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objtes)).BeginInit();
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
            // obj1
            // 
            this.obj1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obj1.Location = new System.Drawing.Point(820, 700);
            this.obj1.Name = "obj1";
            this.obj1.Size = new System.Drawing.Size(90, 60);
            this.obj1.TabIndex = 6;
            this.obj1.TabStop = false;
            // 
            // bgtop
            // 
            this.bgtop.BackColor = System.Drawing.Color.Red;
            this.bgtop.Location = new System.Drawing.Point(0, 0);
            this.bgtop.Name = "bgtop";
            this.bgtop.Size = new System.Drawing.Size(800, 55);
            this.bgtop.TabIndex = 7;
            this.bgtop.TabStop = false;
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
            // obj2
            // 
            this.obj2.Location = new System.Drawing.Point(-110, 700);
            this.obj2.Name = "obj2";
            this.obj2.Size = new System.Drawing.Size(90, 60);
            this.obj2.TabIndex = 11;
            this.obj2.TabStop = false;
            // 
            // obj3
            // 
            this.obj3.BackColor = System.Drawing.Color.Red;
            this.obj3.Location = new System.Drawing.Point(900, 700);
            this.obj3.Name = "obj3";
            this.obj3.Size = new System.Drawing.Size(90, 60);
            this.obj3.TabIndex = 12;
            this.obj3.TabStop = false;
            // 
            // obj4
            // 
            this.obj4.BackColor = System.Drawing.Color.DodgerBlue;
            this.obj4.Location = new System.Drawing.Point(-110, 700);
            this.obj4.Name = "obj4";
            this.obj4.Size = new System.Drawing.Size(90, 60);
            this.obj4.TabIndex = 13;
            this.obj4.TabStop = false;
            // 
            // level
            // 
            this.level.Font = new System.Drawing.Font("8BIT WONDER", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(263, 0);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(207, 34);
            this.level.TabIndex = 14;
            // 
            // obj5
            // 
            this.obj5.BackColor = System.Drawing.Color.Yellow;
            this.obj5.Location = new System.Drawing.Point(820, 700);
            this.obj5.Name = "obj5";
            this.obj5.Size = new System.Drawing.Size(90, 60);
            this.obj5.TabIndex = 15;
            this.obj5.TabStop = false;
            // 
            // obj6
            // 
            this.obj6.BackColor = System.Drawing.Color.Green;
            this.obj6.Location = new System.Drawing.Point(-110, 700);
            this.obj6.Name = "obj6";
            this.obj6.Size = new System.Drawing.Size(90, 60);
            this.obj6.TabIndex = 16;
            this.obj6.TabStop = false;
            // 
            // obj7
            // 
            this.obj7.BackColor = System.Drawing.Color.Gray;
            this.obj7.Location = new System.Drawing.Point(820, 700);
            this.obj7.Name = "obj7";
            this.obj7.Size = new System.Drawing.Size(90, 60);
            this.obj7.TabIndex = 17;
            this.obj7.TabStop = false;
            // 
            // obj8
            // 
            this.obj8.BackColor = System.Drawing.Color.DarkViolet;
            this.obj8.Location = new System.Drawing.Point(-110, 700);
            this.obj8.Name = "obj8";
            this.obj8.Size = new System.Drawing.Size(90, 60);
            this.obj8.TabIndex = 18;
            this.obj8.TabStop = false;
            // 
            // objtes
            // 
            this.objtes.BackColor = System.Drawing.SystemColors.Control;
            this.objtes.Location = new System.Drawing.Point(346, 700);
            this.objtes.Name = "objtes";
            this.objtes.Size = new System.Drawing.Size(90, 60);
            this.objtes.TabIndex = 20;
            this.objtes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
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
            this.Controls.Add(this.bgtop);
            this.Controls.Add(this.obj1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.back);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownevent);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgtop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawalive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objtes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox obj1;
        private System.Windows.Forms.PictureBox bgtop;
        private System.Windows.Forms.TextBox skor;
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
    }
}

