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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void form3_cubebutton_Click(object sender, EventArgs e)
        {
            //declare double variable to hold user input
            double input = Convert.ToDouble(form3_textBox.Text);
            //delcare double variable to hold the results
            double cube = input * input * input;
            //display the results
            form3_displaylabel.Text = input + " cubed is " + cube.ToString("F3");

            //set focus to textbox
            form3_textBox.Focus();
            //selectall text in textbox
            form3_textBox.SelectAll();
        }

        private void form3_textBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form3_displaylabel.Text = String.Empty;
        }

        private void form3_closebutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
