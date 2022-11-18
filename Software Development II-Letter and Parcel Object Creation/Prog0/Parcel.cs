using System;
using System.Collections.Generic;
using System.Text;



public abstract class Parcel
{
    private Address Original_Address;//variable that stores the origin address

    private Address Destination_Address;//variable that stores the destination address

    //precondition: none
    //postcondition: parcel is created and has specific values for both the destination and origin addresses
    public Parcel (Address origin, Address destination)
        {
            OriginAddress = origin;// origin address property is equal to variable origin
            DestinationAddress = destination;// desination address property is equal to variable origin
        }

    public Address OriginAddress// origin address property
    {
        //precondition: none
        //postcondition: returns Original_Address
        get
        {
            return Original_Address;
        }

        //precondition: value cannot be null or empty
        //postcondition: sets the specified value for OriginAddress
        set
        {
            if (value == null)//checks if the origin address is empty and if true it returns the statement
                throw new ArgumentOutOfRangeException($"{nameof(OriginAddress)}", value, $"{nameof(OriginAddress)} cannot be null");

            else//if false the destination address is equal to what the user input
                Original_Address = value;
        }
    }

    public Address DestinationAddress//destination address property
    {
        //precondition: none
        //postcondition: returns Destination_Address
        get
        {
            return Destination_Address;
        }

        //precondition: value cannot be null or empty
        //postcondition: sets the specified value for DestinationAddress

        set
        {
             if (value == null)//checks if the destination address is empty and if true it returns the statement
                throw new ArgumentOutOfRangeException($"{nameof(DestinationAddress)}", value, $"{nameof(DestinationAddress)} cannot be null");

            else//if false the destination address is equal to what the user input
                Destination_Address = value; 
        }
    }

    //precondition: none
    //postcondition: parcel's cost is returned
    public abstract decimal CalcCost();//calculates the cost

    //Precondition: none
    // Postcondition: a string containing the Parcel's data is returned
    public override string ToString()//return string representation of Parcel
    {
        return $"Origin Address:\n {OriginAddress}\n" + $"Destination Address:\n {DestinationAddress}\n" + $"Cost: {CalcCost():C}\n";
    }


}

