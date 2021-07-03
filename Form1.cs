using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] Board_Game = new string[9];
        int Current_Turn = 0;
        public string Return_Symbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public System.Drawing.Color BoxColor(string TicTacColor)
        {
            if (TicTacColor.Equals("O"))
            {
                return System.Drawing.Color.DeepSkyBlue;
            }
            else
            {
                return System.Drawing.Color.Red;
            }
        }
        public void TheWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String Winning_Pattern = "";
                switch (i)
                {
                    case 0:
                        Winning_Pattern = Board_Game[0] + Board_Game[1] + Board_Game[2];
                        break;
                    case 1:
                        Winning_Pattern = Board_Game[3] + Board_Game[4] + Board_Game[5];
                        break;
                    case 2:
                        Winning_Pattern = Board_Game[6] + Board_Game[7] + Board_Game[8];
                        break;
                    case 3:
                        Winning_Pattern = Board_Game[0] + Board_Game[3] + Board_Game[6];
                        break;
                    case 4:
                        Winning_Pattern = Board_Game[1] + Board_Game[4] + Board_Game[7];
                        break;
                    case 5:
                        Winning_Pattern = Board_Game[2] + Board_Game[5] + Board_Game[8];
                        break;
                    case 6:
                        Winning_Pattern = Board_Game[0] + Board_Game[4] + Board_Game[8];
                        break;
                    case 7:
                        Winning_Pattern = Board_Game[2] + Board_Game[4] + Board_Game[6];
                        break;
                }
                if (Winning_Pattern.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("O Won The Game! Yahoooo!", "Congratulations! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Winning_Pattern.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("X Won The Game! Yahoooo!", "Congratulations! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Draw_Players();
            }
        }
        public void reset()
        {
            Uno.Text = "";
            Dos.Text = "";
            Tres.Text = "";
            Quatro.Text = "";
            Cinco.Text = "";
            Seis.Text = "";
            Siete.Text = "";
            Ocho.Text = "";
            Nueve.Text = "";
            Uno.BackColor = System.Drawing.Color.White;
            Dos.BackColor = System.Drawing.Color.White;
            Tres.BackColor = System.Drawing.Color.White;
            Quatro.BackColor = System.Drawing.Color.White;
            Cinco.BackColor = System.Drawing.Color.White;
            Seis.BackColor = System.Drawing.Color.White;
            Siete.BackColor = System.Drawing.Color.White;
            Ocho.BackColor = System.Drawing.Color.White;
            Nueve.BackColor = System.Drawing.Color.White;
            Board_Game = new string[9];
            Current_Turn = 0;
        }

        public void Draw_Players()
        {
            int counter = 0;
            for (int i = 0; i < Board_Game.Length; i++)
            {
                if (Board_Game[i] != null) { counter++; }
                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("Aww! That is a Draw.", "Nah...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[0] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[0]);
            Uno.BackColor = Color_Button;
            Uno.Text = Board_Game[0];
            Uno.Enabled = false;
            TheWinner();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[1] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[1]);
            Dos.BackColor = Color_Button;
            Dos.Text = Board_Game[1];
            Dos.Enabled = false;
            TheWinner();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[2] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[2]);
            Tres.BackColor = Color_Button;
            Tres.Text = Board_Game[2];
            Tres.Enabled = false;
            TheWinner();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[3] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[3]);
            Quatro.BackColor = Color_Button;
            Quatro.Text = Board_Game[3];
            Quatro.Enabled = false;
            TheWinner();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[4] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[4]);
            Cinco.BackColor = Color_Button;
            Cinco.Text = Board_Game[4];
            Cinco.Enabled = false;
            TheWinner();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[5] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[5]);
            Seis.BackColor = Color_Button;
            Seis.Text = Board_Game[5];
            Seis.Enabled = false;
            TheWinner();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[6] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[6]);
            Siete.BackColor = Color_Button;
            Siete.Text = Board_Game[6];
            Siete.Enabled = false;
            TheWinner();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[7] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[7]);
            Ocho.BackColor = Color_Button;
            Ocho.Text = Board_Game[7];
            Ocho.Enabled = false;
            TheWinner();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[8] = Return_Symbol(Current_Turn);
            Color Color_Button = BoxColor(Board_Game[8]);
            Nueve.BackColor = Color_Button;
            Nueve.Text = Board_Game[8];
            Nueve.Enabled = false;
            TheWinner();
        }
    }
}
