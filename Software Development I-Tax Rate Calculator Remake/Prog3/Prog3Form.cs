﻿// Program 3
//R6319
//CIS 199-01
//4/2/2020
// This application calculates the marginal tax rate
// for various candidates' tax plans.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        public Prog3Form()
        {
            InitializeComponent();
        }

        // User has clicked the Calculate Tax button
        // Will calculate and display their marginal tax rate
        private void calcTaxBtn_Click(object sender, EventArgs e)
        {

                   
            // The marginal tax rates
            // Baseline
            const decimal BASE_RATE1 = .10m; // 1st tax rate (LOWEST)
            const decimal BASE_RATE2 = .12m; // 2nd tax rate
            const decimal BASE_RATE3 = .22m; // 3rd tax rate
            const decimal BASE_RATE4 = .24m; // 4th tax rate
            const decimal BASE_RATE5 = .32m; // 5th tax rate
            const decimal BASE_RATE6 = .35m; // 6th tax rate
            const decimal BASE_RATE7 = .37m; // 7th tax rate (HIGHEST)

           


            // Candidate 2
            const decimal C2_RATE1 = .10m;  // 1st tax rate (LOWEST)
            const decimal C2_RATE2 = .12m;  // 2nd tax rate
            const decimal C2_RATE3 = .22m;  // 3rd tax rate
            const decimal C2_RATE4 = .24m;  // 4th tax rate
            const decimal C2_RATE5 = .32m;  // 5th tax rate
            const decimal C2_RATE6 = .35m;  // 6th tax rate
            const decimal C2_RATE7 = .40m;  // 7th tax rate
            const decimal C2_RATE8 = .45m;  // 8th tax rate
            const decimal C2_RATE9 = .50m;  // 9th tax rate
            const decimal C2_RATE10 = .52m; // 10th tax rate (HIGHEST)

            // Taxable income thresholds for each candidate
            // Baseline
            const int BASE_THRESH0 = 0;
            const int BASE_THRESH1 = 9_700;   // 1st baseline threshold (LOWEST)
            const int BASE_THRESH2 = 39_475;  // 2nd baseline threshold
            const int BASE_THRESH3 = 84_200;  // 3rd baseline threshold
            const int BASE_THRESH4 = 160_725; // 4th baseline threshold
            const int BASE_THRESH5 = 204_100; // 5th baseline threshold
            const int BASE_THRESH6 = 510_300; // 6th baseline threshold (HIGHEST)

            // Candidate 2
            const int C2_THRESH0 = 0;
            const int C2_THRESH1 = 9_525;     // 1st threshold (LOWEST)
            const int C2_THRESH2 = 38_700;    // 2nd threshold
            const int C2_THRESH3 = 82_500;    // 3rd threshold
            const int C2_THRESH4 = 157_500;   // 4th threshold
            const int C2_THRESH5 = 200_000;   // 5th threshold
            const int C2_THRESH6 = 250_000;   // 6th threshold
            const int C2_THRESH7 = 500_000;   // 7th threshold
            const int C2_THRESH8 = 2_000_000;  // 8th threshold
            const int C2_THRESH9 = 10_000_000; // 9th threshold (HIGHEST)

            decimal[] baseRates={ BASE_RATE1,BASE_RATE2,BASE_RATE3,BASE_RATE4,BASE_RATE5,BASE_RATE6,BASE_RATE7};//string for base rates
            int[] baseThresh={ BASE_THRESH1,BASE_THRESH2,BASE_THRESH3,BASE_THRESH4,BASE_THRESH5,BASE_THRESH6};//string for base thresholds

            decimal[] candRates={ C2_RATE1, C2_RATE2, C2_RATE3,C2_RATE4 ,C2_RATE5,C2_RATE6,C2_RATE7,C2_RATE8,C2_RATE9,C2_RATE10};//string for candidate 2 rates
            int[] candThresh={ C2_THRESH1, C2_THRESH2,C2_THRESH3,C2_THRESH4,C2_THRESH5,C2_THRESH6,C2_THRESH7,C2_THRESH8,C2_THRESH9};//string for candidate thresholds

            bool found=false;//bool logic if income>baseRate.Length

            
            int income; // Filer's taxable income (input)

            // Income rates that apply to this filer
            decimal rate1 = 0;  // Tax rate 1
            decimal rate2 = 0;  // Tax rate 2
            decimal rate3 = 0;  // Tax rate 3
            decimal rate4 = 0;  // Tax rate 4
            decimal rate5 = 0;  // Tax rate 5
            decimal rate6 = 0;  // Tax rate 6
            decimal rate7 = 0;  // Tax rate 7
            decimal rate8 = 0;  // Tax rate 8
            decimal rate9 = 0;  // Tax rate 9
            decimal rate10 = 0; // Tax rate 10

            // Income threshold values that apply to this filer
            int threshold1 = int.MaxValue; // 1st income threshold
            int threshold2 = int.MaxValue; // 2nd income threshold
            int threshold3 = int.MaxValue; // 3rd income threshold
            int threshold4 = int.MaxValue; // 4th income threshold
            int threshold5 = int.MaxValue; // 5th income threshold
            int threshold6 = int.MaxValue; // 6th income threshold
            int threshold7 = int.MaxValue; // 7th income threshold
            int threshold8 = int.MaxValue; // 8th income threshold
            int threshold9 = int.MaxValue; // 9th income threshold

            decimal marginalRate; // Filer's calculated marginal tax rate

            if (int.TryParse(incomeTxt.Text, out income) && income >= 0)
            {
                // Which rates/thresholds apply to this filer?
                if (baselineRdoBtn.Checked) // Baseline?
                {
                    int index = baseThresh.Length-1;//reads baseThresh backwards

                    rate1 = BASE_RATE1;
                    rate2 = BASE_RATE2;
                    rate3 = BASE_RATE3;
                    rate4 = BASE_RATE4;
                    rate5 = BASE_RATE5;
                    rate6 = BASE_RATE6;
                    rate7 = BASE_RATE7;

                    threshold1 = BASE_THRESH1;
                    threshold2 = BASE_THRESH2;
                    threshold3 = BASE_THRESH3;
                    threshold4 = BASE_THRESH4;
                    threshold5 = BASE_THRESH5;
                    threshold6 = BASE_THRESH6;

                    while (index >= 0 && !found)//searches the baseThresh
                    {
                        if(income>baseThresh[index])
                        {
                            found = true;
                        }
                        else
                        {
                            index--;
                        }
                    }
                    if (found)
                        marginalRate = baseRates[index];
                }
                else // Must be Candidate 2
                {
                    int index = candThresh.Length - 1;//reads candThresh backwards

                    rate1 = C2_RATE1;
                    rate2 = C2_RATE2;
                    rate3 = C2_RATE3;
                    rate4 = C2_RATE4;
                    rate5 = C2_RATE5;
                    rate6 = C2_RATE6;
                    rate7 = C2_RATE7;
                    rate8 = C2_RATE8;
                    rate9 = C2_RATE9;
                    rate10 = C2_RATE10;

                    threshold1 = C2_THRESH1;
                    threshold2 = C2_THRESH2;
                    threshold3 = C2_THRESH3;
                    threshold4 = C2_THRESH4;
                    threshold5 = C2_THRESH5;
                    threshold6 = C2_THRESH6;
                    threshold7 = C2_THRESH7;
                    threshold8 = C2_THRESH8;
                    threshold9 = C2_THRESH9;

                    while (index >= 0 && !found)//checks to see if value is in candThresh
                    {
                        if (income > candThresh[index])
                        {
                            found = true;
                        }
                        else
                        {
                            index--;
                        }
                    }
                    if (found)
                        marginalRate = candRates[index];
                }

                // Calculate income tax due and find their marginal rate
                if (income > threshold9)
                {
                    marginalRate = rate10;
                }
                else if (income > threshold8)
                {
                    marginalRate = rate9;
                }
                else if (income > threshold7)
                {
                    marginalRate = rate8;
                }
                else if (income > threshold6)
                {
                    marginalRate = rate7;
                }
                else if (income > threshold5)
                {
                    marginalRate = rate6;
                }
                else if (income > threshold4)
                {
                    marginalRate = rate5;
                }
                else if (income > threshold3)
                {
                    marginalRate = rate4;
                }
                else if (income > threshold2)
                {
                    marginalRate = rate3;
                }
                else if (income > threshold1)
                {
                    marginalRate = rate2;
                }
                else
                {
                    marginalRate = rate1;
                }

                // Output results
                marginalRateOutLbl.Text = $"{marginalRate:P1}";
            }
            else // Invalid input
                MessageBox.Show("Enter valid income!");
        }
    }
}
