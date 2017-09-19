namespace FinalExamGUI
{
    partial class Form5
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
            this.form5_label_2nd = new System.Windows.Forms.Label();
            this.form5_textBox_2nd = new System.Windows.Forms.TextBox();
            this.form5_displaylabel = new System.Windows.Forms.Label();
            this.form5_label = new System.Windows.Forms.Label();
            this.form5_closebutton = new System.Windows.Forms.Button();
            this.form5_differencebutton = new System.Windows.Forms.Button();
            this.form5_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form5_label_2nd
            // 
            this.form5_label_2nd.Location = new System.Drawing.Point(30, 65);
            this.form5_label_2nd.Name = "form5_label_2nd";
            this.form5_label_2nd.Size = new System.Drawing.Size(115, 23);
            this.form5_label_2nd.TabIndex = 5;
            this.form5_label_2nd.Text = "Enter Second Number";
            // 
            // form5_textBox_2nd
            // 
            this.form5_textBox_2nd.Location = new System.Drawing.Point(165, 65);
            this.form5_textBox_2nd.Multiline = true;
            this.form5_textBox_2nd.Name = "form5_textBox_2nd";
            this.form5_textBox_2nd.Size = new System.Drawing.Size(126, 23);
            this.form5_textBox_2nd.TabIndex = 1;
            this.form5_textBox_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form5_textBox_2nd.TextChanged += new System.EventHandler(this.form5_textBox_2nd_TextChanged);
            // 
            // form5_displaylabel
            // 
            this.form5_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form5_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form5_displaylabel.Location = new System.Drawing.Point(33, 104);
            this.form5_displaylabel.Name = "form5_displaylabel";
            this.form5_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form5_displaylabel.TabIndex = 6;
            this.form5_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form5_label
            // 
            this.form5_label.Location = new System.Drawing.Point(30, 31);
            this.form5_label.Name = "form5_label";
            this.form5_label.Size = new System.Drawing.Size(115, 23);
            this.form5_label.TabIndex = 4;
            this.form5_label.Text = "Enter First Number";
            this.form5_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form5_closebutton
            // 
            this.form5_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form5_closebutton.Location = new System.Drawing.Point(165, 151);
            this.form5_closebutton.Name = "form5_closebutton";
            this.form5_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form5_closebutton.TabIndex = 3;
            this.form5_closebutton.Text = "&Close Form";
            this.form5_closebutton.UseVisualStyleBackColor = true;
            this.form5_closebutton.Click += new System.EventHandler(this.form5_closebutton_Click);
            // 
            // form5_differencebutton
            // 
            this.form5_differencebutton.Location = new System.Drawing.Point(33, 151);
            this.form5_differencebutton.Name = "form5_differencebutton";
            this.form5_differencebutton.Size = new System.Drawing.Size(126, 31);
            this.form5_differencebutton.TabIndex = 2;
            this.form5_differencebutton.Text = "&Difference";
            this.form5_differencebutton.UseVisualStyleBackColor = true;
            this.form5_differencebutton.Click += new System.EventHandler(this.form5_differencebutton_Click);
            // 
            // form5_textBox
            // 
            this.form5_textBox.Location = new System.Drawing.Point(165, 31);
            this.form5_textBox.Multiline = true;
            this.form5_textBox.Name = "form5_textBox";
            this.form5_textBox.Size = new System.Drawing.Size(126, 23);
            this.form5_textBox.TabIndex = 0;
            this.form5_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form5_textBox.TextChanged += new System.EventHandler(this.form5_textBox_TextChanged);
            // 
            // Form5
            // 
            this.AcceptButton = this.form5_differencebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form5_closebutton;
            this.ClientSize = new System.Drawing.Size(321, 213);
            this.Controls.Add(this.form5_label_2nd);
            this.Controls.Add(this.form5_textBox_2nd);
            this.Controls.Add(this.form5_displaylabel);
            this.Controls.Add(this.form5_label);
            this.Controls.Add(this.form5_closebutton);
            this.Controls.Add(this.form5_differencebutton);
            this.Controls.Add(this.form5_textBox);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difference of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form5_label_2nd;
        private System.Windows.Forms.TextBox form5_textBox_2nd;
        private System.Windows.Forms.Label form5_displaylabel;
        private System.Windows.Forms.Label form5_label;
        private System.Windows.Forms.Button form5_closebutton;
        private System.Windows.Forms.Button form5_differencebutton;
        private System.Windows.Forms.TextBox form5_textBox;
    }
}