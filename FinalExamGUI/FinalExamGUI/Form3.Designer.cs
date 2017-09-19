namespace FinalExamGUI
{
    partial class Form3
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
            this.form3_displaylabel = new System.Windows.Forms.Label();
            this.form3_label = new System.Windows.Forms.Label();
            this.form3_closebutton = new System.Windows.Forms.Button();
            this.form3_cubebutton = new System.Windows.Forms.Button();
            this.form3_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form3_displaylabel
            // 
            this.form3_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form3_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form3_displaylabel.Location = new System.Drawing.Point(31, 78);
            this.form3_displaylabel.Name = "form3_displaylabel";
            this.form3_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form3_displaylabel.TabIndex = 4;
            this.form3_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form3_label
            // 
            this.form3_label.Location = new System.Drawing.Point(28, 30);
            this.form3_label.Name = "form3_label";
            this.form3_label.Size = new System.Drawing.Size(129, 23);
            this.form3_label.TabIndex = 3;
            this.form3_label.Text = "Enter Number to Cube";
            this.form3_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form3_closebutton
            // 
            this.form3_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form3_closebutton.Location = new System.Drawing.Point(163, 125);
            this.form3_closebutton.Name = "form3_closebutton";
            this.form3_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form3_closebutton.TabIndex = 2;
            this.form3_closebutton.Text = "&Close Form";
            this.form3_closebutton.UseVisualStyleBackColor = true;
            this.form3_closebutton.Click += new System.EventHandler(this.form3_closebutton_Click);
            // 
            // form3_cubebutton
            // 
            this.form3_cubebutton.Location = new System.Drawing.Point(31, 125);
            this.form3_cubebutton.Name = "form3_cubebutton";
            this.form3_cubebutton.Size = new System.Drawing.Size(126, 31);
            this.form3_cubebutton.TabIndex = 1;
            this.form3_cubebutton.Text = "C&ube";
            this.form3_cubebutton.UseVisualStyleBackColor = true;
            this.form3_cubebutton.Click += new System.EventHandler(this.form3_cubebutton_Click);
            // 
            // form3_textBox
            // 
            this.form3_textBox.Location = new System.Drawing.Point(163, 32);
            this.form3_textBox.Multiline = true;
            this.form3_textBox.Name = "form3_textBox";
            this.form3_textBox.Size = new System.Drawing.Size(126, 23);
            this.form3_textBox.TabIndex = 0;
            this.form3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form3_textBox.TextChanged += new System.EventHandler(this.form3_textBox_TextChanged);
            // 
            // Form3
            // 
            this.AcceptButton = this.form3_cubebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form3_closebutton;
            this.ClientSize = new System.Drawing.Size(316, 189);
            this.Controls.Add(this.form3_displaylabel);
            this.Controls.Add(this.form3_label);
            this.Controls.Add(this.form3_closebutton);
            this.Controls.Add(this.form3_cubebutton);
            this.Controls.Add(this.form3_textBox);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cube a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form3_displaylabel;
        private System.Windows.Forms.Label form3_label;
        private System.Windows.Forms.Button form3_closebutton;
        private System.Windows.Forms.Button form3_cubebutton;
        private System.Windows.Forms.TextBox form3_textBox;
    }
}