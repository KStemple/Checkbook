using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Framework
{
    [Serializable]
    public class Ledger
    {
        private Guid _id;
        private DateTime _dateTime;
        private Decimal _amount;
        private Guid _categoryId;
        private Guid _contactId;
        private String _checkNumber;
        private String _invoiceNumber;
        private String _memo;
        private Contact _contact;
        private Decimal _balance;
        private Category _category;

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }





        public String CheckNumber
        {
            get { return _checkNumber; }
            set { _checkNumber = value; }
        }

        public String InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }

        public String Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public Guid ContactId
        {
            get { return _contactId; }
            set { _contactId = value; }
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Guid CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }


        [XmlIgnore]
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        
    }
}
