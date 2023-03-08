using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            labPlayer.Text = "Player 1";
        }
        void Play(Button Btn)
        {
            if (Btn.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    Btn.Text = "X";
                    labPlayer.Text = "Player 2";
                    check_win("X");
                }
                else
                {
                    Btn.Text = "O";
                    labPlayer.Text = "Player 1";
                    check_win("O");
                }
            }
        }
        void check_win(string mark)
        {
            if (button1.Text==mark && button2.Text==mark && button3.Text==mark)
            {
                if (mark=="X")
                {
                    MessageBox.Show("Player 1 wins","Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
                    
            }
            else if (button4.Text == mark && button5.Text == mark && button6.Text == mark)
            {
                if (mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button7.Text == mark && button8.Text == mark && button9.Text == mark)
            {
                if(mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button1.Text == mark && button4.Text == mark && button7.Text == mark)
            {
                if (mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button2.Text == mark && button5.Text == mark && button8.Text == mark)
            {
                if(mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button3.Text == mark && button6.Text == mark && button9.Text == mark)
            {
                if (mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button1.Text == mark && button5.Text == mark && button9.Text == mark)
            {
                if (mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
            else if (button3.Text == mark && button5.Text == mark && button7.Text == mark)
            {
                if (mark == "X")
                {
                    MessageBox.Show("Player 1 wins", "Info");
                }
                else
                {
                    MessageBox.Show("Player 2 wins", "Info");
                }
                reset();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play(button1);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Play(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Play(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Play(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Play(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Play(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Play(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Play(button9);
        }
    }
}
