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
        bool check_value(Button btn1,Button btn2, Button btn3,string mark)
        {
            if (btn1.Text!="" && btn1.Text==btn2.Text && btn1.Text==btn3.Text)
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
                return true;
            }
            else
            {
                return false;
            }
        }
        void check_win(string mark)
        {
            if (check_value(button1,button2,button3,mark))
            {
                return; 
                    
            }
            if (check_value(button4, button5, button6, mark))
            {
                return;
            }
            if (check_value(button7, button8, button9, mark))
            {
                return;
            }
            if (check_value(button1, button4, button7, mark))
            {
                return;
            }
            if (check_value(button2, button5, button8, mark))
            {
                return;
            }
            if (check_value(button3, button6, button9, mark))
            {
                return;
            }
            if (check_value(button1, button5, button9, mark))
            {
                return;
            }
            if (check_value(button3, button5, button7, mark))
            {
                return;
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
