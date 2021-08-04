using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    class UserLog
    {
        //im not entirely certain what im using this for, 
        // but it will store aspects and help determine effect effects
        List<Aspect> Aspects;
        Aspect Natural;
        Aspect Highest;
        Aspect Lowest;
        UserLog()
        {
            Aspects = new List<Aspect>();
        }

        UserLog(Aspect NatIn)
        {
            Aspects = new List<Aspect>();
            Aspects.Add(NatIn);
            Natural = NatIn;
            
        }

        bool AddAspect(Aspect Input)
        {
            // returns true if added, false if already present
            foreach (Aspect As in Aspects)
            {
                // checks if already present
                if (As.Equals(Input))
                {
                    return false;
                }
            }
            // else
            Aspects.Add(Input);
            return true;
        }
    }
}
