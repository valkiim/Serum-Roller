using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public class Aspect
    {
        readonly string AKingdom;    // Such as "Animal"
        readonly string AClass;      // like "Mammals" or "Reptiles"
        readonly string AFamily;     // such as "Canids"
        readonly string ASpecies;    // the thing you expect, like "frog" or "Dog"
        Aspect()
        {
            AKingdom = "UnInit";
            AClass = "UnInit";
            AFamily = "UnInit";
            ASpecies = "UnInit";
        }
        public Aspect(string inKing, string inClass, string inFamily, string inSpecies)
        {
            AKingdom = inKing;
            AClass = inClass;
            AFamily = inFamily;
            ASpecies = inSpecies;
        }
        public override string ToString()
        {
            return ASpecies;
        }
        bool Equals(Aspect Input)
        {
            // everything else is kinda extra, just compare species name
            return (Input.ASpecies.Equals(ASpecies));
        }
    }
}
