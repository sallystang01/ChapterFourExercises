using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourThree_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Name Constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;
                //Local Variables
                decimal salary;
                int yearsOnJob;
                //Salary and years on the job
                salary = decimal.Parse(salaryTB.Text);
                yearsOnJob = int.Parse(yearsTB.Text);
                //Determine if you qaulify 
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //the user qualifies
                        decisionLabel.Text = "You qualify for the Loan";

                    }
                    else
                    {
                        //the user does not qualify
                        decisionLabel.Text = "Minimum years at current" + " " + "Job not met";
                    }

                }
                else
                {
                    //the user does not qualify
                    decisionLabel.Text = "Minimum Salary Requirement" + " " + "not met.";
                }
            }
            catch (Exception ex)

            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {

            salaryTB.Text = null; //Clears all text fields
            yearsTB.Text = null;
            decisionLabel.Text = null;

            salaryTB.Focus(); //Sets focus back to salary text box
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
