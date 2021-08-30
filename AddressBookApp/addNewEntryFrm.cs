using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class addNewEntryFrm : Form
    {
        public mainForm mainFrm;
        public List<AddressEntry> addresses;
        public AddressEntry entryToEdit;
        public addNewEntryFrm()
        {
            
        }

        public addNewEntryFrm(AddressEntry viewEntry)
        {
            InitializeComponent();
            firstNameTxt.Text = viewEntry.FirstName;
            lastNameTxt.Text = viewEntry.LastName;
            addressTxt.Text = viewEntry.Address;
            phoneTxt.Text = viewEntry.PhoneNumber;
            firstNameTxt.ReadOnly = true;
            lastNameTxt.ReadOnly = true;
            addressTxt.ReadOnly = true;
            phoneTxt.ReadOnly = true;
        }

        public addNewEntryFrm(AddressEntry editEntry, List<AddressEntry> addressList)
        {
            InitializeComponent();
            addresses = addressList;
            entryToEdit = editEntry;
            firstNameTxt.Text = editEntry.FirstName;
            lastNameTxt.Text = editEntry.LastName;
            addressTxt.Text = editEntry.Address;
            phoneTxt.Text = editEntry.PhoneNumber;
            
        }

        public addNewEntryFrm(List<AddressEntry> addressList)
        {
            InitializeComponent();
            addresses = addressList;
        }

        private void addNewEntryFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            if(firstNameTxt.Text.Length > 0 &&
                lastNameTxt.Text.Length > 0 &&
                addressTxt.Text.Length > 0 &&
                phoneTxt.Text.Length > 0)
            {
                AddressEntry newEntry = new AddressEntry(firstNameTxt.Text, lastNameTxt.Text,
                    addressTxt.Text, phoneTxt.Text);
                addresses.Add(newEntry);
                this.Close();
            }

            else
            {
                MessageBox.Show("Please fill in all the textboxes.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addNewEntryFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFrm.addressList.Remove(entryToEdit);
            mainFrm.addressList = addresses;
            mainFrm.loadAddresses(mainFrm.addressList);
        }
    }
}
