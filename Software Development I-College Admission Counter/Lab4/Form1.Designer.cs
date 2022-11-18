namespace Lab4
{
    partial class Lab4
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
            this.GPAlbl = new System.Windows.Forms.Label();
            this.GPAtxt = new System.Windows.Forms.TextBox();
            this.ATSlbl = new System.Windows.Forms.Label();
            this.ATStxt = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.AorRlbl = new System.Windows.Forms.Label();
            this.AorR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AClbl = new System.Windows.Forms.Label();
            this.RClbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GPAlbl
            // 
            this.GPAlbl.AutoSize = true;
            this.GPAlbl.Location = new System.Drawing.Point(150, 50);
            this.GPAlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GPAlbl.Name = "GPAlbl";
            this.GPAlbl.Size = new System.Drawing.Size(397, 25);
            this.GPAlbl.TabIndex = 0;
            this.GPAlbl.Text = "Enter High School Grade Point Average:";
            // 
            // GPAtxt
            // 
            this.GPAtxt.Location = new System.Drawing.Point(598, 50);
            this.GPAtxt.Margin = new System.Windows.Forms.Padding(6);
            this.GPAtxt.Name = "GPAtxt";
            this.GPAtxt.Size = new System.Drawing.Size(196, 31);
            this.GPAtxt.TabIndex = 1;
            // 
            // ATSlbl
            // 
            this.ATSlbl.AutoSize = true;
            this.ATSlbl.Location = new System.Drawing.Point(150, 152);
            this.ATSlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ATSlbl.Name = "ATSlbl";
            this.ATSlbl.Size = new System.Drawing.Size(284, 25);
            this.ATSlbl.TabIndex = 2;
            this.ATSlbl.Text = "Enter Admission Test Score:";
            this.ATSlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // ATStxt
            // 
            this.ATStxt.Location = new System.Drawing.Point(598, 152);
            this.ATStxt.Margin = new System.Windows.Forms.Padding(6);
            this.ATStxt.Name = "ATStxt";
            this.ATStxt.Size = new System.Drawing.Size(196, 31);
            this.ATStxt.TabIndex = 3;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(859, 70);
            this.calButton.Margin = new System.Windows.Forms.Padding(6);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(224, 86);
            this.calButton.TabIndex = 4;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // AorRlbl
            // 
            this.AorRlbl.AutoSize = true;
            this.AorRlbl.Location = new System.Drawing.Point(155, 255);
            this.AorRlbl.Name = "AorRlbl";
            this.AorRlbl.Size = new System.Drawing.Size(230, 25);
            this.AorRlbl.TabIndex = 5;
            this.AorRlbl.Text = "Accepted or Rejected?";
            // 
            // AorR
            // 
            this.AorR.AutoSize = true;
            this.AorR.Location = new System.Drawing.Point(593, 255);
            this.AorR.Name = "AorR";
            this.AorR.Size = new System.Drawing.Size(0, 25);
            this.AorR.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Accepted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rejected:";
            // 
            // AClbl
            // 
            this.AClbl.AutoSize = true;
            this.AClbl.Location = new System.Drawing.Point(301, 344);
            this.AClbl.Name = "AClbl";
            this.AClbl.Size = new System.Drawing.Size(24, 25);
            this.AClbl.TabIndex = 9;
            this.AClbl.Text = "0";
            // 
            // RClbl
            // 
            this.RClbl.AutoSize = true;
            this.RClbl.Location = new System.Drawing.Point(724, 344);
            this.RClbl.Name = "RClbl";
            this.RClbl.Size = new System.Drawing.Size(24, 25);
            this.RClbl.TabIndex = 10;
            this.RClbl.Text = "0";
            // 
            // Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 442);
            this.Controls.Add(this.RClbl);
            this.Controls.Add(this.AClbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AorR);
            this.Controls.Add(this.AorRlbl);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.ATStxt);
            this.Controls.Add(this.ATSlbl);
            this.Controls.Add(this.GPAtxt);
            this.Controls.Add(this.GPAlbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Lab4";
            this.Text = "Lab4";
            this.Load += new System.EventHandler(this.Lab4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GPAlbl;
        private System.Windows.Forms.TextBox GPAtxt;
        private System.Windows.Forms.Label ATSlbl;
        private System.Windows.Forms.TextBox ATStxt;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label AorRlbl;
        private System.Windows.Forms.Label AorR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AClbl;
        private System.Windows.Forms.Label RClbl;
    }
}