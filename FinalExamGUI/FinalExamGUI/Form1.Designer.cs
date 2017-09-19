namespace FinalExamGUI
{
    partial class MenuForm
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
            this.MenuForm_groupBox = new System.Windows.Forms.GroupBox();
            this.MenuForm_radioButton_Quotient = new System.Windows.Forms.RadioButton();
            this.MenuForm_radioButton_Squared = new System.Windows.Forms.RadioButton();
            this.MenuForm_radioButton_Product = new System.Windows.Forms.RadioButton();
            this.MenuForm_radioButton_Cubed = new System.Windows.Forms.RadioButton();
            this.MenuForm_radioButton_Difference = new System.Windows.Forms.RadioButton();
            this.MenuForm_radioButton_Sum = new System.Windows.Forms.RadioButton();
            this.MenuForm_exitbutton = new System.Windows.Forms.Button();
            this.MenuForm_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuForm_groupBox
            // 
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Quotient);
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Squared);
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Product);
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Cubed);
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Difference);
            this.MenuForm_groupBox.Controls.Add(this.MenuForm_radioButton_Sum);
            this.MenuForm_groupBox.Location = new System.Drawing.Point(45, 47);
            this.MenuForm_groupBox.Name = "MenuForm_groupBox";
            this.MenuForm_groupBox.Size = new System.Drawing.Size(171, 212);
            this.MenuForm_groupBox.TabIndex = 7;
            this.MenuForm_groupBox.TabStop = false;
            this.MenuForm_groupBox.Text = "Select a Task";
            // 
            // MenuForm_radioButton_Quotient
            // 
            this.MenuForm_radioButton_Quotient.AutoSize = true;
            this.MenuForm_radioButton_Quotient.Location = new System.Drawing.Point(6, 185);
            this.MenuForm_radioButton_Quotient.Name = "MenuForm_radioButton_Quotient";
            this.MenuForm_radioButton_Quotient.Size = new System.Drawing.Size(112, 17);
            this.MenuForm_radioButton_Quotient.TabIndex = 5;
            this.MenuForm_radioButton_Quotient.Text = "Calculate Quotient";
            this.MenuForm_radioButton_Quotient.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Quotient.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Quotient_CheckedChanged);
            // 
            // MenuForm_radioButton_Squared
            // 
            this.MenuForm_radioButton_Squared.AutoSize = true;
            this.MenuForm_radioButton_Squared.Location = new System.Drawing.Point(6, 19);
            this.MenuForm_radioButton_Squared.Name = "MenuForm_radioButton_Squared";
            this.MenuForm_radioButton_Squared.Size = new System.Drawing.Size(112, 17);
            this.MenuForm_radioButton_Squared.TabIndex = 0;
            this.MenuForm_radioButton_Squared.Text = "Calculate Squared";
            this.MenuForm_radioButton_Squared.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Squared.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Squared_CheckedChanged);
            // 
            // MenuForm_radioButton_Product
            // 
            this.MenuForm_radioButton_Product.AutoSize = true;
            this.MenuForm_radioButton_Product.Location = new System.Drawing.Point(6, 152);
            this.MenuForm_radioButton_Product.Name = "MenuForm_radioButton_Product";
            this.MenuForm_radioButton_Product.Size = new System.Drawing.Size(109, 17);
            this.MenuForm_radioButton_Product.TabIndex = 4;
            this.MenuForm_radioButton_Product.Text = "Calculate Product";
            this.MenuForm_radioButton_Product.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Product.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Product_CheckedChanged);
            // 
            // MenuForm_radioButton_Cubed
            // 
            this.MenuForm_radioButton_Cubed.AutoSize = true;
            this.MenuForm_radioButton_Cubed.Location = new System.Drawing.Point(6, 51);
            this.MenuForm_radioButton_Cubed.Name = "MenuForm_radioButton_Cubed";
            this.MenuForm_radioButton_Cubed.Size = new System.Drawing.Size(103, 17);
            this.MenuForm_radioButton_Cubed.TabIndex = 1;
            this.MenuForm_radioButton_Cubed.Text = "Calculate Cubed";
            this.MenuForm_radioButton_Cubed.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Cubed.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Cubed_CheckedChanged);
            // 
            // MenuForm_radioButton_Difference
            // 
            this.MenuForm_radioButton_Difference.AutoSize = true;
            this.MenuForm_radioButton_Difference.Location = new System.Drawing.Point(6, 118);
            this.MenuForm_radioButton_Difference.Name = "MenuForm_radioButton_Difference";
            this.MenuForm_radioButton_Difference.Size = new System.Drawing.Size(121, 17);
            this.MenuForm_radioButton_Difference.TabIndex = 3;
            this.MenuForm_radioButton_Difference.Text = "Calculate Difference";
            this.MenuForm_radioButton_Difference.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Difference.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Difference_CheckedChanged);
            // 
            // MenuForm_radioButton_Sum
            // 
            this.MenuForm_radioButton_Sum.AutoSize = true;
            this.MenuForm_radioButton_Sum.Location = new System.Drawing.Point(6, 83);
            this.MenuForm_radioButton_Sum.Name = "MenuForm_radioButton_Sum";
            this.MenuForm_radioButton_Sum.Size = new System.Drawing.Size(93, 17);
            this.MenuForm_radioButton_Sum.TabIndex = 2;
            this.MenuForm_radioButton_Sum.Text = "Calculate Sum";
            this.MenuForm_radioButton_Sum.UseVisualStyleBackColor = true;
            this.MenuForm_radioButton_Sum.CheckedChanged += new System.EventHandler(this.MenuForm_radioButton_Sum_CheckedChanged);
            // 
            // MenuForm_exitbutton
            // 
            this.MenuForm_exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MenuForm_exitbutton.Location = new System.Drawing.Point(45, 265);
            this.MenuForm_exitbutton.Name = "MenuForm_exitbutton";
            this.MenuForm_exitbutton.Size = new System.Drawing.Size(171, 33);
            this.MenuForm_exitbutton.TabIndex = 6;
            this.MenuForm_exitbutton.Text = "&Exit Application";
            this.MenuForm_exitbutton.UseVisualStyleBackColor = true;
            this.MenuForm_exitbutton.Click += new System.EventHandler(this.MenuForm_exitbutton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.MenuForm_exitbutton;
            this.ClientSize = new System.Drawing.Size(282, 329);
            this.Controls.Add(this.MenuForm_exitbutton);
            this.Controls.Add(this.MenuForm_groupBox);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Exam Menu";
            this.MenuForm_groupBox.ResumeLayout(false);
            this.MenuForm_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuForm_groupBox;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Quotient;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Squared;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Product;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Cubed;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Difference;
        private System.Windows.Forms.RadioButton MenuForm_radioButton_Sum;
        private System.Windows.Forms.Button MenuForm_exitbutton;
    }
}

