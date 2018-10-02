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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int total = 0;
            switch (Form1.dormType)
            {
                case 1:
                    total += 1500;
                    txtDorm.Text = "Allen Hall - $1,500";
                    break;
                case 2:
                    total += 1600;
                    txtDorm.Text = "Pike Hall - $1,600";
                    break;
                case 3:
                    total += 1800;
                    txtDorm.Text = "Farthing Hall - $1,800";
                    break;
                default:
                    total += 2500;
                    txtDorm.Text = "University Suites - $2,500";
                    break;
            }

            switch (Form1.mealType)
            {
                case 1:
                    total += 600;
                    txtMeal.Text = "7 meals per week - $600";
                    break;
                case 2:
                    total += 1200;
                    txtMeal.Text = "14 meals per week - $1,200";
                    break;
                default:
                    total += 1700;
                    txtMeal.Text = "Unlimited meals - $1,700";
                    break;
            }

            txtTotal.Text = "Total charge is: $" + total;
        }
    }
}
