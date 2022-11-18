// I used this website as a reference to how I typed my code: https://stackoverflow.com/questions/36824606/errorprovider-c-sharp-winforms

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
    public partial class NewAddressForm : Form
    {
        public NewAddressForm()//constructor
        {
            InitializeComponent();

            List<string> states = new List<string> { "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA","HI","ID","IL","IN","IA",
            "KS","KY","LA","ME","MD","MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ","NM","NY",
             "NC","ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT","VT","VA","WA"};//creates a new list containing the abbreviations of the states

            foreach (string state in states)//populates the state combo box
            {
                StateCbo.Items.Add(state);
            }
        }

        public const int MIN_ZIP = Address.MIN_ZIP;//sets the min zipcode value to the min zipcode value in the Address class
        public const int MAX_ZIP = Address.MAX_ZIP;//sets the max zipcode value to the max zipcode value in the Address class

        //PreCondition: submit button is clicked
        //PostCondition: Form is submitted
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        //PreCondition: cancel button is clicked
        //PostCondition: form submission is cancelled
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Precondition: none
        //PostCondition: returns Address Name
        internal string AddressName//Address name property
        {
            get
            {
                return AddressNameTextBox.Text;
            }
        }
        //Precondition: none
        //PostCondition: returns Address One
        internal string AddressOne//AddressOne property
        {
            get
            {
                return AddressNameTextBox.Text;
            }
        }

        //Precondition: none
        //PostCondition: returns Address Two
        internal string AddressTwo//AddressTwo property
        {
            get
            {
                return Address2TextBox.Text;
            }
        }

        //Precondition: none
        //PostCondition: returns City
        internal string City//City property
        {
            get
            {
                return CityTextBox.Text;
            }
        }

        //Precondition: none
        //PostCondition: returns State
        internal string State//State property
        {
            get
            {
                return StateCbo.SelectedItem.ToString();
            }
        }

        //Precondition: none
        //PostCondition: returns Zipcode
        internal int Zipcode//zipcode property
        {
            get
            {
                return int.Parse(ZipcodeTextBox.Text);
            }
        }


        //PreCondition: none
        //PostCondition: Returns Zipcode Validation
        private void ZipcodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(ZipcodeTextBox.Text, out int zip) || zip < MIN_ZIP || zip > MAX_ZIP)
            {
                errorProvider.SetError(ZipcodeTextBox, "Enter a valid Zipcode");
                e.Cancel = true;
            }
        }

        //PreCondition: none
        //PostCondition: Returns string Validation
        private void stringValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider.SetError((TextBox)sender, "Enter Valid Information.");
                e.Cancel = true;
            }
        }

        //PreCondition: none
        //PostCondition: Returns state Validation
        private void StateCbo_Validating(object sender, CancelEventArgs e)
        {
            if(StateCbo.SelectedIndex < 0)
            {
                errorProvider.SetError(StateCbo, "Select a State");
                e.Cancel = true;
            }
        }

        //PreCondition: zipcode is valid
        //PostCondition: error message is not displayed
        private void ZipcodeTextBox_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(ZipcodeTextBox.Text, out int zip) && (zip >= MIN_ZIP && zip <= MAX_ZIP))
            {
               
                errorProvider.SetError((TextBox)sender, "");
            }
        }

        //PreCondition: string is valid
        //PostCondition: error message is not displayed
        private void stringValidated(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider.SetError((TextBox)sender, "");
            }
        }

        //PreCondition: state is valid
        //PostCondition: error message is not displayed
        private void StateCbo_Validated(object sender, EventArgs e)
        {
            if (StateCbo.SelectedIndex >= 0)
            {
                errorProvider.SetError(StateCbo, "");
            }
        }
    }



}
