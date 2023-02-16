using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    
    public partial class StartForm : Form
    {
        bool check = true; // true == x,false == o
        

        public StartForm()
        {
            InitializeComponent();
        }

        private void A1button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (check == true)
                clickedButton.Text = "X";
            else
                clickedButton.Text = "O";

            clickedButton.Enabled = false;
            CheckWin();
            check = !check;
        }

        //вынести showbox в отдельную функцию
        void CheckWin()
        {
            string winner = check == true ? "X" : "O";

            //По горизонтали
            if (A1button.Text != "" && A1button.Text == A2button.Text && A1button.Text == A3button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (B1button.Text != "" && B1button.Text == B2button.Text && B1button.Text == B3button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (C1button.Text != "" && C1button.Text == C2button.Text && C1button.Text == C3button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }

            //По вертикали
            if (A1button.Text != "" && A1button.Text == B1button.Text && A1button.Text == C1button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (A2button.Text != "" && A2button.Text == B2button.Text && A2button.Text == C2button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (A3button.Text != "" && A3button.Text == B3button.Text && A3button.Text == C3button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }

            //По диагоналям
            if (A1button.Text != "" && A1button.Text == B2button.Text && A1button.Text == C3button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (A3button.Text != "" && A3button.Text == B2button.Text && A3button.Text == C1button.Text)
            {
                MessageBox.Show("Выиграл: " + winner);
                IncreaseScoreCount();
                return;
            }
            if (A1button.Enabled == false && A2button.Enabled == false && A3button.Enabled == false && B1button.Enabled == false && B2button.Enabled == false && B3button.Enabled == false && C1button.Enabled == false && C2button.Enabled == false && C3button.Enabled == false)
            {
                MessageBox.Show("Ничья!");
                IncreaseDrawScoreCount();
                return;
            }
            
        }

        private void IncreaseScoreCount()
        {
            if (check == true)
                xCountWinnerLabel.Text = (Convert.ToInt32(xCountWinnerLabel.Text) + 1).ToString();
            else
                oCountWinnerLabel.Text = (Convert.ToInt32(oCountWinnerLabel.Text) + 1).ToString();
        }

        private void IncreaseDrawScoreCount()
        {
                drawCountLabel.Text = (Convert.ToInt32(drawCountLabel.Text) + 1).ToString();
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                    button.Enabled = true;
                }
                    
            }
        }

        private void resetStaticticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCountWinnerLabel.Text = "0";
            oCountWinnerLabel.Text = "0";
            drawCountLabel.Text = "0";


        }

        private void A1button_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = (Button)sender;

            if (check == true)
                enteredButton.Text = "X";
            else
                enteredButton.Text = "O";
        }

        private void A1button_MouseLeave(object sender, EventArgs e)
        {
            Button leaveButton = (Button)sender;
            if (leaveButton.Enabled  == true)
                leaveButton.Text = "";
        }
       
    }
}
