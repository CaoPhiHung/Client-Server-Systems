namespace Product_Lookup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label units_On_HandLabel;
            System.Windows.Forms.Label priceLabel;
            this.productNumberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productDBDataSet = new Product_Lookup.ProductDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Product_Lookup.ProductDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Product_Lookup.ProductDBDataSetTableAdapters.TableAdapterManager();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.units_On_HandTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            units_On_HandLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNumberListBox
            // 
            this.productNumberListBox.DataSource = this.tableBindingSource;
            this.productNumberListBox.DisplayMember = "Product_Number";
            this.productNumberListBox.FormattingEnabled = true;
            this.productNumberListBox.Location = new System.Drawing.Point(25, 62);
            this.productNumberListBox.Name = "productNumberListBox";
            this.productNumberListBox.Size = new System.Drawing.Size(120, 95);
            this.productNumberListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Product Number";
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.productDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Product_Lookup.ProductDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(176, 64);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(245, 61);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // units_On_HandLabel
            // 
            units_On_HandLabel.AutoSize = true;
            units_On_HandLabel.Location = new System.Drawing.Point(159, 90);
            units_On_HandLabel.Name = "units_On_HandLabel";
            units_On_HandLabel.Size = new System.Drawing.Size(80, 13);
            units_On_HandLabel.TabIndex = 4;
            units_On_HandLabel.Text = "Units On Hand:";
            // 
            // units_On_HandTextBox
            // 
            this.units_On_HandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Units_On_Hand", true));
            this.units_On_HandTextBox.Location = new System.Drawing.Point(245, 87);
            this.units_On_HandTextBox.Name = "units_On_HandTextBox";
            this.units_On_HandTextBox.Size = new System.Drawing.Size(100, 20);
            this.units_On_HandTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(205, 116);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(245, 113);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 177);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(units_On_HandLabel);
            this.Controls.Add(this.units_On_HandTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNumberListBox);
            this.Name = "Form1";
            this.Text = "Product Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productNumberListBox;
        private System.Windows.Forms.Label label1;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ProductDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ProductDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox units_On_HandTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

