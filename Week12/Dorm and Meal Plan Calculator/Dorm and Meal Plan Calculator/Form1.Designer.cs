namespace Dorm_and_Meal_Plan_Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAllen = new System.Windows.Forms.RadioButton();
            this.radPike = new System.Windows.Forms.RadioButton();
            this.radFarthing = new System.Windows.Forms.RadioButton();
            this.radUni = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rad14 = new System.Windows.Forms.RadioButton();
            this.rad7 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUni);
            this.groupBox1.Controls.Add(this.radFarthing);
            this.groupBox1.Controls.Add(this.radPike);
            this.groupBox1.Controls.Add(this.radAllen);
            this.groupBox1.Location = new System.Drawing.Point(50, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormitories";
            // 
            // radAllen
            // 
            this.radAllen.AutoSize = true;
            this.radAllen.Location = new System.Drawing.Point(6, 28);
            this.radAllen.Name = "radAllen";
            this.radAllen.Size = new System.Drawing.Size(69, 17);
            this.radAllen.TabIndex = 1;
            this.radAllen.TabStop = true;
            this.radAllen.Text = "Allen Hall";
            this.radAllen.UseVisualStyleBackColor = true;
            // 
            // radPike
            // 
            this.radPike.AutoSize = true;
            this.radPike.Location = new System.Drawing.Point(6, 51);
            this.radPike.Name = "radPike";
            this.radPike.Size = new System.Drawing.Size(67, 17);
            this.radPike.TabIndex = 2;
            this.radPike.TabStop = true;
            this.radPike.Text = "Pike Hall";
            this.radPike.UseVisualStyleBackColor = true;
            // 
            // radFarthing
            // 
            this.radFarthing.AutoSize = true;
            this.radFarthing.Location = new System.Drawing.Point(6, 74);
            this.radFarthing.Name = "radFarthing";
            this.radFarthing.Size = new System.Drawing.Size(84, 17);
            this.radFarthing.TabIndex = 3;
            this.radFarthing.TabStop = true;
            this.radFarthing.Text = "Farthing Hall";
            this.radFarthing.UseVisualStyleBackColor = true;
            // 
            // radUni
            // 
            this.radUni.AutoSize = true;
            this.radUni.Location = new System.Drawing.Point(6, 97);
            this.radUni.Name = "radUni";
            this.radUni.Size = new System.Drawing.Size(103, 17);
            this.radUni.TabIndex = 4;
            this.radUni.TabStop = true;
            this.radUni.Text = "University Suites";
            this.radUni.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rad14);
            this.groupBox2.Controls.Add(this.rad7);
            this.groupBox2.Location = new System.Drawing.Point(282, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meals per week";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Unlimited";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rad14
            // 
            this.rad14.AutoSize = true;
            this.rad14.Location = new System.Drawing.Point(6, 51);
            this.rad14.Name = "rad14";
            this.rad14.Size = new System.Drawing.Size(37, 17);
            this.rad14.TabIndex = 2;
            this.rad14.TabStop = true;
            this.rad14.Text = "14";
            this.rad14.UseVisualStyleBackColor = true;
            // 
            // rad7
            // 
            this.rad7.AutoSize = true;
            this.rad7.Location = new System.Drawing.Point(6, 28);
            this.rad7.Name = "rad7";
            this.rad7.Size = new System.Drawing.Size(31, 17);
            this.rad7.TabIndex = 1;
            this.rad7.TabStop = true;
            this.rad7.Text = "7";
            this.rad7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Dorm and Meal Plan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dorm and Meal Plan Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUni;
        private System.Windows.Forms.RadioButton radFarthing;
        private System.Windows.Forms.RadioButton radPike;
        private System.Windows.Forms.RadioButton radAllen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rad14;
        private System.Windows.Forms.RadioButton rad7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

