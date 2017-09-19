//Jose Guadarrama
//5-5-2015
//Visual C# Programming Final Exam
//Various math calculations based on Radio Button selections

using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2_squarebutton_Click(object sender, EventArgs e)
        {
            //declare double variable to hold user input
            double input = Convert.ToDouble(form2_textBox.Text);
            //delcare double variable to hold the results
            double square = input * input;
            //display the results
            form2_displaylabel.Text = input + " squared is " + square.ToString("F3");

            //set focus to textbox
            form2_textBox.Focus();
            //selectall text in textbox
            form2_textBox.SelectAll();
        }

        private void form2_textBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form2_displaylabel.Text = String.Empty;
        }

        private void form2_closebutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
