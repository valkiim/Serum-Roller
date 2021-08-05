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
        List<AttributeFrame> Attributes;


        double growthEff;   // also called susceptibility
        double shrinkEff;   // also called susceptibility
        UserLog()
        {
            Aspects = new List<Aspect>();
            Attributes = new List<AttributeFrame>();
            Attributes.Add(new AttributeFrame("growthEff", 1.0));
            Attributes.Add(new AttributeFrame("shrinkEff", 1.0));
        }

        UserLog(Aspect NatIn)
        {
            Aspects = new List<Aspect>();
            Aspects.Add(NatIn);
            Natural = NatIn;
            Attributes.Add(new AttributeFrame("growthEff", 1.0));
            Attributes.Add(new AttributeFrame("shrinkEff", 1.0));
        }
        public bool RemoveAspect(Aspect Input)
        {
            // returns true if removed, false if already missing
            foreach (Aspect As in Aspects)
            {
                // checks if already present
                if (As.Equals(Input))
                {
                    Aspects.Remove(As);
                    return true;
                }
            }
            // Else
            return false;
        }
        public bool AddAspect(Aspect Input)
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
        public bool ModifyAttAdd(string att, double mod)
        {
            // returns true if modified, or false if not found
            foreach (AttributeFrame a in Attributes)
            {
                if (att.Equals(a.Attribute))
                {
                    a.Value += mod;
                    return true;
                }
            }
            return false;
        }
        public bool ModifyAttMul(string att, double mod)
        {
            // returns true if modified, or false if not found
            foreach (AttributeFrame a in Attributes)
            {
                if (att.Equals(a.Attribute))
                {
                    a.Value *= mod;
                    return true;
                }
            }
            return false;
        }
        
    }
}
