using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class UserLog
    {
        //im not entirely certain what im using this for, 
        // but it will store aspects and help determine effect effects
        
        public Aspect Natural;
        public Aspect Highest;
        public Aspect Lowest;
        List<Aspect> Aspects;
        List<AttributeFrame> Attributes;


        UserLog()
        {
            Aspects = new List<Aspect>();
            Attributes = new List<AttributeFrame>();
            StandardAttributes();
        }

        public UserLog(Aspect NatIn)
        {
            Aspects = new List<Aspect>();
            Aspects.Add(NatIn);
            Natural = NatIn;
            StandardAttributes();
        }

        public void StandardAttributes()
        {
            Attributes.Add(new AttributeFrame("growthEff", 1.0));
            Attributes.Add(new AttributeFrame("shrinkEff", 1.0));
            Attributes.Add(new AttributeFrame("tails", 1.0));
            Attributes.Add(new AttributeFrame("heads", 1.0));
            Attributes.Add(new AttributeFrame("armPairs", 1.0));
            Attributes.Add(new AttributeFrame("legPairs", 1.0));
            Attributes.Add(new AttributeFrame("wingPairs", 1.0));
            Attributes.Add(new AttributeFrame("eyes", 2.0));
            Attributes.Add(new AttributeFrame("penises", 1.0));
            Attributes.Add(new AttributeFrame("balls", 2.0));
            Attributes.Add(new AttributeFrame("vaginas", 1.0));
            Attributes.Add(new AttributeFrame("taurBody", 0.0));
            Attributes.Add(new AttributeFrame("bodies", 1.0));
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
        public bool setNatural(Aspect input)
        {
            Natural = input;
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
        public bool ModifyAttSet(string att, double val)
        {
            foreach (AttributeFrame a in Attributes)
            {
                if (att.Equals(a.Attribute))
                {
                    a.Value = val;
                    return true;
                }
            }
            return false;
        }
        public double getAttribute(string att)
        {   // returns 0 if attribute not found
            foreach (AttributeFrame a in Attributes)
            {
                if (att.Equals(a.Attribute))
                {
                    return a.Value;
                }
            }
            return 0.0;
        }
    }
}
