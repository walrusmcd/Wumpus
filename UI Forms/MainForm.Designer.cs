namespace Wumpus.WinFormsApp
{
    partial class MainForm
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
            this.door4 = new System.Windows.Forms.PictureBox();
            this.door3 = new System.Windows.Forms.PictureBox();
            this.door2 = new System.Windows.Forms.PictureBox();
            this.door1 = new System.Windows.Forms.PictureBox();
            this.door0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.door5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.turnCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goldCoinLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arrowCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.door4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // door4
            // 
            this.door4.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door4.Location = new System.Drawing.Point(162, 452);
            this.door4.Name = "door4";
            this.door4.Size = new System.Drawing.Size(283, 177);
            this.door4.TabIndex = 6;
            this.door4.TabStop = false;
            this.door4.Click += new System.EventHandler(this.door4_Click);
            // 
            // door3
            // 
            this.door3.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3.Location = new System.Drawing.Point(430, 565);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(283, 177);
            this.door3.TabIndex = 5;
            this.door3.TabStop = false;
            this.door3.Click += new System.EventHandler(this.door3_Click);
            // 
            // door2
            // 
            this.door2.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2.Location = new System.Drawing.Point(704, 452);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(283, 177);
            this.door2.TabIndex = 4;
            this.door2.TabStop = false;
            this.door2.Click += new System.EventHandler(this.door2_Click);
            // 
            // door1
            // 
            this.door1.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1.Location = new System.Drawing.Point(704, 218);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(283, 177);
            this.door1.TabIndex = 3;
            this.door1.TabStop = false;
            this.door1.Click += new System.EventHandler(this.door1_Click);
            // 
            // door0
            // 
            this.door0.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door0.Location = new System.Drawing.Point(430, 93);
            this.door0.Name = "door0";
            this.door0.Size = new System.Drawing.Size(283, 177);
            this.door0.TabIndex = 2;
            this.door0.TabStop = false;
            this.door0.Click += new System.EventHandler(this.door0_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.darkRoom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(430, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // door5
            // 
            this.door5.BackgroundImage = global::Wumpus.WinFormsApp.Properties.Resources.lightRoom;
            this.door5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door5.Location = new System.Drawing.Point(162, 218);
            this.door5.Name = "door5";
            this.door5.Size = new System.Drawing.Size(283, 177);
            this.door5.TabIndex = 1;
            this.door5.TabStop = false;
            this.door5.Click += new System.EventHandler(this.door5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arrowCountLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.goldCoinLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.turnCountLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.roomNumberLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(789, 795);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room number:";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(191, 36);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(51, 20);
            this.roomNumberLabel.TabIndex = 1;
            this.roomNumberLabel.Text = "label2";
            // 
            // turnCountLabel
            // 
            this.turnCountLabel.AutoSize = true;
            this.turnCountLabel.Location = new System.Drawing.Point(191, 56);
            this.turnCountLabel.Name = "turnCountLabel";
            this.turnCountLabel.Size = new System.Drawing.Size(51, 20);
            this.turnCountLabel.TabIndex = 3;
            this.turnCountLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turn count:";
            // 
            // goldCoinLabel
            // 
            this.goldCoinLabel.AutoSize = true;
            this.goldCoinLabel.Location = new System.Drawing.Point(191, 76);
            this.goldCoinLabel.Name = "goldCoinLabel";
            this.goldCoinLabel.Size = new System.Drawing.Size(51, 20);
            this.goldCoinLabel.TabIndex = 5;
            this.goldCoinLabel.Text = "label4";
            this.goldCoinLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gold coins:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // arrowCountLabel
            // 
            this.arrowCountLabel.AutoSize = true;
            this.arrowCountLabel.Location = new System.Drawing.Point(191, 96);
            this.arrowCountLabel.Name = "arrowCountLabel";
            this.arrowCountLabel.Size = new System.Drawing.Size(51, 20);
            this.arrowCountLabel.TabIndex = 7;
            this.arrowCountLabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Arrow count:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1178, 1144);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.door4);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.door0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.door5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox door5;
        private System.Windows.Forms.PictureBox door0;
        private System.Windows.Forms.PictureBox door1;
        private System.Windows.Forms.PictureBox door2;
        private System.Windows.Forms.PictureBox door3;
        private System.Windows.Forms.PictureBox door4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goldCoinLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label turnCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arrowCountLabel;
        private System.Windows.Forms.Label label7;
    }
}