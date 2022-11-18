// 5166312
// Program 2
// 10-25-21
// This program creates a simple GUI for the user
// CIS 200-50



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        public Prog2Form()//constructor
        {
            InitializeComponent();
         

            upv.AddAddress(" John Smith ", "  123 Any St.  ", " Apt. 45 ",

              " Louisville  ", " KY  ", 40202); // Test Address 1

            upv.AddAddress("Jane Doe", "987 Main St.",

              "Beverly Hills", "CA", 90210); // Test Address 2

            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",

              "El Paso", "TX", 79901); // Test Address 3

            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",

              "Portland", "ME", 04101); // Test Address 4

            upv.AddAddress("John Doe", "111 Market St.", "",

              "Jeffersonville", "IN", 47130); // Test Address 5

            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",

              "Los Angeles", "CA", 90212); // Test Address 6

            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",

              "Bethesda", "MD", 20810); // Test Address 7

            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",

              "Bloodsucker City", "TN", 37210); // Test Address 8



            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);           // Letter test object

            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);           // Letter test object

            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);  // Ground test object

            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 8.5, 9.5, 6.5, 2.5); // Ground test object

            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15,   // Next Day test object

              85, 7.50M);

            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 9.5, 6.0, 5.5,  // Next Day test object

              5.25, 5.25M);

            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 6.5, 9.5, // Next Day test object

              15.5, 5.00M);

            upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 46.5, 39.5, 28.0, // Two Day test object

              80.5, TwoDayAirPackage.Delivery.Saver);

            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 15.0, 9.5, 6.5,  // Two Day test object

              75.5, TwoDayAirPackage.Delivery.Early);

            upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(3), 12.0, 12.0, 6.0, // Two Day test object

              5.5, TwoDayAirPackage.Delivery.Saver);
        }

        UserParcelView upv = new UserParcelView();

        
        //PreCondition: user selects the About button
        //PostCondition: Dialog box appears and presents information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5166312\n Program 2\n CIS 200-50\n 10-25-21\n Program creates simple GUI for previous programs", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);//method displays information listed
        }
        //PreCondition: user selects Exit button
        //PostCondition: application closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//method closes the application
        }

        //PreCondition: user selects address
        //PostCondition: Address dialog box displays
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAddressForm addressform = new NewAddressForm();//creates a new address form

            addressform.ShowDialog();// displays dialog box 
            
            if (addressform.DialogResult == DialogResult.OK) // checks to see if AddressLine2 contains a value
            {
                if (String.IsNullOrWhiteSpace(addressform.AddressTwo))
                {
                   upv.AddAddress(addressform.AddressName,addressform.AddressOne,addressform.AddressTwo, addressform.City,addressform.State,addressform.Zipcode);
                }
                else 
                {
                   upv.AddAddress(addressform.AddressName, addressform.AddressOne, addressform.City, addressform.State, addressform.Zipcode);
                }
            }

            addressform.Dispose(); 
        }

        //PreCondition: user selects letter
        //PostCondition: letter dialog box displays
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterform = new LetterForm(upv.AddressList);    // The address dialog box form
            letterform.ShowDialog();// displays dialog box 

            if (letterform.DialogResult == DialogResult.OK) // checks to see if AddressLine2 contains a value
            {
                upv.AddLetter(letterform.Origin, letterform.Destination, letterform.FixedCost);
            }

            letterform.Dispose();
        }

        //PreCondition: user selects listaddress
        //PostCondition: list address in text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportText.Clear();
            foreach (Address a in upv.AddressList)
            {
                ReportText.Text += a.ToString();
                ReportText.Text += Environment.NewLine;
            }
                
        }

        //PreCondition: user selects list parcel
        //PostCondition: list parcel dislays in text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportText.Clear();
            foreach (Parcel p in upv.ParcelList)
            {
                ReportText.Text += p.ToString();
            }

        }

        private void Prog2Form_Load(object sender, EventArgs e)
        {

        }
    }
}


