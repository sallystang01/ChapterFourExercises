namespace FourThree_Tutorial
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
            this.decisionLabel = new System.Windows.Forms.Label();
            this.loanDecisionLabel = new System.Windows.Forms.Label();
            this.currentJobLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.yearsTB = new System.Windows.Forms.TextBox();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.checkBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionLabel.Location = new System.Drawing.Point(62, 107);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(249, 73);
            this.decisionLabel.TabIndex = 17;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loanDecisionLabel
            // 
            this.loanDecisionLabel.AutoSize = true;
            this.loanDecisionLabel.Location = new System.Drawing.Point(148, 81);
            this.loanDecisionLabel.Name = "loanDecisionLabel";
            this.loanDecisionLabel.Size = new System.Drawing.Size(75, 13);
            this.loanDecisionLabel.TabIndex = 16;
            this.loanDecisionLabel.Text = "Loan Decision";
            // 
            // currentJobLabel
            // 
            this.currentJobLabel.AutoSize = true;
            this.currentJobLabel.Location = new System.Drawing.Point(90, 51);
            this.currentJobLabel.Name = "currentJobLabel";
            this.currentJobLabel.Size = new System.Drawing.Size(105, 13);
            this.currentJobLabel.TabIndex = 15;
            this.currentJobLabel.Text = "Years at current Job:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(120, 25);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(75, 13);
            this.salaryLabel.TabIndex = 14;
            this.salaryLabel.Text = "Annual Salary:";
            // 
            // yearsTB
            // 
            this.yearsTB.Location = new System.Drawing.Point(201, 48);
            this.yearsTB.Name = "yearsTB";
            this.yearsTB.Size = new System.Drawing.Size(100, 20);
            this.yearsTB.TabIndex = 10;
            // 
            // salaryTB
            // 
            this.salaryTB.Location = new System.Drawing.Point(201, 22);
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.Size = new System.Drawing.Size(100, 20);
            this.salaryTB.TabIndex = 9;
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(201, 183);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(65, 29);
            this.clearBTN.TabIndex = 12;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // checkBTN
            // 
            this.checkBTN.Location = new System.Drawing.Point(83, 183);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(109, 64);
            this.checkBTN.TabIndex = 11;
            this.checkBTN.Text = "Check Qualifications";
            this.checkBTN.UseVisualStyleBackColor = true;
            this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(201, 218);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(65, 29);
            this.exitBTN.TabIndex = 18;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.loanDecisionLabel);
            this.Controls.Add(this.currentJobLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.yearsTB);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.checkBTN);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Label loanDecisionLabel;
        private System.Windows.Forms.Label currentJobLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox yearsTB;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

