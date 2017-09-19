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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void form7_Quotientbutton_Click(object sender, EventArgs e)
        {
            //declare double variable to hold user input
            double input = Convert.ToDouble(form7_textBox.Text);
            double input2 = Convert.ToDouble(form7_textBox_2nd.Text);
            //delcare double variable to hold the results
            double quotient = input / input2;

            //if statement (user didn't input 0)
            if (0 != input || 0 != input2)
            {
                //display the results
                form7_displaylabel.Text = input + " / " + input2 + " = " + quotient.ToString("F3");
            }

            //if statement (user did input 0)
            if (0 == input || 0 == input2)
            {
                //display error
                form7_displaylabel.Text = "ERROR... CANNOT DIVIDE BY 0";
            }


            //set focus to textbox
            form7_textBox.Focus();
            //selectall text in both textboxes
            form7_textBox.SelectAll();
            form7_textBox_2nd.SelectAll();
        }

        private void form7_textBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form7_displaylabel.Text = String.Empty;
        }

        private void form7_textBox_2nd_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            form7_displaylabel.Text = String.Empty;
        }

        private void form7_closebutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
