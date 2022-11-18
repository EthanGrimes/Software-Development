/* NextDayAirPackage Class will store expressfee property, calculate cost of shipping, and return result as a string*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
public class NextDayAirPackage : AirPackage
{
    private decimal fee;//fee variable

   public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal express_fee) : base(originAddress, destAddress, length, width, height, weight)
    {
        ExpressFee = express_fee;//sets ExpressFee property equal to express_fee variable
    }
    
    //precondition: fee must be > 0
    //postcondition: returns fee
    public decimal ExpressFee
    {
        get
        {
            return fee;
        }

        private set
        {
            if (value >= 0)
                fee = value;
            else
                throw new ArgumentOutOfRangeException(nameof(ExpressFee), value, $"{nameof(ExpressFee)}Value must be >= 0 ");
        }
    }

    //precondition: dimension and weight and fee must be >0
    //postcondition: returns cost
    public override decimal CalcCost()
    {
        const double dim_value = .35;//dimension weight value
        const double weigh_value = .25;// weight weight value
        const double weight_Charge = .2;// weight charge
        const double size_charge = .22;// size charge
        decimal cost;// cost of next day shipping

        cost = (decimal)(dim_value * TotalDimension() + weigh_value * Weight) + ExpressFee;

        if (IsHeavy())
            cost += (decimal)(weight_Charge * Weight);
        if(IsLarge())
            cost += (decimal)(size_charge * TotalDimension());

        return cost;

    }

    //precondition: none
    //postcondition:  A string with the NextDayAirPackage's data will be returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Next Day:{NL}{base.ToString()}{NL}Express Fee:{ExpressFee}";
    }

}