namespace FinalExamGUI
{
    partial class Form7
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
            this.form7_label_2nd = new System.Windows.Forms.Label();
            this.form7_textBox_2nd = new System.Windows.Forms.TextBox();
            this.form7_displaylabel = new System.Windows.Forms.Label();
            this.form7_label = new System.Windows.Forms.Label();
            this.form7_closebutton = new System.Windows.Forms.Button();
            this.form7_Quotientbutton = new System.Windows.Forms.Button();
            this.form7_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form7_label_2nd
            // 
            this.form7_label_2nd.Location = new System.Drawing.Point(30, 67);
            this.form7_label_2nd.Name = "form7_label_2nd";
            this.form7_label_2nd.Size = new System.Drawing.Size(100, 23);
            this.form7_label_2nd.TabIndex = 5;
            this.form7_label_2nd.Text = "Enter Second Number";
            this.form7_label_2nd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form7_textBox_2nd
            // 
            this.form7_textBox_2nd.Location = new System.Drawing.Point(165, 67);
            this.form7_textBox_2nd.Multiline = true;
            this.form7_textBox_2nd.Name = "form7_textBox_2nd";
            this.form7_textBox_2nd.Size = new System.Drawing.Size(126, 23);
            this.form7_textBox_2nd.TabIndex = 1;
            this.form7_textBox_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form7_textBox_2nd.TextChanged += new System.EventHandler(this.form7_textBox_2nd_TextChanged);
            // 
            // form7_displaylabel
            // 
            this.form7_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form7_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form7_displaylabel.Location = new System.Drawing.Point(33, 106);
            this.form7_displaylabel.Name = "form7_displaylabel";
            this.form7_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form7_displaylabel.TabIndex = 6;
            this.form7_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form7_label
            // 
            this.form7_label.Location = new System.Drawing.Point(30, 33);
            this.form7_label.Name = "form7_label";
            this.form7_label.Size = new System.Drawing.Size(100, 23);
            this.form7_label.TabIndex = 4;
            this.form7_label.Text = "Enter First Number";
            this.form7_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form7_closebutton
            // 
            this.form7_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form7_closebutton.Location = new System.Drawing.Point(165, 153);
            this.form7_closebutton.Name = "form7_closebutton";
            this.form7_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form7_closebutton.TabIndex = 3;
            this.form7_closebutton.Text = "&Close Form";
            this.form7_closebutton.UseVisualStyleBackColor = true;
            this.form7_closebutton.Click += new System.EventHandler(this.form7_closebutton_Click);
            // 
            // form7_Quotientbutton
            // 
            this.form7_Quotientbutton.Location = new System.Drawing.Point(33, 153);
            this.form7_Quotientbutton.Name = "form7_Quotientbutton";
            this.form7_Quotientbutton.Size = new System.Drawing.Size(126, 31);
            this.form7_Quotientbutton.TabIndex = 2;
            this.form7_Quotientbutton.Text = "&Quotient";
            this.form7_Quotientbutton.UseVisualStyleBackColor = true;
            this.form7_Quotientbutton.Click += new System.EventHandler(this.form7_Quotientbutton_Click);
            // 
            // form7_textBox
            // 
            this.form7_textBox.Location = new System.Drawing.Point(165, 33);
            this.form7_textBox.Multiline = true;
            this.form7_textBox.Name = "form7_textBox";
            this.form7_textBox.Size = new System.Drawing.Size(126, 23);
            this.form7_textBox.TabIndex = 0;
            this.form7_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form7_textBox.TextChanged += new System.EventHandler(this.form7_textBox_TextChanged);
            // 
            // Form7
            // 
            this.AcceptButton = this.form7_Quotientbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form7_closebutton;
            this.ClientSize = new System.Drawing.Size(321, 216);
            this.Controls.Add(this.form7_label_2nd);
            this.Controls.Add(this.form7_textBox_2nd);
            this.Controls.Add(this.form7_displaylabel);
            this.Controls.Add(this.form7_label);
            this.Controls.Add(this.form7_closebutton);
            this.Controls.Add(this.form7_Quotientbutton);
            this.Controls.Add(this.form7_textBox);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quotient of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form7_label_2nd;
        private System.Windows.Forms.TextBox form7_textBox_2nd;
        private System.Windows.Forms.Label form7_displaylabel;
        private System.Windows.Forms.Label form7_label;
        private System.Windows.Forms.Button form7_closebutton;
        private System.Windows.Forms.Button form7_Quotientbutton;
        private System.Windows.Forms.TextBox form7_textBox;
    }
}