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
    class DescendingZip : Comparer<Parcel>
    {
        //PreCondition: None
        //PostCondition: when x<y, returns positive number
        //              when x = y, returns 0
        //              when x>y, returns a negative number
        public override int Compare(Parcel x, Parcel y )
        {
            int zip1;// x's destination zipcode
            int zip2;// y's destination zipcode

            //handles null values properly
            if (x == null)// y greater if x is null
            {
                return -1;
            }

            if (x == null & y == null)// both null if equal
            {
                return 0;
            }
           
            if(y == null)//x is greater if y is null
            {
                return 1;
            }

            zip1 = x.DestinationAddress.Zip;
            zip2 = y.DestinationAddress.Zip;

            return (-1) * zip1.CompareTo(zip2);//sets to descending order
        }
        
    }
}
