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
    [Serializable]
    public partial class SelectAddress : Form
    {
        private List<Address> selectList;//creates new list
        public SelectAddress(List<Address> addresses)//constructor with list parameter
        {
            InitializeComponent();
            selectList = addresses;//sets selectList list = addresses list
        }

        public int AddressList//AddressList property
        {
            //PreCondition: none
            //PostCondition: returns slected choice from the combo box
            get
            {
                return selectCombo.SelectedIndex;
            }

            //PreCondition: user selects valid choice
            //PostCondition: specified choice is selected
            set
            {
                if((value >= -1) && (value < selectList.Count))
                {
                    selectCombo.SelectedIndex = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AddressList", value, "Index must be valid");
                }
            }
        }


        //PreCondition: User selects OK button
        //PostCondition: edits are validated
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //Precondition:none
        //PostCondition: dialog box closes
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SelectAddress_Load(object sender, EventArgs e)
        {
            foreach(Address s in selectList)//populates combo box with addresses and adds addresses to combo box
            {
                selectCombo.Items.Add(s.Name);
            }
            selectCombo.SelectedIndex = 0;
        }

        //PreCondition: user selects does not select an address
        //PostCondition: error message is displayed
        private void selectCombo_Validating(object sender, CancelEventArgs e)
        {
            if (selectCombo.SelectedIndex == -1) //user did not make a selection
            {
                e.Cancel = true;
                errorProvider1.SetError(selectCombo, "You Must select an address");
            }
        }

        //PreCondition: user selects a valid address
        //PostCondition: choice is validated
        private void selectCombo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(selectCombo, "");
        }
    }
}
