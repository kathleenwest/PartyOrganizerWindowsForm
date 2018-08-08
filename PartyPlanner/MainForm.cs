using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    /// <summary>
    /// class MainForm
    /// Description: This class is for the GUI and user interactions, processing of inputs,
    /// and outputs to the GUI. The MainForm is a Windows Form that shows a GUI for a 
    /// Party Planner Application
    /// </summary>
    public partial class MainForm : Form
    {
        //The object that holds the data and business operations for this application
        Party party;

        /// <summary>
        /// method MainForm()
        /// Description: This method is the entry point of the form application
        /// and initializes and sets up the GUI. 
        /// Inputs: None
        /// Outputs: None
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        } // end of MainForm()

        /// <summary>
        /// method InitializeGUI()
        /// Description: This sets up the GUI for the first time when
        /// the form loads. 
        /// Inputs: None
        /// Outputs: None
        /// </summary>
        private void InitializeGUI()
        {
            // Clear Input Controls
            txtMaxNum.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            // Clear Output Controls
            lblTotalCostOutput.Text = "0.0";
            lblTotalGuestsOutput.Text = string.Empty;
            lstGuestList.Items.Clear();

            // Disable the Add Guest GroupBox
            grpAddGuests.Enabled = false;

            // Enable the Create Party GroupBox
            grpNewParty.Enabled = true;
        } // end of InitializeGUI()

        /// <summary>
        /// method btnCreateParty_Click(object sender, EventArgs e)
        /// Description: After the user clicks on the Create Party button, it first validates
        /// the text box entries before creating a party object
        /// Inputs: Event handling objects
        /// Outputs: None 
        /// </summary>
        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            if (CreateParty() && CostPerPerson())
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        } // end of btnCreateParty_Click(object sender, EventArgs e)

        /// <summary>
        /// method CreateParty()
        /// Description: This creates a new party object for the program after it
        /// validates the data entry of the number of guests and cost per person.
        /// Inputs: None
        /// Outputs: boolean true or false to indicicate success or failure 
        /// </summary>
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if(int.TryParse(txtMaxNum.Text, out maxNumber) && maxNumber > 0)
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party List Created for {maxNumber} guests!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid Number Please Try Again!", "Error");
                return false;
            }

            return ok;
        } // end of CreateParty()

        /// <summary>
        /// method CostPerPerson()
        /// Description: Processes the user input on the cost per person. Validates the
        /// text, parses, and sets the private field.
        /// Inputs: None
        /// Outputs: boolean true or false to indicicate success or failure 
        /// </summary>
        private bool CostPerPerson()
        {
            double amount = 0.0;

            if (double.TryParse(txtAmount.Text, out amount) && amount > 0.0)
            {
                party.CostPerGuest = amount;
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid cost amount.", "Error");
                return false;
            }
        } // end of CostPerPerson()

        /// <summary>
        /// method UpdateGUI()
        /// Description: Updates the GUI for the user including the list box of guests
        /// the party cost, and total number of guests.
        /// Inputs: None
        /// Outputs: None 
        /// </summary>
        private void UpdateGUI()
        {
            lstGuestList.Items.Clear();
            string[] guestList = party.GetGuestList();

            if(guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20} ";
                    lstGuestList.Items.Add(str);
                }
            } // I had to remove the return so the GUI would update with the
            // below output labels after the user deleted the last guest name
            // and it showed an empty list

            double totalCost = party.CalcTotalCost();
            lblTotalCostOutput.Text = totalCost.ToString("0.0");
            lblTotalGuestsOutput.Text = party.NumOfGuests().ToString();
        } // end of UpdateGUI()

        /// <summary>
        /// method btnAdd_Click(object sender, EventArgs e)
        /// Description: Alls the addition of new guests to the party.
        /// When the user clicks on the Add button, the user entry text is validated 
        /// before being added to the party object. An error message is shown if there
        /// is a problem.
        /// The GUI is updated after the operation is successful
        /// Inputs: Event handling objects
        /// Outputs: None 
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(TrimNames())
            {
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if(!ok)
                {
                    MessageBox.Show("List is full, new guest not added!", "Error");
                }
                else
                {
                    UpdateGUI();
                }
            }
        } // end of btnAdd_Click(object sender, EventArgs e)

        /// <summary>
        /// method TrimNames()
        /// Description: Validates the text to be not empty or null 
        /// Inputs: String text of the text to be validated
        /// Outputs: boolean true or false to indicicate success or failure
        /// </summary>
        private bool ValidateText(string text)
        {

            if(string.IsNullOrEmpty(text.Trim()))
            {
                MessageBox.Show("Please provide both the first name and second name.", "Error");
                return false;
            }
            else
            {
                return true;
            }
        } // end of ValidateText(string text)

        /// <summary>
        /// method TrimNames()
        /// Description: Validates the user entry text boxes for first and last names
        /// then trims the text in the entry boxes.  
        /// Inputs: None
        /// Outputs: boolean true or false to indicicate success or failure
        /// </summary>
        private bool TrimNames()
        {
            if(!ValidateText(txtFirstName.Text) || !ValidateText(txtLastName.Text))
            {
                return false;
            }

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        } // end of TrimNames()

        /// <summary>
        /// method btnChange_Click(object sender, EventArgs e)
        /// Description: When the user clicks on the change button , it will determine the
        /// current index and guest from the selected list box of guests and then send to the
        /// party object to process and change the guest name from the party object. The new guest
        /// name is sent to the party object to be added at the same location of the existing
        /// guest name in the master array.
        /// The GUI is updated after the message box is shown. 
        /// Inputs: Event handling objects
        /// Outputs: None 
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            // Object has not been initialized
            if ((selectedIndex < 0) || (party == null))
                return;

            if (TrimNames() && selectedIndex >= 0 && party.ChangeGuest(selectedIndex, txtFirstName.Text, txtLastName.Text))
            {
                MessageBox.Show("Guest Changed", "Success");
            }
            else
            {
                MessageBox.Show("Guest Not Changed!", "Error");
            }

            // Update after the guest change
            UpdateGUI();
        } // end of btnChange_Click(object sender, EventArgs e)

        /// <summary>
        /// method btnDelete_Click(object sender, EventArgs e)
        /// Description: When the user clicks on the delete button , it will determine the
        /// current index and guest from the selected list box of guests and then send to the
        /// party object to process and delete the guest from the party. The GUI is updated 
        /// after the message box is shown. 
        /// Inputs: Event handling objects
        /// Outputs: None 
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            // Object has not been initialized
            if ((selectedIndex < 0) || (party == null))   
                return;

            if (selectedIndex >= 0 && party.DeleteGuest(selectedIndex))
            {
                MessageBox.Show("Guest Deleted", "Success");
            }
            else
            {
                MessageBox.Show("Guest Not Deleted!","Error");
            }

            // Update after the guest deletion has been completed or not completed.
            UpdateGUI();
        } // end of btnDelete_Click(object sender, EventArgs e)

        /// <summary>
        /// method lstGuestList_SelectedIndexChanged(object sender, EventArgs e)
        /// Description: When the GUI list box of guests selection index is changed (user selects a different
        /// guest) the text boxes for last and first name data entry of the guests will be updated for the
        /// user selection to make it easier for the user to change the first and last name of the selected
        /// guest. 
        /// Inputs: Event handling objects
        /// Outputs: None 
        /// </summary>
        private void lstGuestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            // Object has not been initialized
            if ((selectedIndex < 0) || (party == null))
                return;

            string[] name = party.GetGuestName(selectedIndex);

            // if not null
            if(name != null)
            {
                txtLastName.Text = name[0].Trim();
                txtFirstName.Text = name[1].Trim();
            }
        } // end of lstGuestList_SelectedIndexChanged(object sender, EventArgs e)

    } // end of class
} // end of namespace
