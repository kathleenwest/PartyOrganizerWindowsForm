using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    /// <summary>
    /// class Party
    /// Description: This class is for the business logic end and application work
    /// that is done for the PartyPlanner. All relevent fields, methods (behaviors), data
    /// for the application is housed in this class object. 
    /// </summary>
    class Party
    {
        // Master Array for the Party Guest List
        // Can also hold null or empty strings at an index location
        private string[] guestList;

        // Cost per Person for the Party
        private double costPerCapita;

        // Property to get and set values for the CostPerGuest
        public double CostPerGuest {
            get { return costPerCapita; }

            set
            {
                if (value >= 0)
                    costPerCapita = value;
            }
        }

        /// <summary>
        /// method Party()
        /// Description: Constructor for the Party Class. Creates a guestList array
        /// with sizing as the input number of guests
        /// Inputs: integer - maximum number of guests to size array
        /// Outputs: None
        /// </summary>
        public Party(int maxNumberofGuests)
        {
            guestList = new string[maxNumberofGuests];
        } // end of Party(int maxNumberofGuests)

        /// <summary>
        /// method NumOfGuests()
        /// Description: Accesses the private guestList array holding the party guests
        /// and counts the number of guests (excludes empty strings)
        /// Inputs: None
        /// Outputs: Integer number of guests. Default 0.
        /// </summary>
        public int NumOfGuests()
        {
            int numGuests = 0;

            for(int i = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }

            return numGuests;
        } // end of NumOfGuests()

        /// <summary>
        /// method FindVacantPos()
        /// Description: Accesses the private guestList array holding the party guests
        /// and finds the first position where there is an empty or null string value so that
        /// a new party guest can be added
        /// Inputs: None
        /// Outputs: Integer with the array position where there is an empty or null string value
        /// Default returned is -1 for no position available.
        /// </summary>
        private int FindVacantPos()
        {
            int vacantPos = -1;

            for (int i = 0; i < guestList.Length; i++)
            {
                if(string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPos = i;
                    break;
                }
            }

            return vacantPos;
        } // end of FindVacantPos()

        /// <summary>
        /// method FullName(string firstName, string lastName)
        /// Description: This method takes the input first and last names of the party guest and 
        /// converts it to one full name string LASTNAME, + firstname
        /// Inputs: Two string values that hold the first and last names of the party guest
        /// Outputs: One string that converts the last name to uppercase and concatenates to one
        /// full name string value LASTNAME, + firstname
        /// </summary>
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        } // end of FullName(string firstName, string lastName)

        /// <summary>
        /// method AddNewGuest(string firstName, string lastName)
        /// Description: This method takes the input first and last names of the party guest and 
        /// then finds the first vacant position in the existing array (if applicable, then adds the guest 
        /// to the array location with the full name string.
        /// Inputs: Two string values that hold the first and last names of the party guest
        /// Outputs: boolean true or false to return the success or failure of the Add operation
        /// </summary>
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                return false;

            return ok;
        } // end of AddNewGuest(string firstName, string lastName)

        /// <summary>
        /// method GetGuestList()
        /// Description: The method references the master array guestList and creates a new
        /// array with only the non-null non-empty guest names and returns this array
        /// Inputs: None
        /// Outputs: String array with the guest names (not null or empty)
        /// </summary>
        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            // check the caller handling of null
            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for(int i = 0, j = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i]; 
                }
            }

            return guests;
        } // end of GetGuestList()

        #region Quiz
        // Q1: What does j++ on line 101 mean?
        // My Answer: The post-increment operator increase
        // the value of their operand by 1, but the value 
        // of the expression is the operand's original value 
        // prior to the increment operation.
        // 
        // Q2: Could j++ be moved to line 97 and placed after 
        // i++ separated by a comma? If yes, why is it not done
        // in the code above?
        // My Answer: If j++ was moved to the line by i++ this would
        // make a copy of the exact array with potentially empty
        // spaces due to the guest list having empty spaces to store
        // additional guests. Since it is not the intent to return 
        // a list of guests with empty spaces or missing names
        // the guest list should only add a value if there is a name on the
        // main guestList master array and index to the next place to hold
        // the next value.
        #endregion Quiz

        /// <summary>
        /// method CalcTotalCost()
        /// Description: The method calculates the total cost of the party by multiplying
        /// the cost per person by the actual number of guests
        /// Inputs: None
        /// Outputs: double value of the total party costs
        /// </summary>
        public double CalcTotalCost()
        {
            return costPerCapita * NumOfGuests();
        } // end of CalcTotalCost()

        /// <summary>
        /// method DeleteGuest(int selectedIndex)
        /// Description: The method deletes a guest from the master array guestList
        /// by first receiving a selected index from the GUI list box where the user selected
        /// the guest to be deleted. Since the arrays may be dissimlar a mapping must be done 
        /// between the master array guest list and the actual output GuestList. The master guestList
        /// array may contain empty strings at an index, but the output array for the GUI list is
        /// abridged and contained only non-null non-empty guests. The correct index at the master array
        /// guestList must be determined for the guest to be properly deleted.
        /// Inputs: integer selected index from the GUI list box of guests 
        /// Outputs: boolean true or false to indicicate success or failure
        /// </summary>
        public bool DeleteGuest(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = string.Empty;
            return true;
        } // end of DeleteGuest(int selectedIndex)

        /// <summary>
        /// method ChangeGuest(int selectedIndex, string firstName, string lastName)
        /// Description: The method changes a guest name in the master array guestList
        /// by first receiving a selected index from the GUI list box where the user selected
        /// the guest to be changed. Since the arrays may be dissimlar a mapping must be done 
        /// between the master array guest list and the actual output GuestList. The master guestList
        /// array may contain empty strings at an index, but the output array for the GUI list is
        /// abridged and contained only non-null non-empty guests. The correct index at the master array
        /// guestList must be determined for the guest to be properly changed.
        /// Inputs: integer selected index from the GUI list box of guests, two strings for
        /// first and last names of the guest to be changed
        /// Outputs: boolean true or false to indicicate success or failure
        /// </summary>
        public bool ChangeGuest(int selectedIndex, string firstName, string lastName)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = FullName(firstName, lastName);
            return true;
        } // end of ChangeGuest(int selectedIndex, string firstName, string lastName)

        /// <summary>
        /// method GetGuestName(int selectedIndex)
        /// Description: The method gets a guest name in the master array guestList
        /// by first receiving a selected index from the GUI list box where the user selected.
        /// The objective is to take the name from the master guestList array and re-create the
        /// first and last name to display in the GUI user entry text boxes for the first and last name
        /// to make the data entry easier for changes to existing guests.
        /// Since the arrays may be dissimlar a mapping must be done 
        /// between the master array guest list and the actual output GuestList. The master guestList
        /// array may contain empty strings at an index, but the output array for the GUI list is
        /// abridged and contained only non-null non-empty guests. The correct index at the master array
        /// guestList must be determined for the guest to be properly changed.
        /// Inputs: integer selected index from the GUI list box of guests
        /// Outputs: string array that lists the split last and first name of the guest
        /// </summary>
        public string[] GetGuestName(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return null;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            string temp = guestList[map[selectedIndex]];
            char delimiter = ',';
            string[] substrings = temp.Split(delimiter);

            return substrings;
        } // end of GetGuestName(int selectedIndex)

    } // end of class Party
} // end of namespace
