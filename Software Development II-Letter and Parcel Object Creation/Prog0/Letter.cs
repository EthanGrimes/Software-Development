using System;
using System.Collections.Generic;
using System.Text;



public class Letter : Parcel//class inherited from Parcel
{
    private decimal Cost;//declares Cost variable and is only used in Letter

    //Precondition: cost is greater than or equal to 0
    //Postcondition: letter is created using the user's inputs of origin address, destination address and cost
    public Letter(Address origin, Address destination, decimal cost ) : base(origin, destination)//constructor that uses Address class's origin and destination as parameters and inherits from Parcel
     {
        Fixed_Cost = cost;//declares Fixed_Cost is equal to cost;
     }

    protected decimal Fixed_Cost//Fixed_Cost Property
    {
        //precondition: none
        //postcondition: Cost is returned
        get
        {
            return Cost;//returns Cost
        }
        //precondition: value is greater than or equal to 0
        //postcondion: letter's fixed cost is set at a specific value

        set
        {
            if (value >= 0)//checks if value is greater than or equal to 0 and returns the value if true
                Cost = value;
            else//returns statement if false
                throw new ArgumentOutOfRangeException($"{nameof(Fixed_Cost)}", value, $"{nameof(Fixed_Cost)} cannot be a negative amount.");
        }
    }

    //precondition: none
    //postcondion: letter's cost is returned
    public override decimal CalcCost()//ovverides the value for CalcCost and returns it
    {
        return Fixed_Cost;
    }
    //Precondition: none
    // Postcondition: a string containing the Letter's data is returned
    public override string ToString()// return string representation of Letter object
    {
        return $"Letter\n{base.ToString()}";
    }




}

