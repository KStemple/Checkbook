using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Framework.Collections
{
    [Serializable]
    [XmlRoot("Contacts")]
    public class Contacts : List<Contact>
    {
    }
}
