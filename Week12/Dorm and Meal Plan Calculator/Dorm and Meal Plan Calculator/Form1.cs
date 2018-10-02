using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class Form1 : Form
    {
        public static int dormType;
        public static int mealType;

        public Form1()
        {
            InitializeComponent();
            radAllen.Checked = true;
            rad7.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radAllen.Checked)
            {
                dormType = 1;
            }else if (radPike.Checked)
            {
                dormType = 2;
            }
            else if (radFarthing.Checked)
            {
                dormType = 3;
            }
            else
            {
                dormType = 4;
            }

            if (rad7.Checked)
            {
                mealType = 1;
            }
            else if (rad14.Checked)
            {
                mealType = 2;
            }
            else
            {
                mealType = 3;
            }

            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
