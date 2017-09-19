namespace FinalExamGUI
{
    partial class Form6
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
            this.form6_label_2nd = new System.Windows.Forms.Label();
            this.form6_textBox_2nd = new System.Windows.Forms.TextBox();
            this.form6_displaylabel = new System.Windows.Forms.Label();
            this.form6_label = new System.Windows.Forms.Label();
            this.form6_closebutton = new System.Windows.Forms.Button();
            this.form6_productbutton = new System.Windows.Forms.Button();
            this.form6_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form6_label_2nd
            // 
            this.form6_label_2nd.Location = new System.Drawing.Point(31, 64);
            this.form6_label_2nd.Name = "form6_label_2nd";
            this.form6_label_2nd.Size = new System.Drawing.Size(116, 23);
            this.form6_label_2nd.TabIndex = 5;
            this.form6_label_2nd.Text = "Enter Second Number";
            this.form6_label_2nd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form6_textBox_2nd
            // 
            this.form6_textBox_2nd.Location = new System.Drawing.Point(166, 64);
            this.form6_textBox_2nd.Multiline = true;
            this.form6_textBox_2nd.Name = "form6_textBox_2nd";
            this.form6_textBox_2nd.Size = new System.Drawing.Size(126, 23);
            this.form6_textBox_2nd.TabIndex = 1;
            this.form6_textBox_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form6_textBox_2nd.TextChanged += new System.EventHandler(this.form6_textBox_2nd_TextChanged);
            // 
            // form6_displaylabel
            // 
            this.form6_displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form6_displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form6_displaylabel.Location = new System.Drawing.Point(34, 103);
            this.form6_displaylabel.Name = "form6_displaylabel";
            this.form6_displaylabel.Size = new System.Drawing.Size(258, 26);
            this.form6_displaylabel.TabIndex = 6;
            this.form6_displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form6_label
            // 
            this.form6_label.Location = new System.Drawing.Point(31, 30);
            this.form6_label.Name = "form6_label";
            this.form6_label.Size = new System.Drawing.Size(116, 23);
            this.form6_label.TabIndex = 4;
            this.form6_label.Text = "Enter First Number";
            this.form6_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form6_closebutton
            // 
            this.form6_closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.form6_closebutton.Location = new System.Drawing.Point(166, 150);
            this.form6_closebutton.Name = "form6_closebutton";
            this.form6_closebutton.Size = new System.Drawing.Size(126, 31);
            this.form6_closebutton.TabIndex = 3;
            this.form6_closebutton.Text = "&Close Form";
            this.form6_closebutton.UseVisualStyleBackColor = true;
            this.form6_closebutton.Click += new System.EventHandler(this.form6_closebutton_Click);
            // 
            // form6_productbutton
            // 
            this.form6_productbutton.Location = new System.Drawing.Point(34, 150);
            this.form6_productbutton.Name = "form6_productbutton";
            this.form6_productbutton.Size = new System.Drawing.Size(126, 31);
            this.form6_productbutton.TabIndex = 2;
            this.form6_productbutton.Text = "&Product";
            this.form6_productbutton.UseVisualStyleBackColor = true;
            this.form6_productbutton.Click += new System.EventHandler(this.form6_productbutton_Click);
            // 
            // form6_textBox
            // 
            this.form6_textBox.Location = new System.Drawing.Point(166, 30);
            this.form6_textBox.Multiline = true;
            this.form6_textBox.Name = "form6_textBox";
            this.form6_textBox.Size = new System.Drawing.Size(126, 23);
            this.form6_textBox.TabIndex = 0;
            this.form6_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form6_textBox.TextChanged += new System.EventHandler(this.form6_textBox_TextChanged);
            // 
            // Form6
            // 
            this.AcceptButton = this.form6_productbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form6_closebutton;
            this.ClientSize = new System.Drawing.Size(323, 211);
            this.Controls.Add(this.form6_label_2nd);
            this.Controls.Add(this.form6_textBox_2nd);
            this.Controls.Add(this.form6_displaylabel);
            this.Controls.Add(this.form6_label);
            this.Controls.Add(this.form6_closebutton);
            this.Controls.Add(this.form6_productbutton);
            this.Controls.Add(this.form6_textBox);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form6_label_2nd;
        private System.Windows.Forms.TextBox form6_textBox_2nd;
        private System.Windows.Forms.Label form6_displaylabel;
        private System.Windows.Forms.Label form6_label;
        private System.Windows.Forms.Button form6_closebutton;
        private System.Windows.Forms.Button form6_productbutton;
        private System.Windows.Forms.TextBox form6_textBox;
    }
}