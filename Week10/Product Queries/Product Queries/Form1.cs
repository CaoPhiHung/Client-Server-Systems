using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Queries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.productDBDataSet.Table);

        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByPrice(this.productDBDataSet.Table);
        }

        private void unitsGreaterThan100Button_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByUnits(this.productDBDataSet.Table);
        }
    }
}
