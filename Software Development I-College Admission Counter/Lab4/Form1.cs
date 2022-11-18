//R6319
//Lab 4
//CIS 199-01
//2/16/2020
//Program makes simple Admission decisions based on rules


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4 : Form
    {
        int ACount = 1;//Accepted forms count
        int RCount = 1;//Rejected forms count
        int Count;//counts how many times a form has been rejected or accepted
        string box_msg = "Please Enter a Valid Number for GPA";//error message for GPA
        string box_title = "Error";//message title
        string box_msg2 = "Please Enter a Valid Number for Test Score";//error message for ATS
        string box_title2 = "Error";//error message


        public Lab4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calButton_Click(object sender, EventArgs e)
        {
            const double AVG = 3.0;//GPA rule for both criteria
            const double SCORE1 = 60;//Admission test score for criteria 1
            const double SCORE2 = 80;//Admission test score for criteria 2
            double gpa;//high school gpa
            double ats;//test admission score
           



            gpa = Convert.ToDouble(GPAtxt.Text);
            ats= Convert.ToDouble(ATStxt.Text);

            if (gpa < 0.0 || gpa > 4.0)
            {
                MessageBox.Show(box_msg, box_title);
            }
            else if(ats < 0 || ats > 100)
            {
                MessageBox.Show(box_msg2, box_title2);
            }
           else if(gpa >= AVG && ats >= SCORE1)
            {
                AorR.Text = "Accepted";
                Count = ACount++;
                AClbl.Text = Count.ToString();
                GPAtxt.Focus();
            }
            else if (gpa < AVG && ats >= SCORE2)
            {
                AorR.Text = "Accepted";
                Count = ACount++;
                AClbl.Text = Count.ToString();
                GPAtxt.Focus();
            }
            else
            {
                AorR.Text = "Rejected";
                Count = RCount++;
                RClbl.Text = Count.ToString();
                GPAtxt.Focus();
            }

            

            
               

        }

        private void Lab4_Load(object sender, EventArgs e)
        {

        }
    }
}
