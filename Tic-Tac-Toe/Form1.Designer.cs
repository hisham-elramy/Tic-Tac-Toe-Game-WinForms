namespace Tic_Tac_Toe_Game___Updated__
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.gbFameInfo = new System.Windows.Forms.GroupBox();
            this.lblTitleWinner = new System.Windows.Forms.Label();
            this.lblPlayerWinner = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblTitleTurn = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbFameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.White;
            this.lblGameTitle.Location = new System.Drawing.Point(657, 47);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(428, 65);
            this.lblGameTitle.TabIndex = 1;
            this.lblGameTitle.Text = "Tic-Tac-Toe Game";
            // 
            // gbFameInfo
            // 
            this.gbFameInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbFameInfo.Controls.Add(this.lblTitleWinner);
            this.gbFameInfo.Controls.Add(this.lblPlayerWinner);
            this.gbFameInfo.Controls.Add(this.lblPlayerTurn);
            this.gbFameInfo.Controls.Add(this.lblTitleTurn);
            this.gbFameInfo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFameInfo.ForeColor = System.Drawing.Color.Yellow;
            this.gbFameInfo.Location = new System.Drawing.Point(26, 99);
            this.gbFameInfo.Name = "gbFameInfo";
            this.gbFameInfo.Size = new System.Drawing.Size(327, 308);
            this.gbFameInfo.TabIndex = 15;
            this.gbFameInfo.TabStop = false;
            this.gbFameInfo.Text = "Gmae Info";
            // 
            // lblTitleWinner
            // 
            this.lblTitleWinner.AutoSize = true;
            this.lblTitleWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleWinner.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitleWinner.Location = new System.Drawing.Point(82, 184);
            this.lblTitleWinner.Name = "lblTitleWinner";
            this.lblTitleWinner.Size = new System.Drawing.Size(138, 47);
            this.lblTitleWinner.TabIndex = 11;
            this.lblTitleWinner.Text = "Winner";
            // 
            // lblPlayerWinner
            // 
            this.lblPlayerWinner.AutoSize = true;
            this.lblPlayerWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWinner.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayerWinner.Location = new System.Drawing.Point(82, 231);
            this.lblPlayerWinner.Name = "lblPlayerWinner";
            this.lblPlayerWinner.Size = new System.Drawing.Size(200, 47);
            this.lblPlayerWinner.TabIndex = 10;
            this.lblPlayerWinner.Text = "In Progress";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTurn.Location = new System.Drawing.Point(59, 84);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(204, 47);
            this.lblPlayerTurn.TabIndex = 9;
            this.lblPlayerTurn.Text = "Player Turn";
            // 
            // lblTitleTurn
            // 
            this.lblTitleTurn.AutoSize = true;
            this.lblTitleTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTurn.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitleTurn.Location = new System.Drawing.Point(110, 37);
            this.lblTitleTurn.Name = "lblTitleTurn";
            this.lblTitleTurn.Size = new System.Drawing.Size(97, 47);
            this.lblTitleTurn.TabIndex = 8;
            this.lblTitleTurn.Text = "Turn";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(61, 440);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(258, 62);
            this.btnRestartGame.TabIndex = 16;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.Theme_Logo___Tic_Tac_Toe_Game;
            this.pictureBox1.Location = new System.Drawing.Point(61, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button9.Location = new System.Drawing.Point(984, 449);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 105);
            this.button9.TabIndex = 14;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button8.Location = new System.Drawing.Point(819, 449);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 105);
            this.button8.TabIndex = 14;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button7.Location = new System.Drawing.Point(654, 449);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 105);
            this.button7.TabIndex = 13;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button6.Location = new System.Drawing.Point(984, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 105);
            this.button6.TabIndex = 12;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button5.Location = new System.Drawing.Point(819, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 105);
            this.button5.TabIndex = 12;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button4.Location = new System.Drawing.Point(654, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 105);
            this.button4.TabIndex = 11;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button3.Location = new System.Drawing.Point(984, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 105);
            this.button3.TabIndex = 10;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button2.Location = new System.Drawing.Point(819, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 105);
            this.button2.TabIndex = 9;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.QuestionMark;
            this.button1.Location = new System.Drawing.Point(654, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 105);
            this.button1.TabIndex = 8;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.LightOnLogo;
            this.pictureBox2.Location = new System.Drawing.Point(258, 517);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Tic_Tac_Toe_Game___Updated__.Properties.Resources.Theme_01;
            this.ClientSize = new System.Drawing.Size(1250, 623);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.gbFameInfo);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "Form1";
            this.Tag = "LightMood";
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.gbFameInfo.ResumeLayout(false);
            this.gbFameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox gbFameInfo;
        private System.Windows.Forms.Label lblTitleWinner;
        private System.Windows.Forms.Label lblPlayerWinner;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblTitleTurn;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

