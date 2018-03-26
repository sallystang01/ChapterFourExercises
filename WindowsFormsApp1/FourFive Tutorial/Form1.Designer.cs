namespace FourFive_Tutorial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.exitBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NormalRadioButton);
            this.groupBox1.Controls.Add(this.whiteRadioButton);
            this.groupBox1.Controls.Add(this.RedRadioButton);
            this.groupBox1.Controls.Add(this.yellowRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Background Color";
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Checked = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(36, 160);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(98, 17);
            this.NormalRadioButton.TabIndex = 3;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "Back to Normal";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(36, 116);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 2;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(36, 72);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Location = new System.Drawing.Point(36, 28);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton.TabIndex = 0;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(217, 218);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(55, 31);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBTN);
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.Button exitBTN;
    }
}

