using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serum_Roller
{
    public class Dieroller
    {
        Random seedling;
        public Dieroller()
        {
            seedling = new Random();
        }
        // I exist to roll dice!
        public int roll()
        {
            // we're replicating 2d6 here. 
            int result = 0;
            result += seedling.Next(1, 6);
            result += seedling.Next(1, 6);
            return result;
        }
        public int r1d6()
        {
            return seedling.Next(1, 6);
        }
    }
}
