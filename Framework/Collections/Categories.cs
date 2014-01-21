using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Framework.Collections
{

    [Serializable]
    [XmlRoot("Categories")]
    public class Categories : List<Category>
    {
    }
}
