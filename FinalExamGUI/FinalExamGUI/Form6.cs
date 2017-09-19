//Jose Guadarrama
//5-5-2015
//Visual C# Programming Final Exam
//Various math calculations based on Radio Button selections

using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamGUI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void form6_productbutton_Click(object sender, EventArgs e)
        {
            //declare double variable to hold user input
            double input = Convert.ToDouble(form6_textBox.Text);
            double input2 = Convert.ToDouble(form6_textBox_2nd.Text);
            //delcare double variable to hold the results
            double product = input * input2;
            //display the results
            form6_displaylabel.Text = input + " * " + input2 + " = " + product.ToString("F3");

            //set focus to textbox
            form6_textBox.Focus();
            //selectall text in both textboxes
            form6_textBox.SelectAll();
            form6_textBox_2nd.SelectAll();
        }

        private void form6_textBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form6_displaylabel.Text = String.Empty;
        }

        private void form6_textBox_2nd_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form6_displaylabel.Text = String.Empty;
        }

        private void form6_closebutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
