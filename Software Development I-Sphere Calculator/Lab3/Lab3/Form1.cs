// R6319
// CIS 199-01
// 02/09/2020
// calculator that determines diameter, surface area, and volume of a sphere


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius;//Radius of the sphere
            double diameter;//Diameter of the sphere
            double SArea;//Surface area of the sphere
            double volume;//Volume of the sphere

            radius = Convert.ToDouble(Radiustxt.Text);//Accepts input in the text box
            diameter = 2 * radius;//equation for the diameter
            SArea = 4 * Math.PI * Math.Pow(radius, 2);//equation for the surface area
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;//equation for the volume
            Diamlbl.Text = $"{diameter:F2}";//displays output in the label Diamlbl
            SAlbl.Text = $"{SArea:F2}";//displays output in the label SAlbl
            VOLlbl.Text = $"{volume:F2}";//displays output in the label VOLlbl

        }

        private void Diamlbl_Click(object sender, EventArgs e)
        {

        }

        private void Lab3_Load(object sender, EventArgs e)
        {

        }
    }
}
