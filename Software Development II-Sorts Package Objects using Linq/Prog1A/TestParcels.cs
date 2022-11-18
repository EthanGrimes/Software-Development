//Program 4
//5166312
//12/2/21
//CIS 200-50
//Sorting Program uses various criteria to sort

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a4, 30, 40, 45,    // Next Day test object
                70, 8.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a4, a3, 50.5, 20.5, 30.0, // Two Day test object
                50.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a3, a1, 100.5, 60.5, 10.0, // Two Day test object
                45.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            WriteLine("Original List:");//original list sort
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort();//sort by cost (ascending)
            WriteLine("Ascending by Cost:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            WriteLine("Original List:");//original list
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescendingZip());//sorts by descending zipcode
            WriteLine("Sorted List (Descending)");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            WriteLine("Original List:");//original list
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(new ParcelTypeCostSort());//sorts by type and cost
            WriteLine("Type and Cost Sort:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
