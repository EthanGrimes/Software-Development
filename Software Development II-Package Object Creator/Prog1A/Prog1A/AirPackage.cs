using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public abstract class AirPackage : Package
{
    public double _heavy = 75;//the minimum heavy package value
    public double _large = 100;//minimum large size package value

    //AirPackage Constructor
    public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) : base(originAddress, destAddress, length, width, height, weight)
    {

    }

    // Precondition:  Weight must be greater than or equal to 75
    // Postcondition: returns true
    public bool IsHeavy()//method to check if weight is heavy
    {
        return (Weight >= _heavy);
    }

    // Precondition: Total Dimension must be greater than or equal to 100
    // Postcondition: returns true
    public bool IsLarge()//method to check if package is large
    {
        return (TotalDimension() >= _large);
    }

    // Precondition:  None
    // Postcondition: The Air Package's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Air Package:{base.ToString()} {NL}Heavy: {IsHeavy()} Large:{IsLarge()}";
    }
}
