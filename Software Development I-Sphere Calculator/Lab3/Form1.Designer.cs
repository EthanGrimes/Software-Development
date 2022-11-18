namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.Radius = new System.Windows.Forms.Label();
            this.Diameter = new System.Windows.Forms.Label();
            this.SurfaceArea = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.Diamlbl = new System.Windows.Forms.Label();
            this.SAlbl = new System.Windows.Forms.Label();
            this.VOLlbl = new System.Windows.Forms.Label();
            this.Radiustxt = new System.Windows.Forms.TextBox();
            this.calbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(173, 44);
            this.Radius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(92, 13);
            this.Radius.TabIndex = 0;
            this.Radius.Text = "Radius of Sphere:";
            // 
            // Diameter
            // 
            this.Diameter.AutoSize = true;
            this.Diameter.Location = new System.Drawing.Point(37, 180);
            this.Diameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(49, 13);
            this.Diameter.TabIndex = 1;
            this.Diameter.Text = "Diameter";
            // 
            // SurfaceArea
            // 
            this.SurfaceArea.AutoSize = true;
            this.SurfaceArea.Location = new System.Drawing.Point(37, 238);
            this.SurfaceArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurfaceArea.Name = "SurfaceArea";
            this.SurfaceArea.Size = new System.Drawing.Size(69, 13);
            this.SurfaceArea.TabIndex = 2;
            this.SurfaceArea.Text = "Surface Area";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(37, 290);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(42, 13);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // Diamlbl
            // 
            this.Diamlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Diamlbl.Location = new System.Drawing.Point(110, 178);
            this.Diamlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diamlbl.Name = "Diamlbl";
            this.Diamlbl.Size = new System.Drawing.Size(76, 15);
            this.Diamlbl.TabIndex = 4;
            this.Diamlbl.Click += new System.EventHandler(this.Diamlbl_Click);
            // 
            // SAlbl
            // 
            this.SAlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SAlbl.Location = new System.Drawing.Point(110, 236);
            this.SAlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SAlbl.Name = "SAlbl";
            this.SAlbl.Size = new System.Drawing.Size(76, 15);
            this.SAlbl.TabIndex = 5;
            // 
            // VOLlbl
            // 
            this.VOLlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VOLlbl.Location = new System.Drawing.Point(110, 290);
            this.VOLlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VOLlbl.Name = "VOLlbl";
            this.VOLlbl.Size = new System.Drawing.Size(76, 13);
            this.VOLlbl.TabIndex = 6;
            // 
            // Radiustxt
            // 
            this.Radiustxt.Location = new System.Drawing.Point(269, 44);
            this.Radiustxt.Margin = new System.Windows.Forms.Padding(2);
            this.Radiustxt.Name = "Radiustxt";
            this.Radiustxt.Size = new System.Drawing.Size(52, 20);
            this.Radiustxt.TabIndex = 7;
            // 
            // calbutton
            // 
            this.calbutton.Location = new System.Drawing.Point(213, 83);
            this.calbutton.Margin = new System.Windows.Forms.Padding(2);
            this.calbutton.Name = "calbutton";
            this.calbutton.Size = new System.Drawing.Size(74, 27);
            this.calbutton.TabIndex = 8;
            this.calbutton.Text = "Calculate";
            this.calbutton.UseVisualStyleBackColor = true;
            this.calbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(235, 211);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Lab3
            // 
            this.AcceptButton = this.calbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calbutton);
            this.Controls.Add(this.Radiustxt);
            this.Controls.Add(this.VOLlbl);
            this.Controls.Add(this.SAlbl);
            this.Controls.Add(this.Diamlbl);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.SurfaceArea);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.Radius);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lab3";
            this.Text = "Lab3";
            this.Load += new System.EventHandler(this.Lab3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Diameter;
        private System.Windows.Forms.Label SurfaceArea;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label Diamlbl;
        private System.Windows.Forms.Label SAlbl;
        private System.Windows.Forms.Label VOLlbl;
        private System.Windows.Forms.TextBox Radiustxt;
        private System.Windows.Forms.Button calbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}