/*
 * 5166312
 * 9/27/21
 * CIS 200-50
 * GroundPackage class will store Zone Distance calculations and display them as a string and calculate the new shipping cost
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public class GroundPackage: Package
{
    public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) : base(originAddress, destAddress, length, width, height, weight)
    {

    }
    // Precondition:  zipcodes must be acceptable
    // Postcondition: returns zone distance
    public double ZoneDistance
    {
        get
        {
            const double factor = 10000;//factor to divide zipcodes by
            double _zoneDistance;//zone distance variable

            _zoneDistance = Math.Abs((OriginAddress.Zip / factor) - (DestinationAddress.Zip / factor));//returns positive distance
            return _zoneDistance;
        }
    }
    // Precondition:  None
    // Postcondition: The GroundPackage's cost has been returned
    public override decimal CalcCost()
    {
        decimal cost;//cost variable
       const double value1 = .15;//dimension factor
        const double  value2 = .07;//weight factor

        cost = (decimal)(value1 * TotalDimension() + value2 * Weight * (ZoneDistance + 1));
        return cost;
    }
    // Precondition:  None
    // Postcondition: A String with the GroundPackage's data has been returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"GroundPackage{NL}{base.ToString()}{NL}Zone Distance:{ZoneDistance}"; // Let base class help
    }
}
