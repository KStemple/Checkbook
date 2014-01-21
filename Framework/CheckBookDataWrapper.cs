using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Framework.Collections;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;

namespace Framework
{
    public class CheckBookDataWrapper
    {
        //String _ledgerPath = System.Windows.Forms.Application.CommonAppDataPath + "\\LedgerData.xml";
        //String _contactPath = System.Windows.Forms.Application.CommonAppDataPath + "\\ContactData.xml";

        String _ledgerPath = "c:\\CheckBookData\\LedgerData.xml";
        String _contactPath = "c:\\CheckBookData\\ContactData.xml";
        String _categoryPath = "c:\\CheckBookData\\CategoryData.xml";


        public Ledgers LoadLedgers()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Ledgers));

            if (!File.Exists(_ledgerPath))
            {
                Ledgers ledgers = new Ledgers();

                FileStream tempfs = new FileStream(_ledgerPath,
                    FileMode.Create);

                xs.Serialize(tempfs, ledgers);
                tempfs.Close();
            }

            FileStream fs = new FileStream(_ledgerPath,
                FileMode.OpenOrCreate);
            var _ledgers = (Ledgers)xs.Deserialize(fs);
            fs.Close();

            //associate the ledger with a contact
            Contacts contacts = LoadContacts();
            foreach (var ledger in _ledgers)
            {
                foreach (var contact in contacts)
                {
                    if (contact.Id == ledger.ContactId)
                    {
                        ledger.Contact = contact;
                    }
                }
            }



            Categories categories = LoadCategories();
            foreach (var ledger in _ledgers)
            {
                foreach (var category in categories)
                {
                    if (category.Id == ledger.CategoryId)
                    {
                        ledger.Category = category;
                    }
                }
            }

            return _ledgers;
        }

        public void SaveLedgers(Ledgers ledgers)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Ledgers));

            FileStream fs = new FileStream(_ledgerPath,
                FileMode.Truncate);

            xs.Serialize(fs, ledgers);
            fs.Close();

        }

        public Contacts LoadContacts()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Contacts));

            if (!File.Exists(_contactPath))
            {
                Contacts contacts = new Contacts();

                FileStream tempfs = new FileStream(_contactPath,
                    FileMode.Create);

                xs.Serialize(tempfs, contacts);
                tempfs.Close();
            }

            FileStream fs = new FileStream(_contactPath,
                FileMode.OpenOrCreate);
            var _contacts = (Contacts)xs.Deserialize(fs);
            fs.Close();

            return _contacts;
        }



        public void SaveContacts(Contacts contacts)
        {

            XmlSerializer xs = new XmlSerializer(typeof(Contacts));


            FileStream fs = new FileStream(_contactPath,
                FileMode.Truncate);

            xs.Serialize(fs, contacts);
            fs.Close();
        }


        public Categories LoadCategories()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Categories));

            if (!File.Exists(_categoryPath))
            {
                Categories categories = new Categories();

                FileStream tempfs = new FileStream(_categoryPath,
                    FileMode.Create);

                xs.Serialize(tempfs, categories);
                tempfs.Close();
            }

            FileStream fs = new FileStream(_categoryPath,
                FileMode.OpenOrCreate);
            var _categories = (Categories)xs.Deserialize(fs);
            fs.Close();

            return _categories;
        }


        public void SaveCategories(Categories categories)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Categories));

            FileStream fs = new FileStream(_categoryPath,
                FileMode.Truncate);

            xs.Serialize(fs, categories);
            fs.Close();

        }




    }
}
