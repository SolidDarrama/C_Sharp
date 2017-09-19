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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_radioButton_Squared_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Squared.Checked)
            {
                //instantiate form 2
                Form2 myForm2 = new Form2();
                //refer Showdialog
                myForm2.ShowDialog();
            }
        }

        private void MenuForm_radioButton_Cubed_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Cubed.Checked)
            {
                //instantiate form 3
                Form3 myForm3 = new Form3();
                //refer Showdialog
                myForm3.ShowDialog();
            }
        }

        private void MenuForm_radioButton_Sum_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Sum.Checked)
            {
                //instantiate form 4
                Form4 myForm4 = new Form4();
                //refer Showdialog
                myForm4.ShowDialog();
            }

        }

        private void MenuForm_radioButton_Difference_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Difference.Checked)
            {
                //instantiate form 5
                Form5 myForm5 = new Form5();
                //refer Showdialog
                myForm5.ShowDialog();
            }

        }

        private void MenuForm_radioButton_Product_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Product.Checked)
            {
                //instantiate form 6
                Form6 myForm6 = new Form6();
                //refer Showdialog
                myForm6.ShowDialog();
            }

        }

        private void MenuForm_radioButton_Quotient_CheckedChanged(object sender, EventArgs e)
        {
            //determine if radiobutton was selected
            if (MenuForm_radioButton_Quotient.Checked)
            {
                //instantiate form 7
                Form7 myForm7 = new Form7();
                //refer Showdialog
                myForm7.ShowDialog();
            }

        }

        private void MenuForm_exitbutton_Click(object sender, EventArgs e)
        {
            //terminate app
            Close();
        }
    }
}
