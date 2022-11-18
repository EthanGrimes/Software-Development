/* TwoDayAirPackage class stores whether the user selects a package to be early or saver, the cost of shipping two day air, and returns the result as a string*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



public class TwoDayAirPackage : AirPackage
{
    //precondition: none
    //postcondition: creates enum variables
    public enum Delivery
    {
        Early,
        Saver
    }

    private Delivery delivery;//variable that relates to enum Delivery

    public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, Delivery type) : base(originAddress, destAddress, length, width, height, weight)
    {
        DeliveryType = type;//Delivery Type Property is equal to type variable
    }

    //precondition: must state which type of delievry
    //postcondition: returns delivery
    public Delivery DeliveryType
    {
        get
        {
            return delivery;
        }

        set
        {
            if (Enum.IsDefined(typeof(Delivery), value))
                delivery = value;
            else
                throw new ArgumentOutOfRangeException(nameof(DeliveryType), value, $"{nameof(DeliveryType)} must be {nameof(Delivery.Early)} or {nameof(Delivery.Saver)}");
                    
        }
    }

    //precondition: totaldimension, and weight cannot be less than 0
    //postcondition: returns base_cost
    public override decimal CalcCost()
    {
        const double value3 = .18;//dimension weight
        const double value4 = .20;//weight weight value
        const decimal discount = .15M;//discount value
        decimal base_cost;// base cost of shipping two day air

        base_cost = (decimal)( value3 * TotalDimension() + value4 * Weight);

        if (DeliveryType == Delivery.Saver)
            base_cost += (1 - discount);

        return base_cost;

    }

    //precondition: none
    //postcondition: A String with the TwoDayAirPackage data has been returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Two Day:{NL}{base.ToString()}{NL}Delivery Type:{DeliveryType}"; 
    }

}
