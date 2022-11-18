//R6319
//CIS 199-01
//3/29/2020
//lab7
//star row program



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputStars;//number of stars user inputs

            Write("Enter positive number of desired stars >> ");//user enters number of stars
            int.TryParse(ReadLine(), out inputStars);

            ShowSquareOfStars(inputStars);//name of method and parameter

        }

        public static void ShowSquareOfStars (int numStars)//method with numStars as parameter
        {
            for(int numRow = 1; numRow <= numStars; numRow++)//variables for number of rows
            {
                for(int star = 1; star <= numStars; star++)//variable for number of stars in each row
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}
