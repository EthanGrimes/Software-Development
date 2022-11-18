//Program 4
//5166312
//12/2/21
//CIS 200-50
//Sorts destination zipcode by descending order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelTypeCostSort : Comparer<Parcel>
    {
        //Sorts parcels by Type and Cost
        public override int Compare(Parcel x, Parcel y)
        {
            //handles null values properly
            if (x == null)// y greater if x is null
            {
                return -1;
            }

            if (x == null & y == null)// both null if equal
            {
                return 0;
            }

            if (y == null)//x is greater if y is null
            {
                return 1;
            }

            if(x.GetType() != y.GetType())//compares parcel x and parcel y strings
            {
                return x.GetType().ToString().CompareTo(y.GetType().ToString());
            }

            else
            {
                return (-1) * x.CompareTo(y);//returns sort in ascending order
            }
        }
    }
}
