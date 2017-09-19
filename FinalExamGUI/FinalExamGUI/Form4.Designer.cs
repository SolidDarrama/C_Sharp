namespace FinalExamGUI
{
    partial class Form4
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
            this.form4_displaylabel = new System.Windows.Forms.Label();
            this.form4_label = new System.Windows.Forms.Label();
            this.form4_closebutton = new System.Windows.Forms.Button();
            this.form4_sumbutton = new System.Windows.Forms.Button();
            this.form4_textBox = new System.Windows.Forms.TextBox();
            this.form4_label_2nd = new System.Windows.Forms.Label();
            this.form4_textBox_2nd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form4_displaylabel
            // 
            this.form4_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form4_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form4_displaylabel.Location = new System.Drawing.Point(32, 107);
            this.form4_displaylabel.Name = "form4_displaylabel";
            this.form4_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form4_displaylabel.TabIndex = 6;
            this.form4_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form4_label
            // 
            this.form4_label.Location = new System.Drawing.Point(29, 34);
            this.form4_label.Name = "form4_label";
            this.form4_label.Size = new System.Drawing.Size(114, 23);
            this.form4_label.TabIndex = 4;
            this.form4_label.Text = "Enter First Number";
            this.form4_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form4_closebutton
            // 
            this.form4_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form4_closebutton.Location = new System.Drawing.Point(164, 154);
            this.form4_closebutton.Name = "form4_closebutton";
            this.form4_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form4_closebutton.TabIndex = 3;
            this.form4_closebutton.Text = "&Close Form";
            this.form4_closebutton.UseVisualStyleBackColor = true;
            this.form4_closebutton.Click += new System.EventHandler(this.form4_closebutton_Click);
            // 
            // form4_sumbutton
            // 
            this.form4_sumbutton.Location = new System.Drawing.Point(32, 154);
            this.form4_sumbutton.Name = "form4_sumbutton";
            this.form4_sumbutton.Size = new System.Drawing.Size(126, 31);
            this.form4_sumbutton.TabIndex = 2;
            this.form4_sumbutton.Text = "&Sum";
            this.form4_sumbutton.UseVisualStyleBackColor = true;
            this.form4_sumbutton.Click += new System.EventHandler(this.form4_sumbutton_Click);
            // 
            // form4_textBox
            // 
            this.form4_textBox.Location = new System.Drawing.Point(164, 34);
            this.form4_textBox.Multiline = true;
            this.form4_textBox.Name = "form4_textBox";
            this.form4_textBox.Size = new System.Drawing.Size(126, 23);
            this.form4_textBox.TabIndex = 0;
            this.form4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form4_textBox.TextChanged += new System.EventHandler(this.form4_textBox_TextChanged);
            // 
            // form4_label_2nd
            // 
            this.form4_label_2nd.Location = new System.Drawing.Point(29, 68);
            this.form4_label_2nd.Name = "form4_label_2nd";
            this.form4_label_2nd.Size = new System.Drawing.Size(114, 23);
            this.form4_label_2nd.TabIndex = 5;
            this.form4_label_2nd.Text = "Enter Second Number";
            this.form4_label_2nd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form4_textBox_2nd
            // 
            this.form4_textBox_2nd.Location = new System.Drawing.Point(164, 68);
            this.form4_textBox_2nd.Multiline = true;
            this.form4_textBox_2nd.Name = "form4_textBox_2nd";
            this.form4_textBox_2nd.Size = new System.Drawing.Size(126, 23);
            this.form4_textBox_2nd.TabIndex = 1;
            this.form4_textBox_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form4_textBox_2nd.TextChanged += new System.EventHandler(this.form4_textBox_2nd_TextChanged);
            // 
            // Form4
            // 
            this.AcceptButton = this.form4_sumbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form4_closebutton;
            this.ClientSize = new System.Drawing.Size(318, 218);
            this.Controls.Add(this.form4_label_2nd);
            this.Controls.Add(this.form4_textBox_2nd);
            this.Controls.Add(this.form4_displaylabel);
            this.Controls.Add(this.form4_label);
            this.Controls.Add(this.form4_closebutton);
            this.Controls.Add(this.form4_sumbutton);
            this.Controls.Add(this.form4_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sum of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form4_displaylabel;
        private System.Windows.Forms.Label form4_label;
        private System.Windows.Forms.Button form4_closebutton;
        private System.Windows.Forms.Button form4_sumbutton;
        private System.Windows.Forms.TextBox form4_textBox;
        private System.Windows.Forms.Label form4_label_2nd;
        private System.Windows.Forms.TextBox form4_textBox_2nd;
    }
}