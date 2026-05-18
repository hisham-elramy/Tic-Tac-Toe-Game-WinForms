using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game___Updated__.Properties;

namespace Tic_Tac_Toe_Game___Updated__
{
    public partial class Form1 : Form
    {

        enPlayer CurrentPlayer = enPlayer.Player1;

        stGameStats GameResult;


        enum enPlayer { Player1 = 1, Player2 = 2 }


        enum enWinner { Player1 = 1, Player2 = 2, Draw = 3, GameInProgress = 4 }


        struct stGameStats 
        {
            public short PlaysCount;
            public bool GameOver;
            public enWinner Winner;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);

            if (this.Tag.ToString() == "LightMood") 
            {
                Color Black = Color.Black;
                Pen = new Pen(Black);
            }

            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 793, 145, 793, 570);
            e.Graphics.DrawLine(Pen, 955, 145, 955, 570);

            e.Graphics.DrawLine(Pen, 640, 282, 1110, 282);
            e.Graphics.DrawLine(Pen, 640, 430, 1110, 430);
        }


        private void EndGame() 
        {
            lblPlayerTurn.Text = "Game Over";
            switch (GameResult.Winner)
            {

                case enWinner.Player1:

                    lblPlayerWinner.Text = "Player1";
                    MessageBox.Show("Game Over!\n" + lblPlayerWinner.Text + " Is WINNER!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case enWinner.Player2:

                    lblPlayerWinner.Text = "Player2";
                    MessageBox.Show("Game Over!\n" + lblPlayerWinner.Text + " Is WINNER!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:

                    lblPlayerWinner.Text = "Draw";
                    MessageBox.Show("Game Over!\n" + lblPlayerWinner.Text, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

            DisableButtons();

            
        }

        private bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X") 
                {
                    GameResult.Winner = enWinner.Player1;
                    GameResult.GameOver = true;
                    EndGame();
                    return true;
                }

                if (btn1.Tag.ToString() == "O") 
                {
                    GameResult.Winner = enWinner.Player2;
                    GameResult.GameOver = true;
                    EndGame();
                }

            }

            GameResult.GameOver = false;
            return false;

        }

        private void CheckWinner() 
        {
            if (CheckValue(button1, button2, button3))
                return;

            if (CheckValue(button4, button5, button6))
                return;

            if (CheckValue(button7, button8, button9))
                return;

            if (CheckValue(button1, button4, button7))
                return;

            if (CheckValue(button2, button5, button8))
                return;

            if (CheckValue(button3, button6, button9))
                return;

            if (CheckValue(button1, button5, button9))
                return;

            if (CheckValue(button3, button5, button7))
                return;
        }

        private void Check_Image(Button btn) 
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (CurrentPlayer)
                {

                    case enPlayer.Player1:
                        btn.Tag = "X";
                        btn.Image = Resources.X;
                        CurrentPlayer = enPlayer.Player2;
                        GameResult.PlaysCount++;
                        lblPlayerTurn.Text = "Player 2";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Tag = "O";
                        btn.Image = Resources.O;
                        CurrentPlayer = enPlayer.Player1;
                        GameResult.PlaysCount++;
                        lblPlayerTurn.Text = "Player 1";
                        CheckWinner();
                        break;
                }
            }

            else 
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameResult.PlaysCount == 9)
            {
                GameResult.Winner = enWinner.Draw;
                GameResult.GameOver = true;
                EndGame();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Check_Image((Button) sender);
        }
        
        private void ResetButton(Button btn) 
        {
            btn.Tag = "?";
            btn.Image = Resources.QuestionMark;
            btn.BackColor = Color.Transparent;
            btn.Enabled = true;
        }

        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void Restart() 
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblPlayerTurn.Text = "Player 1";
            lblPlayerWinner.Text = "In Progress";
            CurrentPlayer = enPlayer.Player1;
            GameResult.Winner = enWinner.GameInProgress;
            GameResult.GameOver = false;
            GameResult.PlaysCount = 0;

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Restart();
        }

        short BackGroundTag = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (BackGroundTag == 1 || this.BackgroundImage == null)
            {
                this.BackgroundImage = Resources.Theme_02;
                BackGroundTag++;
            }

            else if ((BackGroundTag == 2))
            {
                this.BackgroundImage = Resources.Theme_03;
                BackGroundTag++;
            }

            else if (BackGroundTag == 3)
            {
                this.BackgroundImage = Resources.Theme_04;
                BackGroundTag++;
            }

            else 
            {
                this.BackgroundImage = Resources.Theme_01;
                BackGroundTag = 1;
            }

        }

        private void ToDarkMood() 
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            lblGameTitle.ForeColor = Color.White;
            lblPlayerTurn.ForeColor = Color.White;
            btnRestartGame.ForeColor = Color.White;
            gbFameInfo.ForeColor = Color.Yellow;
            lblTitleTurn.ForeColor = Color.Yellow;
            lblTitleWinner.ForeColor = Color.Yellow;
            lblPlayerWinner.ForeColor = Color.Green;
        }

        private void ToLightMood() 
        {
            this.BackgroundImage = null;
            this.BackColor = Color.White;
            lblGameTitle.ForeColor = Color.Black;
            lblPlayerTurn.ForeColor = Color.Black;
            btnRestartGame.ForeColor = Color.Black;
            gbFameInfo.ForeColor = Color.DarkBlue;
            lblTitleTurn.ForeColor = Color.DarkBlue;
            lblTitleWinner.ForeColor = Color.DarkBlue;
            lblPlayerWinner.ForeColor = Color.Blue;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "LightMood")
            {
                ToDarkMood();
                this.Tag = "DarkMood";
            }
            else 
            {
                ToLightMood();
                this.Tag = "LightMood";
            }
        }
    }
}
