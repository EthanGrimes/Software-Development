//R6319
//CIS 199-01
//Program 1
//2-11-2020
//Carpet Calculator



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;//width of the room
            double length;//length of the room
            double price;//price of the carpet
            int layers;//number of layers
            int room;//first or second room
            double area;//area in sq_yd
            const int yard = 9;//conversion number from feet into yds
            const double first = 75.00;//first room price
            double CCost;//carpet cost
            const double Extra=.10;//waste percentage
            double PCost;//padding cost
            double padding = 2.50;//cost for each layer of padding
            double LCost = 4.25;//labor cost for each sq_yd of carpet
            double labor;//total labor cost
            double total;//total cost of the job

            
            


            WriteLine("Welcome to Your Carpet Estimator!");

            WriteLine("Please Enter the Max Width: ");
            double.TryParse(ReadLine(), out width);
            WriteLine("Please Enter the Max Length: ");
            double.TryParse(ReadLine(), out length);

            area = (width * length) / yard;//area formula

            WriteLine("Please Enter the Price of the Carpet: ");
            double.TryParse(ReadLine(), out price);

            CCost = (area * price) + (area * price * Extra);//carpet cost formula

            WriteLine("Layers of Padding to Use (1 or 2): ");
            int.TryParse(ReadLine(), out layers);

            if (layers == 1)//if statement for layers of padding
                PCost=(area * padding) + (area * padding * Extra);//padding cost formula for one layer
            else
                PCost = (area * (2 * padding)) + (area * (2 * padding) * Extra);//padding cost formula for two layers


            WriteLine("Is this the First Room?(1=Yes,0=No): ");
            int.TryParse(ReadLine(), out room);


            if (room == 0)//if statement for first room
                labor = area * LCost;//labor cost formula for rooms other than the first
            else
                labor = (area * LCost) + first;//labor cost formula for the first room


            WriteLine("Sq_Yds needed: {0:f1}", area);
            WriteLine("Carpet Cost: {0:C2}", CCost);
            WriteLine("Padding Cost: {0:C2}", PCost);
            WriteLine("Labor Cost: {0:C2}", labor);

            total = CCost + PCost + labor;//total cost equation
            WriteLine("Total Cost: {0:C2}", total);
           

















        }
    }
}
