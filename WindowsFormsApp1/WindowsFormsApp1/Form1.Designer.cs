namespace WindowsFormsApp1
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
            this.groupBoxTestScores = new System.Windows.Forms.GroupBox();
            this.tbScoreOne = new System.Windows.Forms.TextBox();
            this.tbScoreTwo = new System.Windows.Forms.TextBox();
            this.tbScoreThree = new System.Windows.Forms.TextBox();
            this.labelTestScore = new System.Windows.Forms.Label();
            this.labelTestScoreTwo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxTestScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTestScores
            // 
            this.groupBoxTestScores.Controls.Add(this.averageLabel);
            this.groupBoxTestScores.Controls.Add(this.label4);
            this.groupBoxTestScores.Controls.Add(this.label3);
            this.groupBoxTestScores.Controls.Add(this.labelTestScoreTwo);
            this.groupBoxTestScores.Controls.Add(this.labelTestScore);
            this.groupBoxTestScores.Controls.Add(this.tbScoreThree);
            this.groupBoxTestScores.Controls.Add(this.tbScoreTwo);
            this.groupBoxTestScores.Controls.Add(this.tbScoreOne);
            this.groupBoxTestScores.Location = new System.Drawing.Point(22, 24);
            this.groupBoxTestScores.Name = "groupBoxTestScores";
            this.groupBoxTestScores.Size = new System.Drawing.Size(250, 153);
            this.groupBoxTestScores.TabIndex = 0;
            this.groupBoxTestScores.TabStop = false;
            this.groupBoxTestScores.Text = "Enter Three Test Scores";
            // 
            // tbScoreOne
            // 
            this.tbScoreOne.Location = new System.Drawing.Point(144, 30);
            this.tbScoreOne.Name = "tbScoreOne";
            this.tbScoreOne.Size = new System.Drawing.Size(100, 20);
            this.tbScoreOne.TabIndex = 0;
            // 
            // tbScoreTwo
            // 
            this.tbScoreTwo.Location = new System.Drawing.Point(144, 56);
            this.tbScoreTwo.Name = "tbScoreTwo";
            this.tbScoreTwo.Size = new System.Drawing.Size(100, 20);
            this.tbScoreTwo.TabIndex = 1;
            // 
            // tbScoreThree
            // 
            this.tbScoreThree.Location = new System.Drawing.Point(144, 82);
            this.tbScoreThree.Name = "tbScoreThree";
            this.tbScoreThree.Size = new System.Drawing.Size(100, 20);
            this.tbScoreThree.TabIndex = 2;
            // 
            // labelTestScore
            // 
            this.labelTestScore.AutoSize = true;
            this.labelTestScore.Location = new System.Drawing.Point(26, 33);
            this.labelTestScore.Name = "labelTestScore";
            this.labelTestScore.Size = new System.Drawing.Size(75, 13);
            this.labelTestScore.TabIndex = 3;
            this.labelTestScore.Text = "Test Score #1";
            // 
            // labelTestScoreTwo
            // 
            this.labelTestScoreTwo.AutoSize = true;
            this.labelTestScoreTwo.Location = new System.Drawing.Point(26, 59);
            this.labelTestScoreTwo.Name = "labelTestScoreTwo";
            this.labelTestScoreTwo.Size = new System.Drawing.Size(75, 13);
            this.labelTestScoreTwo.TabIndex = 4;
            this.labelTestScoreTwo.Text = "Test Score #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test Score #3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(144, 111);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 23);
            this.averageLabel.TabIndex = 7;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(85, 183);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 66);
            this.calculateBTN.TabIndex = 1;
            this.calculateBTN.Text = "Calculate Average";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.groupBoxTestScores);
            this.Name = "Form1";
            this.Text = "Test Averages";
            this.groupBoxTestScores.ResumeLayout(false);
            this.groupBoxTestScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTestScores;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTestScoreTwo;
        private System.Windows.Forms.Label labelTestScore;
        private System.Windows.Forms.TextBox tbScoreThree;
        private System.Windows.Forms.TextBox tbScoreTwo;
        private System.Windows.Forms.TextBox tbScoreOne;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

