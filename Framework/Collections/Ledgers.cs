using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Framework.Collections
{

    //    [Serializable]
    //[XmlRoot("Account_Account_AccountTypes")]
    //public partial class Account_Account_AccountTypes : BaseCollection<Account_Account_AccountType>

    [Serializable]
    [XmlRoot("Ledgers")]
    public class Ledgers : List<Ledger>
    {


    }
}
