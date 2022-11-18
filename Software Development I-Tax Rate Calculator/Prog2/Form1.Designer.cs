namespace Prog2
{
    partial class Prog2
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
            this.TaxPlans = new System.Windows.Forms.Label();
            this.baseLine = new System.Windows.Forms.RadioButton();
            this.candidate1 = new System.Windows.Forms.RadioButton();
            this.candidate2 = new System.Windows.Forms.RadioButton();
            this.candidate3 = new System.Windows.Forms.RadioButton();
            this.incomelbl = new System.Windows.Forms.Label();
            this.incomeTXT = new System.Windows.Forms.TextBox();
            this.taxRatelbl = new System.Windows.Forms.Label();
            this.taxDuelbl = new System.Windows.Forms.Label();
            this.taxRate = new System.Windows.Forms.Label();
            this.taxDue = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaxPlans
            // 
            this.TaxPlans.AutoSize = true;
            this.TaxPlans.BackColor = System.Drawing.SystemColors.Control;
            this.TaxPlans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxPlans.Location = new System.Drawing.Point(152, 137);
            this.TaxPlans.Name = "TaxPlans";
            this.TaxPlans.Size = new System.Drawing.Size(116, 27);
            this.TaxPlans.TabIndex = 0;
            this.TaxPlans.Text = "Tax Plans:";
            // 
            // baseLine
            // 
            this.baseLine.AutoSize = true;
            this.baseLine.Location = new System.Drawing.Point(31, 180);
            this.baseLine.Name = "baseLine";
            this.baseLine.Size = new System.Drawing.Size(133, 29);
            this.baseLine.TabIndex = 1;
            this.baseLine.TabStop = true;
            this.baseLine.Text = "BaseLine";
            this.baseLine.UseVisualStyleBackColor = true;
            this.baseLine.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // candidate1
            // 
            this.candidate1.AutoSize = true;
            this.candidate1.Location = new System.Drawing.Point(31, 231);
            this.candidate1.Name = "candidate1";
            this.candidate1.Size = new System.Drawing.Size(159, 29);
            this.candidate1.TabIndex = 2;
            this.candidate1.TabStop = true;
            this.candidate1.Text = "Candidate 1";
            this.candidate1.UseVisualStyleBackColor = true;
            // 
            // candidate2
            // 
            this.candidate2.AutoSize = true;
            this.candidate2.Location = new System.Drawing.Point(31, 285);
            this.candidate2.Name = "candidate2";
            this.candidate2.Size = new System.Drawing.Size(159, 29);
            this.candidate2.TabIndex = 3;
            this.candidate2.TabStop = true;
            this.candidate2.Text = "Candidate 2";
            this.candidate2.UseVisualStyleBackColor = true;
            // 
            // candidate3
            // 
            this.candidate3.AutoSize = true;
            this.candidate3.Location = new System.Drawing.Point(31, 344);
            this.candidate3.Name = "candidate3";
            this.candidate3.Size = new System.Drawing.Size(159, 29);
            this.candidate3.TabIndex = 4;
            this.candidate3.TabStop = true;
            this.candidate3.Text = "Candidate 3";
            this.candidate3.UseVisualStyleBackColor = true;
            this.candidate3.CheckedChanged += new System.EventHandler(this.candidate3_CheckedChanged);
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.Location = new System.Drawing.Point(26, 35);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(264, 25);
            this.incomelbl.TabIndex = 5;
            this.incomelbl.Text = "Enter Your Yearly Income:";
            // 
            // incomeTXT
            // 
            this.incomeTXT.Location = new System.Drawing.Point(331, 28);
            this.incomeTXT.Name = "incomeTXT";
            this.incomeTXT.Size = new System.Drawing.Size(100, 31);
            this.incomeTXT.TabIndex = 6;
            // 
            // taxRatelbl
            // 
            this.taxRatelbl.AutoSize = true;
            this.taxRatelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.taxRatelbl.Location = new System.Drawing.Point(26, 83);
            this.taxRatelbl.Name = "taxRatelbl";
            this.taxRatelbl.Size = new System.Drawing.Size(157, 25);
            this.taxRatelbl.TabIndex = 7;
            this.taxRatelbl.Text = "Your Tax Rate:";
            // 
            // taxDuelbl
            // 
            this.taxDuelbl.AutoSize = true;
            this.taxDuelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.taxDuelbl.Location = new System.Drawing.Point(274, 83);
            this.taxDuelbl.Name = "taxDuelbl";
            this.taxDuelbl.Size = new System.Drawing.Size(99, 25);
            this.taxDuelbl.TabIndex = 8;
            this.taxDuelbl.Text = "Tax Due:";
            // 
            // taxRate
            // 
            this.taxRate.AutoSize = true;
            this.taxRate.Location = new System.Drawing.Point(183, 83);
            this.taxRate.Name = "taxRate";
            this.taxRate.Size = new System.Drawing.Size(0, 25);
            this.taxRate.TabIndex = 9;
            // 
            // taxDue
            // 
            this.taxDue.AutoSize = true;
            this.taxDue.Location = new System.Drawing.Point(373, 83);
            this.taxDue.Name = "taxDue";
            this.taxDue.Size = new System.Drawing.Size(0, 25);
            this.taxDue.TabIndex = 10;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(279, 265);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(229, 108);
            this.calButton.TabIndex = 11;
            this.calButton.Text = "Tax Me!";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // Prog2
            // 
            this.AcceptButton = this.calButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.taxDue);
            this.Controls.Add(this.taxRate);
            this.Controls.Add(this.taxDuelbl);
            this.Controls.Add(this.taxRatelbl);
            this.Controls.Add(this.incomeTXT);
            this.Controls.Add(this.incomelbl);
            this.Controls.Add(this.candidate3);
            this.Controls.Add(this.candidate2);
            this.Controls.Add(this.candidate1);
            this.Controls.Add(this.baseLine);
            this.Controls.Add(this.TaxPlans);
            this.Name = "Prog2";
            this.Text = "Prog2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaxPlans;
        private System.Windows.Forms.RadioButton baseLine;
        private System.Windows.Forms.RadioButton candidate1;
        private System.Windows.Forms.RadioButton candidate2;
        private System.Windows.Forms.RadioButton candidate3;
        private System.Windows.Forms.Label incomelbl;
        private System.Windows.Forms.TextBox incomeTXT;
        private System.Windows.Forms.Label taxRatelbl;
        private System.Windows.Forms.Label taxDuelbl;
        private System.Windows.Forms.Label taxRate;
        private System.Windows.Forms.Label taxDue;
        private System.Windows.Forms.Button calButton;
    }
}

