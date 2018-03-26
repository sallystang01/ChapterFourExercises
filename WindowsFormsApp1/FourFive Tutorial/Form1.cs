using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFive_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked) // If yellow button checked
            {
                this.BackColor = Color.Yellow; //Change background to yello
            }
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioButton.Checked) //If red button checkec
            {
                this.BackColor = Color.IndianRed; //Change background to red
            }
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteRadioButton.Checked) //If white background checked
            {
                this.BackColor = Color.White; //Change background to white
            }
        }

        private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalRadioButton.Checked) //If normal button checked
            {
                this.BackColor = SystemColors.Control; //Change background color back to normal
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }
    }
}
