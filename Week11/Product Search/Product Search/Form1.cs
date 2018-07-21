using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Search
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.SearchDesc(this.productDBDataSet.Table, searchTextBox.Text);
        }

        private void showAllItemButton_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.productDBDataSet.Table);
        }
    }
}
