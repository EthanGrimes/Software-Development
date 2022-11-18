//R6319
//Lab5
//CIS 199-01
//3/8/20
//temperature loop and mean of temperatures entered




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxTemp = 130;//max temp
            const int minTemp = -20;//min temp
            const int stop = 999;//sentinel value
            int temp;//temperature entered
            int tempCount = 0;//counts number of valid temperatures
            bool valid;//checks if entered value is valid
            double sum = 0;//sum formula
            double mean;//mean formula

            WriteLine("Enter Temperatures from -20 to 130 (999 to stop)");
            Write("Enter Temperature: ");
            valid = int.TryParse(ReadLine(), out temp);

            while (temp != stop)//checks if sentinel value is entered
            {
                if (temp < minTemp || temp > maxTemp || !valid)//checks if value entered falls within parameters
                {
                    WriteLine("Please Re-Enter Temperature");
                  
                }
                else
                {
                    tempCount++;//counts entered temps
                    sum = sum + temp;//calculates the sum
                }
                Write("Enter Temperature: ");
                valid = int.TryParse(ReadLine(), out temp);
            }
            mean = sum / tempCount;//calculates the mean
            WriteLine("You entered {0} valid temperatures", tempCount);
            WriteLine("The mean temperature is {0:F1}", mean);
        }
    }
}
