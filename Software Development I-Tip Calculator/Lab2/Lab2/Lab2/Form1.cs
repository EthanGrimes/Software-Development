//R6319
//CIS 199-01
//2/2/2020
//Program creates a tip calculator



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double meal;//meal price
            double tipRate1 = .15;//15% tip
            double tipRate2 = .18;//18% tip
            double tipRate3 = .20;//20% tip
            double product1;//meal price*15%
            double product2;//meal price*18%
            double product3;//meal price*20%

            meal = Convert.ToDouble(txtMeal.Text);//receives input form the textbox
            product1 = meal * tipRate1;
            lblOut1.Text = $"{product1:C2}";//displays the amount next to the 15% label
            product2 = meal * tipRate2;
            lblOut2.Text = $"{product2:C2}";//displays the amount next to the 18% label
            product3 = meal * tipRate3;
            lblOut3.Text = $"{product3:C2}";//displays the amount next to the 18% label

        }
    }
}
