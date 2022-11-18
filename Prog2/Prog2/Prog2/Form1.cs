//R6319
//CIS199-01
//Program2
//3/5/2020
//Form that calculates tax rate and taxes due



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Prog2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }
        private void calButton_Click(object sender, EventArgs e)
        {
            int income;//number entered into text box
            double amtDue;//equation to calculate tax amount due
           

            income = Convert.ToInt32(incomeTXT.Text);//accepts input from user

            if (baseLine.Checked == true)//baseline radio button
            {
                int range1 = 9700;//range for baseline plan
                
                int range2 = 39475;//range for baseline plan
              
                int range3 = 84200;//range for baseline plan
                
                int range4 = 160725;//range for baseline plan
                
                int range5 = 204100;//range for baseline plan
                
                int range6 = 510300;//range for baseline plan

                double rate1 = .1;//baseline tax rate
                double rate2 = .12;//baseline tax rate
                double rate3 = .22;//baseline tax rate
                double rate4 = .24;//baseline tax rate
                double rate5 = .32;//baseline tax rate
                double rate6 = .35;//baseline tax rate
                double rate7 = .37;//baseline tax rate

                if (income <= range1)
                {
                    taxRate.Text = $"{rate1:P}";
                    amtDue = income * rate1;
                    incomeTXT.Focus();
                }
                else if (income<=range2)
                {
                    taxRate.Text = $"{rate2:P}";
                    amtDue = (income-range1) * rate2+(range1*rate1);
                    incomeTXT.Focus();
                }
                 else if (income <=range3)
                {
                    taxRate.Text = $"{rate3:P}";
                    amtDue = (income - range2) * rate3 + ((range2 - range1)* rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
               else if (income <=range4)
                {
                    taxRate.Text = $"{rate4:P}";
                    amtDue = (income - range3) * rate4 + ((range3-range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
               else if (income <=range5)
                {
                    taxRate.Text = $"{rate5:P}";
                    amtDue = (income - range4) * rate5 + ((range4-range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);

                    incomeTXT.Focus();
                }
               else if (income <=range6)
                {
                    taxRate.Text = $"{rate6:P}";
                    amtDue = (income - range5) * rate6 + ((range5-range4)* rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
                else
                {
                    taxRate.Text = $"{rate7:P}";
                    amtDue = (income - range6) * rate7 + ((range6-range5) * rate6) + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2)+(range1*rate1);
                    incomeTXT.Focus();
                }
                taxDue.Text = $"{amtDue:C2}";
            }  



            if (candidate1.Checked == true)//candidate1 radio button
            {
                int range1 = 9525;//range for candidate1 plan
              
                int range2 = 38700;//range for candidate1 plan
                
                int range3 = 82500;//range for candidate1 plan
                
                int range4 = 157500;//range for candidate1 plan
               
                int range5 = 200000;//range for candidate1 plan
               
                int range6 = 500000;//range for candidate1 plan

                double rate1 = .1;//candidate1 tax rate
                double rate2 = .15;//candidate1 tax rate
                double rate3 = .25;//candidate1 tax rate
                double rate4 = .28;//candidate1 tax rate
                double rate5 = .33;//candidate1 tax rate
                double rate6 = .35;//candidate1 tax rate
                double rate7 = .396;//candidate1 tax rate



                if (income <= range1)
                {
                    taxRate.Text = $"{rate1:P}";
                    amtDue = income * rate1;
                    incomeTXT.Focus();
                }
                else if (income <= range2)
                {
                    taxRate.Text = $"{rate2:P}";
                    amtDue = (income - range1) * rate2 + (range1 * rate1);
                    incomeTXT.Focus();
                }
                else if (income <= range3)
                {
                    taxRate.Text = $"{rate3:P}";
                    amtDue = (income - range2) * rate3 + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
                else if (income <= range4)
                {
                    taxRate.Text = $"{rate4:P}";
                    amtDue = (income - range3) * rate4 + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
                else if (income <= range5)
                {
                    taxRate.Text = $"{rate5:P}";
                    amtDue = (income - range4) * rate5 + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);

                    incomeTXT.Focus();
                }
                else if (income <= range6)
                {
                    taxRate.Text = $"{rate6:P}";
                    amtDue = (income - range5) * rate6 + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
                else
                {
                    taxRate.Text = $"{rate7:P}";
                    amtDue = (income - range6) * rate7 + ((range6 - range5) * rate6) + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    incomeTXT.Focus();
                }
                taxDue.Text = $"{amtDue:C2}";
            }

            if (candidate2.Checked == true)//candidate2 radio button
            {
                int range1 = 9525;//range for candidate2 plan
              
                int range2 = 38700;//range for candidate2 plan
               
                int range3 = 82500;//range for candidate2 plan
                
                int range4 = 157500;//range for candidate2 plan
               
                int range5 = 200000;//range for candidate2 plan
               
                int range6 = 250000;//range for candidate2 plan
               
                int range7 = 500000;//range for candidate2 plan
                
                int range8 = 2000000;//range for candidate2 plan
              
                int range9 = 10000000;//range for candidate2 plan

                double rate1 = .1;//candidate2 tax rate
                double rate2 = .12;//candidate2 tax rate
                double rate3 = .22;//candidate2 tax rate
                double rate4 = .24;//candidate2 tax rate
                double rate5 = .32;//candidate2 tax rate
                double rate6 = .35;//candidate2 tax rate
                double rate7 = .40;//candidate2 tax rate
                double rate8 = .45;//candidate2 tax rate
                double rate9 = .50;//candidate2 tax rate
                double rate10 = .52;//candidate2 tax rate

                double increase = .04;//4% increase to tax
                double range = 29000;//range for 4% tax increase

                if (income <= range1)
                {
                    taxRate.Text = $"{rate1:P}";
                    amtDue = income * rate1;
                    incomeTXT.Focus();
                }
                else if (income <= range2)
                {
                   
                    taxRate.Text = $"{rate2:P}";
                    amtDue = (income - range1) * rate2 + (range1 * rate1);
                    
                    if (income > range)
                    {
                        amtDue = amtDue + ((income - range) * increase);
                    }
                    incomeTXT.Focus();
                }
                else if (income <= range3)
                {
                    taxRate.Text = $"{rate3:P}";
                    amtDue = (income - range2) * rate3  + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue = amtDue +((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if (income <= range4)
                {
                    taxRate.Text = $"{rate4:P}";
                    amtDue = (income - range3) * rate4 + ((range3 - range2) * rate3 ) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if (income <= range5)
                {
                    taxRate.Text = $"{rate5:P}";
                    amtDue = (income - range4) * rate5  + ((range4 - range3) * rate4 ) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if (income <= range6)
                {
                    taxRate.Text = $"{rate6:P}";
                    amtDue = (income - range5) * rate6  + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if (income<=range7)
                {
                    taxRate.Text = $"{rate7:P}";
                    amtDue = (income - range6) * rate7  + ((range6 - range5) * rate6) + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2-range1)*rate2) +(range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if(income<=range8)
                {
                    taxRate.Text = $"{rate8:P}";
                    amtDue = (income-range7)*rate8  + (range7 - range6) * rate7 + ((range6 - range5) * rate6) + ((range5 - range4) * rate5) + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else if(income<=range9)
                {
                    taxRate.Text = $"{rate9:P}";
                    amtDue = (income - range8) * rate9 + (range8 - range7) * rate8 + (range7 - range6) * rate7 + (range6 - range5) * rate6 + (range5 - range4) * rate5 + (range4 - range3) * rate4 + (range3 - range2) * rate3 + (range2 - range1) * rate2 + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                else
                {
                    taxRate.Text = $"{rate10:P}";
                    amtDue = (income-range9)*rate10  + (range9 - range8) * rate9 + (range8 - range7) * rate8 + (range7 - range6) * rate7  + (range6 - range5) * rate6  + (range5 - range4) * rate5 + (range4 - range3) * rate4  + (range3 - range2) * rate3 + (range2 - range1) * rate2 + (range1 * rate1);
                    amtDue = amtDue + ((income - range) * increase);
                    incomeTXT.Focus();
                }
                taxDue.Text = $"{amtDue:C2}";
            }

            if (candidate3.Checked == true)//candidate3 radio button
            {
                int range1 = 9525;//range for candidate3 plan
               
                int range2 = 38700;//range for candidate3 plan
                
                int range3 = 82500;//range for candidate3 plan
              
                int range4 = 157500;//range for candidate3 plan
                
                int range5 = 200000;//range for candidate3 plan
                
                int range6 = 500000;//range for candidate3 plan

                double rate1 = .1;//candidate3 tax rate
                double rate2 = .15;//candidate3 tax rate
                double rate3 = .25;//candidate3 tax rate
                double rate4 = .28;//candidate3 tax rate
                double rate5 = .33;//candidate3 tax rate
                double rate6 = .35;//candidate3 tax rate
                double rate7 = .396;//candidate3 tax rate

                double reduction = .9;//10% reduction in taxes

                if (income <= range1)
                {
                    taxRate.Text = $"{rate1:P}";
                    amtDue = income * rate1;
                    amtDue *= reduction;
                    incomeTXT.Focus();
                }
                else if (income <= range2)
                {
                    taxRate.Text = $"{rate2:P}";
                    amtDue = (income - range1) * rate2 + (range1 * rate1);
                    amtDue *= reduction;
                    incomeTXT.Focus();
                }
                else if (income <= range3)
                {
                    taxRate.Text = $"{rate3:P}";
                    amtDue = (income - range2) * rate3 + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue *= reduction;
                    incomeTXT.Focus();
                }
                else if (income <= range4)
                {
                    taxRate.Text = $"{rate4:P}";
                    amtDue = (income - range3) * rate4 + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue *= reduction;
                    incomeTXT.Focus();
                }
                else if (income <= range5)
                {
                    taxRate.Text = $"{rate5:P}";
                    amtDue = (income - range4) * rate5 + ((range4 - range3) * rate4) + ((range3 - range2) * rate3) + ((range2 - range1) * rate2) + (range1 * rate1);
                    amtDue *= reduction;
                    incomeTXT.Focus();
                }
                else if (income <= range6)
                {
                    taxRate.Text = $"{rate6:P}";
                    amtDue = (income - range5) * rate6 + ((range5 - range4) * rate5*reduction) + ((range4 - range3) * rate4* reduction) + ((range3 - range2) * rate3* reduction) + ((range2 - range1) * rate2* reduction) + (range1 * rate1* reduction);
                    incomeTXT.Focus();
                }
                else
                {
                    taxRate.Text = $"{rate7:P}";
                    amtDue = (income - range6) * rate7 + ((range6 - range5) * rate6) + ((range5 - range4) * rate5* reduction) + ((range4 - range3) * rate4* reduction) + ((range3 - range2) * rate3* reduction) + ((range2 - range1) * rate2* reduction) + (range1 * rate1* reduction);
                    incomeTXT.Focus();
                }
                taxDue.Text = $"{amtDue:C2}";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void candidate3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
