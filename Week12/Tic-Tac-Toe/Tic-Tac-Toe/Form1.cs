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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            txtResult.Text = "";
            Random rand = new Random();
            String[,] arr = new String[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num = rand.Next(0, 2);
                    arr[i, j] = "X";
                    if (num == 0)
                    {
                        arr[i, j] = "O";
                    }

                }
            }

            lbl1.Text = arr[0, 0];
            lbl2.Text = arr[0, 1];
            lbl3.Text = arr[0, 2];
            lbl4.Text = arr[1, 0];
            lbl5.Text = arr[1, 1];
            lbl6.Text = arr[1, 2];
            lbl7.Text = arr[2, 0];
            lbl8.Text = arr[2, 1];
            lbl9.Text = arr[2, 2];

            txtResult.Text = "Tie!";

            if ((arr[0, 0] == "X" && arr[0, 1] == "X" && arr[0, 2] == "X")
                || (arr[0, 0] == "X" && arr[1, 0] == "X" && arr[2, 0] == "X")
                || (arr[0, 0] == "X" && arr[1, 1] == "X" && arr[2, 2] == "X")
                )
            {
                txtResult.Text = "X Wins!";
            }
            else if ((arr[0, 0] == "O" && arr[0, 1] == "O" && arr[0, 2] == "O")
               || (arr[0, 0] == "O" && arr[1, 0] == "O" && arr[2, 0] == "O")
               || (arr[0, 0] == "O" && arr[1, 1] == "O" && arr[2, 2] == "O")
               )
            {
                txtResult.Text = "O Wins!";
            }

            if ((arr[2, 2] == "X" && arr[1, 2] == "X" && arr[0, 2] == "X")
                || (arr[2, 2] == "X" && arr[2, 0] == "X" && arr[2, 1] == "X")
                )
            {
                txtResult.Text = "X Wins!";
            }
            else if ((arr[2, 2] == "O" && arr[1, 2] == "O" && arr[0, 2] == "O")
               || (arr[2, 2] == "O" && arr[2, 0] == "O" && arr[2, 1] == "O")
               )
            {
                txtResult.Text = "O Wins!";
            }

            if ((arr[0, 1] == "X" && arr[1, 1] == "X" && arr[2, 1] == "X")
                || (arr[1, 0] == "X" && arr[1, 1] == "X" && arr[1, 2] == "X")
                )
            {
                txtResult.Text = "X Wins!";
            }
            else if ((arr[0, 1] == "O" && arr[1, 1] == "O" && arr[2, 1] == "O")
               || (arr[1, 0] == "O" && arr[1, 1] == "O" && arr[1, 2] == "O")
               )
            {
                txtResult.Text = "O Wins!";
            }
        }
    }
}
