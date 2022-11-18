//Program 3
//5166312
//CIS 200-50
//11-15-2021
//Program 3 adds save, edit, and open functions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;



namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
        {
            InitializeComponent();

           /* upv = new UserParcelView();
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

              5.5, TwoDayAirPackage.Delivery.Saver);*/

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 3{NL}By: 5166312 {NL}CIS 200-50 {NL}Fall 2021",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
               else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This report is generated without using a StringBuilder, just to show an
            // alternative approach more like what most students will have done
            // Method AppendText is equivalent to using .Text +=

            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            reportTxt.Clear(); // Clear the textbox
            reportTxt.AppendText("Parcels:");
            reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            reportTxt.AppendText(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                reportTxt.AppendText(p.ToString());
                reportTxt.AppendText(NL);
                reportTxt.AppendText("------------------------------");
                reportTxt.AppendText(NL);
                totalCost += p.CalcCost();
            }

            reportTxt.AppendText(NL);
            reportTxt.AppendText($"Total Cost: {totalCost:C}");

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

       

        //PreCondition: user selects save tab
        //PostCondition: file saved
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//save tab
        {
            BinaryFormatter formatter = new BinaryFormatter();//serializes upv in binary format
            FileStream output = null;// stream for writing to a file
            DialogResult dialogResult;// sets name of dialog result
            string saveFileName;//name of the file to save

            using (SaveFileDialog saveAsFile = new SaveFileDialog())//save file dialog
            {
                saveAsFile.CheckFileExists = false;//checks if file already exists
                dialogResult = saveAsFile.ShowDialog();//displays dialog box
                saveFileName = saveAsFile.FileName;//sets file to be saved as a file
            }

            if (dialogResult == DialogResult.OK)//user selects ok 
            {
                if (string.IsNullOrWhiteSpace(saveFileName))//checks if file name is valid and checks for exceptions
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try//attempts to save file
                    {
                        output = new FileStream(saveFileName, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(output, upv);

                    }
                    catch (IOException)//file cant be saved
                    {
                        MessageBox.Show("ERROR: Can't Save File. Try Again.", "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)//file cant be written
                    {
                        MessageBox.Show("ERROR: File Cannot be Written", "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close();//closes dialog box
                    }
                }
            }
        }

        //PreCondition: user selects open tab
        //PostCondition: file opened
        private void openToolStripMenuItem_Click(object sender, EventArgs e)//open tab
        {
            BinaryFormatter formatter = new BinaryFormatter();//serializes upv in binary format
            FileStream openStream = null;// stream for reading a file
            DialogResult  dialogResult;// sets name of dialog result
            string fileName;//name of the file to open


            using (OpenFileDialog Openfile = new OpenFileDialog())//open file dialog
            {
                dialogResult = Openfile.ShowDialog();//shows dialog box
                fileName = Openfile.FileName;//name of file to open

                try//searches for file  and checks for exceptions
                {
                    if(dialogResult == DialogResult.OK)//checks if file name is valid
                    {
                        if (!string.IsNullOrWhiteSpace(fileName))//checks if file name is null or white space
                        {
                            openStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                            upv = (UserParcelView)formatter.Deserialize(openStream);
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No File with that Name", "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SerializationException)//file is corrupted
                {
                    MessageBox.Show("ERROR: Invalid/Bad Data in File", "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)//file cant open
                {
                    MessageBox.Show("ERROR: Can't open File. Try Again.", "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    openStream?.Close();//closes dialog box
                }
            }
        }

        //PreCondition: user selects addresses tab
        //PostCondition: select Address dialog box appears
        private void addressesToolStripMenuItem_Click(object sender, EventArgs e)//address tab
        {
            SelectAddress selectAddress= new SelectAddress(upv.AddressList);//new Select Address form
            selectAddress.ShowDialog();//dislays dialog box

            if(selectAddress.DialogResult == DialogResult.OK)//user selects OK
            {
                int index = selectAddress.AddressList;//sets variable index equal to AddressList in selectAddress
                Address address = upv.AddressAt(index);//sets Address object as index
                AddressForm edit = new AddressForm();//creates new edit AddressForm

                //edits address properties
                edit.AddressName = address.Name;

                edit.Address1 = address.Address1;
                
                if (!string.IsNullOrWhiteSpace(address.Address2))
                {
                    edit.Address2 = address.Address2;
                }

                edit.City = address.City;

                edit.State = address.State;

                edit.ZipText = address.Zip.ToString();

                edit.ShowDialog();

                //populates form files from selected address
                if(edit.DialogResult == DialogResult.OK)
                {
                    address.Name = edit.AddressName;

                    address.Address1 = edit.Address1;

                    if (!string.IsNullOrWhiteSpace(edit.Address2))
                    {
                        address.Address2 = edit.Address2;
                    }
                    else
                    {
                        address.Address2 = "";

                        address.City = edit.City;

                        address.State = edit.State;

                        address.Zip = int.Parse(edit.ZipText);

                        upv.addresses[index] = address;
                    }
                }
            }
                            

        }
    }
}