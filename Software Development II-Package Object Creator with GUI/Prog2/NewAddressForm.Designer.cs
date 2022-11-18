
namespace UPVApp
{
    partial class NewAddressForm
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
            this.AddressNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ZipcodeTextBox = new System.Windows.Forms.TextBox();
            this.StateCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressNameTextBox
            // 
            this.AddressNameTextBox.Location = new System.Drawing.Point(264, 21);
            this.AddressNameTextBox.Name = "AddressNameTextBox";
            this.AddressNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.AddressNameTextBox.TabIndex = 0;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(264, 59);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(241, 20);
            this.AddressTextBox.TabIndex = 1;
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.Location = new System.Drawing.Point(264, 97);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(241, 20);
            this.Address2TextBox.TabIndex = 2;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(264, 134);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(241, 20);
            this.CityTextBox.TabIndex = 3;
            // 
            // ZipcodeTextBox
            // 
            this.ZipcodeTextBox.Location = new System.Drawing.Point(264, 209);
            this.ZipcodeTextBox.Name = "ZipcodeTextBox";
            this.ZipcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipcodeTextBox.TabIndex = 4;
            this.ZipcodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ZipcodeTextBox_Validating);
            this.ZipcodeTextBox.Validated += new System.EventHandler(this.ZipcodeTextBox_Validated);
            // 
            // StateCbo
            // 
            this.StateCbo.FormattingEnabled = true;
            this.StateCbo.Location = new System.Drawing.Point(264, 171);
            this.StateCbo.Name = "StateCbo";
            this.StateCbo.Size = new System.Drawing.Size(121, 21);
            this.StateCbo.TabIndex = 5;
            this.StateCbo.Validating += new System.ComponentModel.CancelEventHandler(this.StateCbo_Validating);
            this.StateCbo.Validated += new System.EventHandler(this.StateCbo_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zipcode:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(264, 274);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(384, 273);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateCbo);
            this.Controls.Add(this.ZipcodeTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.Address2TextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressNameTextBox);
            this.Name = "NewAddressForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox ZipcodeTextBox;
        private System.Windows.Forms.ComboBox StateCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}