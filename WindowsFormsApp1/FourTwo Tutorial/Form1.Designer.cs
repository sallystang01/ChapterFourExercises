namespace FourTwo_Tutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursWorkedTB = new System.Windows.Forms.TextBox();
            this.outGrossPaylabel = new System.Windows.Forms.Label();
            this.grossPaylabel = new System.Windows.Forms.Label();
            this.hourlyPayRatelabel = new System.Windows.Forms.Label();
            this.hoursWorkedlabel = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.hourlyPayRateTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hoursWorkedTB
            // 
            this.hoursWorkedTB.Location = new System.Drawing.Point(162, 38);
            this.hoursWorkedTB.Name = "hoursWorkedTB";
            this.hoursWorkedTB.Size = new System.Drawing.Size(88, 20);
            this.hoursWorkedTB.TabIndex = 16;
            this.hoursWorkedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursWorkedTB.TextChanged += new System.EventHandler(this.hoursWorkedTB_TextChanged);
            // 
            // outGrossPaylabel
            // 
            this.outGrossPaylabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outGrossPaylabel.Location = new System.Drawing.Point(162, 87);
            this.outGrossPaylabel.Name = "outGrossPaylabel";
            this.outGrossPaylabel.Size = new System.Drawing.Size(88, 23);
            this.outGrossPaylabel.TabIndex = 15;
            this.outGrossPaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grossPaylabel
            // 
            this.grossPaylabel.AutoSize = true;
            this.grossPaylabel.Location = new System.Drawing.Point(98, 92);
            this.grossPaylabel.Name = "grossPaylabel";
            this.grossPaylabel.Size = new System.Drawing.Size(58, 13);
            this.grossPaylabel.TabIndex = 14;
            this.grossPaylabel.Text = "Gross Pay:";
            // 
            // hourlyPayRatelabel
            // 
            this.hourlyPayRatelabel.AutoSize = true;
            this.hourlyPayRatelabel.Location = new System.Drawing.Point(69, 67);
            this.hourlyPayRatelabel.Name = "hourlyPayRatelabel";
            this.hourlyPayRatelabel.Size = new System.Drawing.Size(87, 13);
            this.hourlyPayRatelabel.TabIndex = 13;
            this.hourlyPayRatelabel.Text = "Hourly Pay Rate:";
            this.hourlyPayRatelabel.Click += new System.EventHandler(this.hourlyPayRatelabel_Click);
            // 
            // hoursWorkedlabel
            // 
            this.hoursWorkedlabel.AutoSize = true;
            this.hoursWorkedlabel.Location = new System.Drawing.Point(77, 41);
            this.hoursWorkedlabel.Name = "hoursWorkedlabel";
            this.hoursWorkedlabel.Size = new System.Drawing.Size(79, 13);
            this.hoursWorkedlabel.TabIndex = 12;
            this.hoursWorkedlabel.Text = "Hours Worked:";
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(162, 181);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(88, 26);
            this.exitBTN.TabIndex = 11;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(162, 145);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(88, 26);
            this.clearBTN.TabIndex = 10;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(68, 145);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(88, 62);
            this.calculateBTN.TabIndex = 9;
            this.calculateBTN.Text = "Calculate Gross Pay";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // hourlyPayRateTB
            // 
            this.hourlyPayRateTB.Location = new System.Drawing.Point(162, 64);
            this.hourlyPayRateTB.Name = "hourlyPayRateTB";
            this.hourlyPayRateTB.Size = new System.Drawing.Size(88, 20);
            this.hourlyPayRateTB.TabIndex = 17;
            this.hourlyPayRateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.Controls.Add(this.hourlyPayRateTB);
            this.Controls.Add(this.hoursWorkedTB);
            this.Controls.Add(this.outGrossPaylabel);
            this.Controls.Add(this.grossPaylabel);
            this.Controls.Add(this.hourlyPayRatelabel);
            this.Controls.Add(this.hoursWorkedlabel);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.calculateBTN);
            this.Name = "Form1";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hoursWorkedTB;
        private System.Windows.Forms.Label outGrossPaylabel;
        private System.Windows.Forms.Label grossPaylabel;
        private System.Windows.Forms.Label hourlyPayRatelabel;
        private System.Windows.Forms.Label hoursWorkedlabel;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.TextBox hourlyPayRateTB;
    }
}

