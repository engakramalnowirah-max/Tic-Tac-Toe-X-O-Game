using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        stGageStatus GameStatus;

        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        struct stGageStatus
        {
           public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;

            Pen pen = new Pen(white);
            pen.Width = 8;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 50, 120, 400, 120);
            e.Graphics.DrawLine(pen, 50, 250, 400, 250);


            e.Graphics.DrawLine(pen, 150, 5, 150, 370);
            e.Graphics.DrawLine(pen, 300, 5, 300, 370);
        }


        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;

                }

            }
            GameStatus.GameOver = false;
            return false;
        }
        public void EndGame()
        {
            lblPaler.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    {
                        lblWinner.Text = "Player1";
                        break;
                    }
                case enWinner.Player2:
                    {
                        lblWinner.Text = "Player2";
                        break;
                    }
                default:
                    lblWinner.Text = "Draw";
                    break;


            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
     
        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

            if (CheckValues(button4, button5, button6))
                return;

            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;

            if (CheckValues(button2, button5, button8))
                return;

            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button1, button5, button9))
                return;

            if (CheckValues(button3, button5, button7))
                return;
        }
        private void ChangeImage(Button btn)
        {


            if (btn.Tag.ToString() == "?") 
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblPaler.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblPaler.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                    
                }
            }
            else
            {
                MessageBox.Show("wrong choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }


        }
        public void RestButton(Button Btn)
        {
            Btn.Image = Properties.Resources.question_mark_96;
            Btn.Tag = "?";
            Btn.BackColor = Color.Transparent;
        }
        public void GameRestart()
        {
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblPaler.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            
            
        }


        private void buttons_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            GameRestart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
