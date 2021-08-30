using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class mainForm : Form
    {
        public List<AddressEntry> addressList = new List<AddressEntry>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadAddresses(addressList);
        }

        private void newEntryBtn_Click(object sender, EventArgs e)
        {
            addNewEntryFrm newEntryForm = new addNewEntryFrm(addressList);
            newEntryForm.mainFrm = this;
            newEntryForm.ShowDialog();
            
        }

        public void loadAddresses(List<AddressEntry> addresses)
        {
            if(addresses.Count > 0)
            {
                nameLbx.Items.Clear();
                foreach (AddressEntry entry in addresses)
                {
                    nameLbx.Items.Add(entry);
                }
            }
        }

        private void editEntryBtn_Click(object sender, EventArgs e)
        {
            if (nameLbx.SelectedIndex >= 0) 
            {
                AddressEntry entryToEdit = nameLbx.SelectedItem as AddressEntry;
                addNewEntryFrm editEntryForm = new addNewEntryFrm(entryToEdit, addressList);
                editEntryForm.mainFrm = this;
                editEntryForm.ShowDialog();
            }
            
        }

        private void viewEntryBtn_Click(object sender, EventArgs e)
        {
            if (nameLbx.SelectedIndex >= 0)
            {
                AddressEntry entryToView = nameLbx.SelectedItem as AddressEntry;
                viewForm viewEntryForm = new viewForm(entryToView);
                viewEntryForm.ShowDialog();
            }
        }
    }
}
