
namespace UPVApp
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.OriginAddress = new System.Windows.Forms.Label();
            this.DestinationAddress = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.OriginAddCbo = new System.Windows.Forms.ComboBox();
            this.DestinationAddCbo = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginAddress
            // 
            this.OriginAddress.AutoSize = true;
            this.OriginAddress.Location = new System.Drawing.Point(265, 52);
            this.OriginAddress.Name = "OriginAddress";
            this.OriginAddress.Size = new System.Drawing.Size(75, 13);
            this.OriginAddress.TabIndex = 0;
            this.OriginAddress.Text = "Origin Address";
            // 
            // DestinationAddress
            // 
            this.DestinationAddress.AutoSize = true;
            this.DestinationAddress.Location = new System.Drawing.Point(265, 92);
            this.DestinationAddress.Name = "DestinationAddress";
            this.DestinationAddress.Size = new System.Drawing.Size(101, 13);
            this.DestinationAddress.TabIndex = 1;
            this.DestinationAddress.Text = "Destination Address";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(265, 134);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(28, 13);
            this.Cost.TabIndex = 2;
            this.Cost.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(384, 131);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 3;
            this.CostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CostTextBox_Validating);
            this.CostTextBox.Validated += new System.EventHandler(this.CostTextBox_Validated);
            // 
            // OriginAddCbo
            // 
            this.OriginAddCbo.FormattingEnabled = true;
            this.OriginAddCbo.Location = new System.Drawing.Point(384, 44);
            this.OriginAddCbo.Name = "OriginAddCbo";
            this.OriginAddCbo.Size = new System.Drawing.Size(121, 21);
            this.OriginAddCbo.TabIndex = 4;
            this.OriginAddCbo.Validating += new System.ComponentModel.CancelEventHandler(this.OriginAddCbo_Validating_1);
            this.OriginAddCbo.Validated += new System.EventHandler(this.OriginAddCbo_Validated);
            // 
            // DestinationAddCbo
            // 
            this.DestinationAddCbo.FormattingEnabled = true;
            this.DestinationAddCbo.Location = new System.Drawing.Point(384, 84);
            this.DestinationAddCbo.Name = "DestinationAddCbo";
            this.DestinationAddCbo.Size = new System.Drawing.Size(121, 21);
            this.DestinationAddCbo.TabIndex = 5;
            this.DestinationAddCbo.Validating += new System.ComponentModel.CancelEventHandler(this.DestinationAddCbo_Validating);
            this.DestinationAddCbo.Validated += new System.EventHandler(this.DestinationAddCbo_Validated);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(268, 206);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(441, 206);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DestinationAddCbo);
            this.Controls.Add(this.OriginAddCbo);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.DestinationAddress);
            this.Controls.Add(this.OriginAddress);
            this.Name = "LetterForm";
            this.Text = "Letter Form";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginAddress;
        private System.Windows.Forms.Label DestinationAddress;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.ComboBox OriginAddCbo;
        private System.Windows.Forms.ComboBox DestinationAddCbo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}