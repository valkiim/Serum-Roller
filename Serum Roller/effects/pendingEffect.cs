using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller.effects
{
    public class PendingEffect
    {
        public string Timing;
        public string Effect;
        public string Parame;
        public PendingEffect(string t, string e, string p)
        {
            Timing = t;
            Effect = e;
            Parame = p;
        }
        public PendingEffect(PendingEffect father)
        {
            Timing = father.Timing;
            Effect = father.Effect;
            Parame = father.Parame;
        }
    }
}
