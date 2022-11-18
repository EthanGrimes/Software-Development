using System;
using static System.Console;
using System.Collections.Generic;

// 5166312
// Program 0
// CIS 200-50
// 9/9/21
// Program 0 creates a list of parcels and displays the name, cost, origin and destination addresses obtained from Address, Parcel, and Letter




namespace Prog0
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Arnold Palmer", "9865 Golf Drive", "Apt.6", "Las Vegas", "NV", 32987);//address object containing the values for the variables in Address
            Address a2 = new Address("Ethan Grimes", "8843 Valley Circle Street", " ", "Florence", "KY", 41042);//address object containing the values for the variables in Address
            Address a3 = new Address("Zach Taylor", "900 Plain Circle", " ", "Louisville", "KY", 40208);//address object containing the values for the variables in Address
            Address a4 = new Address(" Mike Oxmaul", "5743 Anywhere Court", "Apt.32", "Cleveland", "OH", 76321);//address object containing the values for the variables in Address

            Letter l1 = new Letter(a2, a3, 3.50M);// origin address is a2, destination address is a3, and cost is $3.50
            Letter l2 = new Letter(a4, a1, 9.510M);// origin address is a4, destination address is a1, and cost is $9.51
            Letter l3 = new Letter(a3, a4, 4.50M);// origin address is a3, destination address is a4, and cost is $4.50

            List<Parcel> parcels = new List<Parcel> { l1, l2, l3 };// creates list using the Address objects and Letter objects

            WriteLine("Parcels: \n");

            foreach(Parcel p in parcels)//displays the list contents
            {
                WriteLine(p);
            }

        }
    }


}
