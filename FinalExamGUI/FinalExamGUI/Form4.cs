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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void form4_sumbutton_Click(object sender, EventArgs e)
        {
            //declare double variable to hold user input
            double input = Convert.ToDouble(form4_textBox.Text);
            double input2 = Convert.ToDouble(form4_textBox_2nd.Text);
            //delcare double variable to hold the results
            double sum = input + input2;
            //display the results
            form4_displaylabel.Text = input + " + " + input2 + " = " + sum.ToString("F3");

            //set focus to textbox
            form4_textBox.Focus();
            //selectall text in both textboxes
            form4_textBox.SelectAll();
            form4_textBox_2nd.SelectAll();
        }

        private void form4_textBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form4_displaylabel.Text = String.Empty;
        }

        private void form4_textBox_2nd_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form4_displaylabel.Text = String.Empty;
        }

        private void form4_closebutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
