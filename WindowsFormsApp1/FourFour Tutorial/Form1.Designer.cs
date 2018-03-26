namespace FourFour_Tutorial
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.outMpgLabel = new System.Windows.Forms.Label();
            this.MPGLabel = new System.Windows.Forms.Label();
            this.gallonsLB = new System.Windows.Forms.Label();
            this.milesDrivenLB = new System.Windows.Forms.Label();
            this.inGallonsTB = new System.Windows.Forms.TextBox();
            this.inMilesTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(229, 138);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(116, 37);
            this.exitBTN.TabIndex = 15;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(81, 138);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(128, 37);
            this.calculateBTN.TabIndex = 14;
            this.calculateBTN.Text = "Calculate MPG";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // outMpgLabel
            // 
            this.outMpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outMpgLabel.Location = new System.Drawing.Point(245, 85);
            this.outMpgLabel.Name = "outMpgLabel";
            this.outMpgLabel.Size = new System.Drawing.Size(100, 23);
            this.outMpgLabel.TabIndex = 13;
            this.outMpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MPGLabel
            // 
            this.MPGLabel.AutoSize = true;
            this.MPGLabel.Location = new System.Drawing.Point(155, 90);
            this.MPGLabel.Name = "MPGLabel";
            this.MPGLabel.Size = new System.Drawing.Size(84, 13);
            this.MPGLabel.TabIndex = 12;
            this.MPGLabel.Text = "Your car\'s MPG:";
            // 
            // gallonsLB
            // 
            this.gallonsLB.AutoSize = true;
            this.gallonsLB.Location = new System.Drawing.Point(92, 57);
            this.gallonsLB.Name = "gallonsLB";
            this.gallonsLB.Size = new System.Drawing.Size(147, 13);
            this.gallonsLB.TabIndex = 11;
            this.gallonsLB.Text = "Enter the gallons of gas used:";
            // 
            // milesDrivenLB
            // 
            this.milesDrivenLB.AutoSize = true;
            this.milesDrivenLB.Location = new System.Drawing.Point(78, 31);
            this.milesDrivenLB.Name = "milesDrivenLB";
            this.milesDrivenLB.Size = new System.Drawing.Size(161, 13);
            this.milesDrivenLB.TabIndex = 10;
            this.milesDrivenLB.Text = "Enter the number of miles driven:";
            // 
            // inGallonsTB
            // 
            this.inGallonsTB.Location = new System.Drawing.Point(245, 54);
            this.inGallonsTB.Name = "inGallonsTB";
            this.inGallonsTB.Size = new System.Drawing.Size(100, 20);
            this.inGallonsTB.TabIndex = 9;
            // 
            // inMilesTB
            // 
            this.inMilesTB.Location = new System.Drawing.Point(245, 28);
            this.inMilesTB.Name = "inMilesTB";
            this.inMilesTB.Size = new System.Drawing.Size(100, 20);
            this.inMilesTB.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outMpgLabel);
            this.Controls.Add(this.MPGLabel);
            this.Controls.Add(this.gallonsLB);
            this.Controls.Add(this.milesDrivenLB);
            this.Controls.Add(this.inGallonsTB);
            this.Controls.Add(this.inMilesTB);
            this.Name = "Form1";
            this.Text = "MPG Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label outMpgLabel;
        private System.Windows.Forms.Label MPGLabel;
        private System.Windows.Forms.Label gallonsLB;
        private System.Windows.Forms.Label milesDrivenLB;
        private System.Windows.Forms.TextBox inGallonsTB;
        private System.Windows.Forms.TextBox inMilesTB;
    }
}

