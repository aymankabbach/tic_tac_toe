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

        private void btnReset_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="")
            {
                if (labPlayer.Text=="Player 1")
                {
                    button1.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button1.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button2.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button2.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button3.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button3.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button4.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button4.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button5.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button5.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button6.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button6.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button7.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button7.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button8.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button8.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (labPlayer.Text == "Player 1")
                {
                    button9.Text = "X";
                    labPlayer.Text = "Player 2";
                }
                else
                {
                    button9.Text = "O";
                    labPlayer.Text = "Player 1";
                }
            }
        }
    }
}
