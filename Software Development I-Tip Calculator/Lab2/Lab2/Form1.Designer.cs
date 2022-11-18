namespace Lab2
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
            this.mealLabel = new System.Windows.Forms.Label();
            this.tipFifteen = new System.Windows.Forms.Label();
            this.tipEighteen = new System.Windows.Forms.Label();
            this.tipTwenty = new System.Windows.Forms.Label();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblOut3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(223, 43);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(200, 25);
            this.mealLabel.TabIndex = 0;
            this.mealLabel.Text = "Enter Price of meal:";
            // 
            // tipFifteen
            // 
            this.tipFifteen.AutoSize = true;
            this.tipFifteen.Location = new System.Drawing.Point(321, 98);
            this.tipFifteen.Name = "tipFifteen";
            this.tipFifteen.Size = new System.Drawing.Size(55, 25);
            this.tipFifteen.TabIndex = 1;
            this.tipFifteen.Text = "15%";
            // 
            // tipEighteen
            // 
            this.tipEighteen.AutoSize = true;
            this.tipEighteen.Location = new System.Drawing.Point(321, 159);
            this.tipEighteen.Name = "tipEighteen";
            this.tipEighteen.Size = new System.Drawing.Size(55, 25);
            this.tipEighteen.TabIndex = 2;
            this.tipEighteen.Text = "18%";
            // 
            // tipTwenty
            // 
            this.tipTwenty.AutoSize = true;
            this.tipTwenty.Location = new System.Drawing.Point(321, 228);
            this.tipTwenty.Name = "tipTwenty";
            this.tipTwenty.Size = new System.Drawing.Size(55, 25);
            this.tipTwenty.TabIndex = 3;
            this.tipTwenty.Text = "20%";
            // 
            // txtMeal
            // 
            this.txtMeal.Location = new System.Drawing.Point(427, 43);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.Size = new System.Drawing.Size(100, 31);
            this.txtMeal.TabIndex = 4;
            // 
            // lblOut1
            // 
            this.lblOut1.AutoSize = true;
            this.lblOut1.Location = new System.Drawing.Point(427, 98);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(0, 25);
            this.lblOut1.TabIndex = 5;
            // 
            // lblOut2
            // 
            this.lblOut2.AutoSize = true;
            this.lblOut2.Location = new System.Drawing.Point(427, 159);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(0, 25);
            this.lblOut2.TabIndex = 6;
            // 
            // lblOut3
            // 
            this.lblOut3.AutoSize = true;
            this.lblOut3.Location = new System.Drawing.Point(427, 228);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(0, 25);
            this.lblOut3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Tip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOut3);
            this.Controls.Add(this.lblOut2);
            this.Controls.Add(this.lblOut1);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.tipTwenty);
            this.Controls.Add(this.tipEighteen);
            this.Controls.Add(this.tipFifteen);
            this.Controls.Add(this.mealLabel);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label tipFifteen;
        private System.Windows.Forms.Label tipEighteen;
        private System.Windows.Forms.Label tipTwenty;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblOut3;
        private System.Windows.Forms.Button button1;
    }
}