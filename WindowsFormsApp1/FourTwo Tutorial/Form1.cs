using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourTwo_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hoursWorkedTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void hourlyPayRatelabel_Click(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            hoursWorkedTB.Text = null; //Clears all the text fields
            hourlyPayRateTB.Text = null;
            outGrossPaylabel.Text = null;

            hoursWorkedTB.Focus();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //Name constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //Variables
                decimal hoursWorked;           //hours worked
                decimal hourlyPayRate;         //pay rate
                decimal basePay;               //base pay
                decimal overtimeHours;         //overtime
                decimal overtimePay;           // overtime pay
                decimal grossPay;              //gross Pay

                // Get the hours worked and hourly pay rate
                hoursWorked = decimal.Parse(hoursWorkedTB.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTB.Text);

                //determine the gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    // calculate the base pay (wo OT)
                    basePay = hourlyPayRate * BASE_HOURS;
                    //calculate the number of OT hurs
                    overtimeHours = hoursWorked - BASE_HOURS;
                    //calculate OT pay
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;
                    //calculate the gross pay
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    //Calculate teh gross pay if false
                    grossPay = hoursWorked * hourlyPayRate;
                }
                // Display the gross pay
                outGrossPaylabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes form
        }
    }
}
