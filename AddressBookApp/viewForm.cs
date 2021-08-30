using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
        }

        public viewForm(AddressEntry viewEntry)
        {
            InitializeComponent();
            viewFirstNameTxt.Text = viewEntry.FirstName;
            viewLastNameTxt.Text = viewEntry.LastName;
            viewAddressTxt.Text = viewEntry.Address;
            viewPhoneTxt.Text = viewEntry.PhoneNumber;
        }
    }
}
