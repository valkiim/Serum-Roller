using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class sEffect
    {
        // this will do weirder shit in the future. 
        // its doing weirder shit now. please see EffectReworkText
        int Roll; // dieroll of the effect
        string[] Effects; //string which is the effect to be printed out
        
        public sEffect(int x, string[] data)
        {
            //standard issue no mess constructor
            Roll = x;
            Effects = data;
        }
        public override string ToString()
        {
            string result = "";
            foreach (string s in Effects)
            {
                result += s;
            }
            return result;
        }

        internal string[] ToStringArr()
        {
            return Effects;
        }
    }
}
