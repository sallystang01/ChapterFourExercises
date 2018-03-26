using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;         //High Score Value
                double test1, test2, test3, average;    //Variablese

                // Get the test scores from the Textboxes
                test1 = double.Parse(tbScoreOne.Text);
                test2 = double.Parse(tbScoreTwo.Text);
                test3 = double.Parse(tbScoreThree.Text);

                //Calculate the average test score
                average = (test1 + test2 + test3) / 3;

                //Display the average, rounded to 2 decimal places.
                averageLabel.Text = average.ToString("n1");

                // If the average is a high score, congratulate
                //the user with a message box.
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations ! Great Job !");
                }
            }
            catch (Exception ex)
            {
                // display the default error message.
                MessageBox.Show(ex.Message);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbScoreOne.Text = null; //Clears Text of all text fields on the form
            tbScoreTwo.Text = null;
            tbScoreThree.Text = null;
            averageLabel.Text = null;
       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }
    }
}
