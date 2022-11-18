using System;
using System.Collections.Generic;
using System.Text;



public class Address//address class
{
    public const int ZipMin = 0; //minimum zipcode value

    public const int ZipMax = 99999; //maximum zipcode value

    private string add_name; //address name

    private string add_one; //first address line

    private string add_two; //second address line

    private string add_city; //address city

    private string add_state; //address state

    private int add_zip; //address zipcode

    //Precondition: all variables, except address2, cannot be null or whitespace, zipcode must be between 0 and 99999
    //Postcondition: address is created using the user's inputs
    public Address(string name, string address1, string address2, string city, string state, int zip)//address constructor with parameters
    {
        Name = name; //Name property set to equal address constructor name parameter

        Address1 = address1; //Address1 property set equal to address constructor address1 parameter

        Address2 = address2; //Address2 property set equal to address constructor address2 parameter

        City = city; //City property set equal to address constructor city parameter

        State = state; //State property set equal to address constructor state parameter

        Zipcode = zip; //Zipcode property set equal to address constructor zip parameter
    }

    public string Name// address name property
    {
        //precondition: none
        //postcondition: returns address name
        get
        {
            return add_name;// gets the value of add_name that was inputted
        }

        //precondition: value cannot be null or whitespace
        //postcondition: address name is set to user input
        set
        {
            if (string.IsNullOrWhiteSpace(value))// checks if user left field empty/blank

                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Name)} must contain a value.");// tells user to input a name if field is left empty

            else

                add_name = value.Trim();// removes all unnecessary characters
        }
    }

    public string Address1// first address line property
    {
        //precondition: none
        //postcondition: returns address line 1
        get
        {
            return add_one;// gets the value of add_one that was inputted
        }

        //precondition: value cannot be null or whitespace
        //postcondition: address line 1 is set to user input
        set
        {
            if (string.IsNullOrWhiteSpace(value))// checks if user left field empty/blank

                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address1)} must contain a value."); // tells user to input an address if field is left empty

            else

                add_one = value.Trim();// removes all unnecessary characters
        }
    }

    public string Address2 // second (optional) address line property
    {
        //precondition: none
        //postcondition: returns address name
        get
        {
            return add_two; //gets the value of add_two
        }

        //precondition: field can be empty or contain value
        //postcondition: address2 is set to user input
        set
        {
            if (value == null)// checks if field is used 
                value = string.Empty;
            add_two = value.Trim();//removes unnecessary characters
        }
    }

    public string City // city property
    {
        //precondition: none
        //postcondition: returns city
        get
        {
            return add_city;// gets value of add_city
        }

        //precondition: value cannot be null or whitespace
        //postcondition: city is set to user input
        set
        {
            if (string.IsNullOrWhiteSpace(value))// checks if user left field empty/blank
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} must contain a value.");// returns statement if field is blank
            else
                add_city = value.Trim();//removes unnecessary characters
        }
    }

    public string State // state property
    {
        //precondition: none
        //postcondition: returns state
        get
        {
            return add_state; //gets value for add_state
        }

        //precondition: value cannot be null or whitespace
        //postcondition: state is set to user input

        set
        {
            if (string.IsNullOrWhiteSpace(value))// checks if user left field empty/blank
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} must contain a value.");//returns statement if field is blank
            else
                add_state = value.Trim();//removes unnecessary characters
        }
    }

    public int Zipcode // zipcode property
    {
        //precondition: none
        //postcondition: returns address name
        get
        {
            return add_zip; //gets value of Zipcode
        }

        //precondition: value cannot be null, whitespace, less than 0 or greater than 99999
        //postcondition: zipcode is set to user input
        set
        {
            if ((value >= ZipMin) && (value <= ZipMax)) //checks if the zipcode is valid

                add_zip = value; // accepts zipcode if valid

            else

                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zipcode)} must contain a valid zipcode."); // returns statement if invalid
        }
    }

    //Precondition: none
    // Postcondition: a string containing the address's data is created
    public override string ToString()//return string representation of Address
    {
        string full_address;//new string called full_address

       full_address = $"\nName: {Name}\n" + $"Address Line 1: {Address1}\n" + $"Address Line 2: {Address2}\n" + $"City: {City}\n" + $"State: {State}\n" + $"Zipcode: {Zipcode:D5}\n";// string interpolation displays full address details from Address constructor

        if (!string.IsNullOrWhiteSpace(Address2))//checks if Address2 is empty and returns the blank space if so
            full_address += $"{Address2}\n";

        return full_address; 
    }

}













