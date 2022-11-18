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
    public partial class LetterForm : Form
    {
        
        private List<Address> addresses = new List<Address>();//creates new list of addresses

        public LetterForm(List<Address> correctaddresses) //Constructor
        {
            InitializeComponent();
            addresses = correctaddresses;//sets object addresses to object correctaddresses
        }

        //adds addresses to appropriate combo boxes
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addresses)
            {
                OriginAddCbo.Items.Add(a.Name);
                DestinationAddCbo.Items.Add(a.Name);
            }
        }
        //Precondition: none
        //PostCondition: returns Origin Address
        internal Address Origin//Origin property
        {
            get
            {
                return addresses[OriginAddCbo.SelectedIndex];
            }
        }

        //Precondition: none
        //PostCondition: returns Destination Address
        internal Address Destination//Destination Property
        {
            get
            {
                return addresses[DestinationAddCbo.SelectedIndex];
            }
        }

        //Precondition: none
        //PostCondition: returns Fixed Cost
        internal decimal FixedCost//FixedCost property
        {
            get
            {
                return decimal.Parse(CostTextBox.Text);
            }
        }

        //PreCondition: OK button is clicked
        //PostCondition: Form is submitted
        private void OK_Click(object sender, EventArgs e)//OK Button
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //PreCondition: Cancel button is clicked
        //PostCondition: form is cancelled
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //PreCondition: none
        //PostCondition: returns destination validation
        private void DestinationAddCbo_Validating(object sender, CancelEventArgs e)
        {
            if (DestinationAddCbo.SelectedIndex < 0)
            {
                errorProvider.SetError(DestinationAddCbo, "Select a Destination Address");
                e.Cancel = true;
            }
        }

        //PreCondition: none
        //PostCondition: returns origin validation
        private void OriginAddCbo_Validating_1(object sender, CancelEventArgs e)
        {
            if (OriginAddCbo.SelectedIndex < 0)
            {
                errorProvider.SetError(OriginAddCbo, "Select an Origin Address");
                e.Cancel = true;
            }
        }

        //PreCondition: none
        //PostCondition: returns cost validation
        private void CostTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(CostTextBox.Text, out decimal cost) || cost < 0)
            {
                errorProvider.SetError(CostTextBox, "Enter a valid cost");
                e.Cancel = true;
            }
        }

        //PreCondition: origin is valid
        //PostCondition: error message is not displayed
        private void OriginAddCbo_Validated(object sender, EventArgs e)
        {
            if (OriginAddCbo.SelectedIndex >= 0)
            {
                errorProvider.SetError(OriginAddCbo, "");
            }
        }

        //PreCondition: Destination is valid
        //PostCondition: error message is not displayed
        private void DestinationAddCbo_Validated(object sender, EventArgs e)
        {
            if (DestinationAddCbo.SelectedIndex >= 0)
            {
                errorProvider.SetError(DestinationAddCbo, "");
            }
        }
        //PreCondition: cost is valid
        //PostCondition: error message is not displayed
        private void CostTextBox_Validated(object sender, EventArgs e)
        {
            if (!decimal.TryParse(CostTextBox.Text, out decimal cost) && cost < 0)
            {
                errorProvider.SetError(CostTextBox, "");
              
            }
        }
    }
}
