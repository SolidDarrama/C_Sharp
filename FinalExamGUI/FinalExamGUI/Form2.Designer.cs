namespace FinalExamGUI
{
    partial class Form2
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
            this.form2_textBox = new System.Windows.Forms.TextBox();
            this.form2_squarebutton = new System.Windows.Forms.Button();
            this.form2_closebutton = new System.Windows.Forms.Button();
            this.form2_label = new System.Windows.Forms.Label();
            this.form2_displaylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form2_textBox
            // 
            this.form2_textBox.Location = new System.Drawing.Point(162, 36);
            this.form2_textBox.Multiline = true;
            this.form2_textBox.Name = "form2_textBox";
            this.form2_textBox.Size = new System.Drawing.Size(126, 23);
            this.form2_textBox.TabIndex = 0;
            this.form2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form2_textBox.TextChanged += new System.EventHandler(this.form2_textBox_TextChanged);
            // 
            // form2_squarebutton
            // 
            this.form2_squarebutton.Location = new System.Drawing.Point(30, 129);
            this.form2_squarebutton.Name = "form2_squarebutton";
            this.form2_squarebutton.Size = new System.Drawing.Size(126, 31);
            this.form2_squarebutton.TabIndex = 1;
            this.form2_squarebutton.Text = "&Square";
            this.form2_squarebutton.UseVisualStyleBackColor = true;
            this.form2_squarebutton.Click += new System.EventHandler(this.form2_squarebutton_Click);
            // 
            // form2_closebutton
            // 
            this.form2_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form2_closebutton.Location = new System.Drawing.Point(162, 129);
            this.form2_closebutton.Name = "form2_closebutton";
            this.form2_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form2_closebutton.TabIndex = 2;
            this.form2_closebutton.Text = "&Close Form";
            this.form2_closebutton.UseVisualStyleBackColor = true;
            this.form2_closebutton.Click += new System.EventHandler(this.form2_closebutton_Click);
            // 
            // form2_label
            // 
            this.form2_label.Location = new System.Drawing.Point(27, 36);
            this.form2_label.Name = "form2_label";
            this.form2_label.Size = new System.Drawing.Size(129, 23);
            this.form2_label.TabIndex = 3;
            this.form2_label.Text = "Enter Number to Square";
            this.form2_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form2_displaylabel
            // 
            this.form2_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form2_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2_displaylabel.Location = new System.Drawing.Point(30, 82);
            this.form2_displaylabel.Name = "form2_displaylabel";
            this.form2_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form2_displaylabel.TabIndex = 4;
            this.form2_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AcceptButton = this.form2_squarebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form2_closebutton;
            this.ClientSize = new System.Drawing.Size(314, 196);
            this.Controls.Add(this.form2_displaylabel);
            this.Controls.Add(this.form2_label);
            this.Controls.Add(this.form2_closebutton);
            this.Controls.Add(this.form2_squarebutton);
            this.Controls.Add(this.form2_textBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Square a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox form2_textBox;
        private System.Windows.Forms.Button form2_squarebutton;
        private System.Windows.Forms.Button form2_closebutton;
        private System.Windows.Forms.Label form2_label;
        private System.Windows.Forms.Label form2_displaylabel;
    }
}