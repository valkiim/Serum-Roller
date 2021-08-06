using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class AttributeFrame
    {
        public string Attribute;
        public double Value;
        public AttributeFrame(string name, double val)
        {
            Attribute = name;
            Value = val;
        }
        public AttributeFrame Copy()
        {
            // copy thingy so we dont reuse the same obj with assignments
            return new AttributeFrame(Attribute, Value);
        }
    }

}
