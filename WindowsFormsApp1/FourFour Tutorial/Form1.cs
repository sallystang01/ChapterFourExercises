using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFour_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            double miles;        
            double gallons;     
            double mpg;          

            //Validate the milesTextBox control
            if (double.TryParse(inMilesTB.Text, out miles))
            {
                //Validate the inGallonsTB control.
                if (double.TryParse(inGallonsTB.Text, out gallons))
                {
                    //Calculate MPG
                    mpg = miles / gallons;

                    //Display the MPG in the outMpgLabel control
                    outMpgLabel.Text = mpg.ToString("n1") + " " + "MPG";

                }
                else
                {
                    //display an error message for inGallonsTB.
                    MessageBox.Show("Invalid input for gallons.");

                }

            }
            else
            {
                // display an error message for inMilesTB.
                MessageBox.Show("Invalid input for miles.");
            }


        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }
    }
}
