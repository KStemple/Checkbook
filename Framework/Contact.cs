using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework
{
    [Serializable]
    public class Contact
    {
        private Guid _id;
        private String _firstName;
        private String _lastName;
        private String _company;
        private String _address1;
        private String _address2;
        private String _city;
        private String _state;
        private String _zipcode;
        private String _phoneNumber;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public String Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public String Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        public String Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        public String State
        {
            get { return _state; }
            set { _state = value; }
        }

        public String Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public override string ToString()
        {
            return _lastName + ", " + _firstName;
        }
    }
}
