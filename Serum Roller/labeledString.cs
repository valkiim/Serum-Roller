using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class labeledString
    {
        public labeledString(string inID, string inEffect)
        {
            ID = inID;
            Effect = inEffect;
        }
        public string ID;
        public string Effect;
        override public string ToString()
        {
            return ID;
        }
    }

}
