/*
 * 5166312
 * 9/27/21
 * CIS 200-50
 * Package class will store length, width, height, and weight properties, the total dimension, and return a string that will display the data
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Package : Parcel
{
    private double _length;//length of the package
    private double _width;//width of the package
    private double _height;//height of the package
    private double _weight;//weight of the package

    //Precondition: None
    //PostCondition: The package is created with the specified values for  length, width, height, and weight             
    public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight) : base(originAddress, destAddress)
    {
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
    }

    //Length Property
    public double Length
    {
        //Precondition: None
        //PostCondition: returns the length  
        get
        {
            return _length;
        }

        //Precondition: value must be greater than 0
        //PostCondition: sets the value equal to the length
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Length)}",
                     value, $"{nameof(Length)} must be greater than 0");
            }
            else
            {
                _length = value;
            }
        }
    }

    //Width Property
    public double Width
    {
        //Precondition: None
        //PostCondition: returns the width
        get
        {
            return _width;
        }

        //Precondition: value must be greater than 0
        //PostCondition: sets the value equal to the width
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Width)}",
                     value, $"{nameof(Width)} must be greater than 0");
            }
            else
            {
                _width = value;
            }
        }
    }

    //Height Property
    public double Height
    {
        //Precondition: None
        //PostCondition: returns the height
        get
        {
            return _height;
        }

        //Precondition: value must be greater than 0
        //PostCondition: sets the value equal to the height
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Height)}",
                     value, $"{nameof(Height)} must be greater than 0");
            }
            else
            {
                _height = value;
            }
        }
    }

    //Weight property
    public double Weight
    {
        //Precondition: None
        //PostCondition: returns the weight
        get
        {
            return _weight;
        }

        //Precondition: value must be greater than 0
        //PostCondition: sets the value equal to the weight
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Weight)}",
                     value, $"{nameof(Weight)} must be greater than 0");
            }
            else
            {
                _weight = value;
            }
        }
    }
    //PreCondition: length, width, and height cannot be less than 0
    //PostCondition: returns the total dimension
    protected double TotalDimension()
    {
        return (Length + Width + Height);
    }

    //PreCondition: None
    //PostCondition: A string with the package's data will be returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Package:{NL}{base.ToString()}{NL}{NL}" +
            $"Length:{NL}{Length}{NL}{NL} Width:{NL}{Width}{NL}{NL} Height:{NL}{Height}{NL}{NL} Weight:{NL}{Weight} lbs.";
    }





}

