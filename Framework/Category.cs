using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework
{


    [Serializable]
    public class Category
    {
        private Guid _id;
        private String _name;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
