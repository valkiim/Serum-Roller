﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class sEffect
    {
        // this will do weirder shit in the future. 
        int roll; // dieroll of the effect
        string effect; //string which is the effect to be printed out
        
        public sEffect(int x, string data)
        {
            //standard issue no mess constructor
            roll = x;
            effect = data;
        }
        public string ToString()
        {
            return effect;
        }
    }

    
}
