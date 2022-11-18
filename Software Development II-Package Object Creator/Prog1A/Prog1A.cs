/*
 * 5166312
 * 9/27/21
 * CIS 200-50
 * Program0 class will display the objects listed below
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    class Program0
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a2, a3, 5, 6, 7, 10.9);//test groundpackage
            NextDayAirPackage ndap1 = new NextDayAirPackage(a3, a4, 30, 35, 10, 90, 6.90M);//test nextdayairpackage
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a2, a4, 50.4, 30, 20, 40, TwoDayAirPackage.Delivery.Early);// test twodayairpackage



            List<Parcel> parcels = new List<Parcel> { l1, l2, l3 }; // Test list of parcels
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            // Display data
            WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }
        }
    }
}

