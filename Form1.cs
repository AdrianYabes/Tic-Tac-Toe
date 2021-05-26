﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[0] = Return_Symbol(Current_Turn);
            Uno.Text = Board_Game[0];
            TheWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[1] = Return_Symbol(Current_Turn);
            Dos.Text = Board_Game[1];
            TheWinner();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[2] = Return_Symbol(Current_Turn);
            Tres.Text = Board_Game[2];
            TheWinner();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[3] = Return_Symbol(Current_Turn);
            Quatro.Text = Board_Game[3];
            TheWinner();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[4] = Return_Symbol(Current_Turn);
            Cinco.Text = Board_Game[4];
            TheWinner();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[5] = Return_Symbol(Current_Turn);
            Seis.Text = Board_Game[5];
            TheWinner();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[6] = Return_Symbol(Current_Turn);
            Siete.Text = Board_Game[6];
            TheWinner();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[7] = Return_Symbol(Current_Turn);
            Ocho.Text = Board_Game[7];
            TheWinner();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Current_Turn++;
            Board_Game[8] = Return_Symbol(Current_Turn);
            Nueve.Text = Board_Game[8];
            TheWinner();

        }
    }
}
