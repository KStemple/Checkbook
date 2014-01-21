using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Xml.Serialization;
using System.IO;
using Framework.Collections;
using System.Xml.Linq;

namespace Checkbook
{
    public partial class Form1 : Form
    {
        CheckBookDataWrapper _checkbook = new CheckBookDataWrapper();
        Ledgers _ledgers;
        Contacts _contacts;
        Categories _categories;
        private decimal runningBalance;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            LoadLedgers();

            LoadContacts();

            LoadCategories();

            LoadComboBoxContactList();

            LoadComboBoxCategoryList();

            calculateBalance();

        }

        private void LoadComboBoxCategoryList()
        {
            comboBoxLedgerCategoryList.DataSource = _categories;
        }

        private void LoadComboBoxContactList()
        {
            comboBoxLedgerContactList.DataSource = _contacts;
        }


        void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            Ledger ledger = new Ledger();
            bool gate = true;

            while (gate)
            {
                try
                {
                    ledger.Amount = Math.Round(Convert.ToDecimal(textBoxLedgerAmount.Text), 2);
                    gate = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid amount");
                    return;
                }
            }
            ledger.DateTime = DateTime.Now;
            ledger.Id = Guid.NewGuid();
            ledger.Memo = textBoxLedgerMemo.Text;
            ledger.CheckNumber = textBoxLedgerCheckNumber.Text;
            ledger.InvoiceNumber = textBoxLedgerInvoiceNumber.Text;
            ledger.Balance = Convert.ToDecimal(labelLedgerBalanceAmount.Text) + ledger.Amount;
            

            try
            {

                int indexCon = comboBoxLedgerContactList.SelectedIndex;
                ledger.ContactId = _contacts[indexCon].Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact ID empty or invalid. Setting default", "Invalid Contact ID",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int indexCat = comboBoxLedgerCategoryList.SelectedIndex;
            ledger.CategoryId = _categories[indexCat].Id;
            
            

            _ledgers.Add(ledger);

            BindingList<Ledger> blist = new BindingList<Ledger>(_ledgers);
            dataGridView1.DataSource = blist;

            SaveLedgers();
            LoadLedgers();

            calculateBalance();
            if (runningBalance < 0)
            {
                MessageBox.Show("You've overdrawn your account!", "Overdrawn Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveLedgers();
        }

        private void SaveLedgers()
        {
            _checkbook.SaveLedgers(_ledgers);
        }
        
        private void buttonContactsAdd_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = textboxContactsFirstName.Text;
            contact.LastName = textBoxContactsLastName.Text;
            contact.Address1 = textBoxContactsAddressOne.Text;
            contact.Address2 = textBoxContactsAddressTwo.Text;
            contact.City = textBoxContactsCity.Text;
            contact.State = textBoxContactsState.Text;
            contact.Zipcode = textBoxContactsZip.Text;
            contact.PhoneNumber = textBoxContactsPhone.Text;
            contact.Company = textBoxContactsCompany.Text;
            contact.Id = Guid.NewGuid();

            _contacts.Add(contact);

            BindingList<Contact> blist = new BindingList<Contact>(_contacts);
            this.datagridContacts.DataSource = blist;

            SaveContacts();
            LoadContacts();
        }

        private void buttonContactsSave_Click(object sender, EventArgs e)
        {
            SaveContacts();
        }

        private void SaveContacts()
        {
            _checkbook.SaveContacts(_contacts);
        }

        private void buttonLedgersRefresh_Click(object sender, EventArgs e)
        {
            RefreshLedgers();
        }

        private void RefreshLedgers()
        {
            
            LoadLedgers();
            calculateBalance();

        }

        private void LoadLedgers()
        {
            _ledgers = _checkbook.LoadLedgers();

            BindingList<Ledger> blist = new BindingList<Ledger>(_ledgers);
            dataGridView1.DataSource = blist;

        }

        private void LoadContacts()
        {
            _contacts = _checkbook.LoadContacts();

            BindingList<Contact> blistContact = new BindingList<Contact>(_contacts);
            this.datagridContacts.DataSource = blistContact;
        }

        private void buttonCategoriesSave_Click(object sender, EventArgs e)
        {
            SaveCategories();
        }

        private void SaveCategories()
        {
            _checkbook.SaveCategories(_categories);
        }

        private void LoadCategories()
        {
            _categories = _checkbook.LoadCategories();

            BindingList<Category> blistCategory = new BindingList<Category>(_categories);
            this.datagridCategories.DataSource = blistCategory;
        }

        private void buttonCategoriesAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            category.Id = Guid.NewGuid();
            category.Name = textBoxCategoriesName.Text;

            _categories.Add(category);

            BindingList<Category> blist = new BindingList<Category>(_categories);
            this.datagridCategories.DataSource = blist;

            SaveCategories();
            LoadCategories();
        }

        private void buttonLedgerDelete_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            string cellValue = dataGridView1[columnIndex, rowIndex].Value.ToString();

            int i = 0;
            bool gate = true;

                while (gate)
                {

                    String id = _ledgers[i].Id.ToString();
                    
                    if (id == cellValue)
                    {

                        MessageBox.Show(cellValue, "Deleted",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        _ledgers.RemoveAt(i);
                        gate = false;

                        BindingList<Ledger> blist = new BindingList<Ledger>(_ledgers);
                        dataGridView1.DataSource = blist;
                        

                    }
                    i++;
                }

            SaveLedgers();
            LoadLedgers();
            calculateBalance();
        }

        private void calculateBalance()
        {
            _ledgers = _checkbook.LoadLedgers();

            runningBalance = 0;
            foreach (Ledger ledger in _ledgers)
            {
                
                runningBalance = ledger.Amount + runningBalance;
            }

            labelLedgerBalanceAmount.Text = runningBalance.ToString();
        }



        private void buttonContactsDelete_Click(object sender, EventArgs e)
        {
            int columnIndex = datagridContacts.CurrentCell.ColumnIndex;
            int rowIndex = datagridContacts.CurrentCell.RowIndex;

            string cellValue = datagridContacts[columnIndex, rowIndex].Value.ToString();

            int c = 0;
            bool gate = true;

                while (gate)
                {

                    String id = _contacts[c].Id.ToString();
                    
                    if (id == cellValue)
                    {

                        MessageBox.Show(cellValue, "Deleted",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        _contacts.RemoveAt(c);
                        gate = false;

                        BindingList<Contact> blist = new BindingList<Contact>(_contacts);
                        datagridContacts.DataSource = blist;
                        

                    }
                    c++;
                }

            LoadComboBoxContactList();
        }

        private void buttonContactsRefresh_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void buttonCategoriesRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void buttonCategoriesDelete_Click(object sender, EventArgs e)
        {
            int columnIndex = datagridCategories.CurrentCell.ColumnIndex;
            int rowIndex = datagridCategories.CurrentCell.RowIndex;

            string cellValue = datagridCategories[columnIndex, rowIndex].Value.ToString();

            int ca = 0;
            bool gate = true;

            while (gate)
            {

                String id = _categories[ca].Id.ToString();

                if (id == cellValue)
                {

                    MessageBox.Show(cellValue, "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _categories.RemoveAt(ca);                   

                    gate = false;                    

                    BindingList<Category> blist = new BindingList<Category>(_categories);
                    datagridCategories.DataSource = blist;


                    
                }
                ca++;
            }


            
           }

        }

    
    }

