using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public sealed class AspectRoller
    {
        private static readonly AspectRoller instance = new AspectRoller();
        List<Aspect> AspectList;
        static AspectRoller()
        {   // here to make the compiler play nice
        }
        private AspectRoller()
        {
            AspectList = new List<Aspect>();
            PopulateList();
        }
        public static AspectRoller Instance
        {
            get
            {
                return instance;
            }
        }

        public Aspect RollAspect()
        {
            Random seedling;
            seedling = new Random();
            int Result = seedling.Next(0, AspectList.Count);
            return AspectList[Result];
        }
        void PopulateList()
        {
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "Golden Jackal"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Rodent", "Chinchilla"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Marsupial", "Possum"));
            AspectList.Add(new Aspect("Animal", "Aquatic", "Mollusc", "Octopus"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Cervine", "White-Tailed Deer"));
            AspectList.Add(new Aspect("Animal", "Avian", "Columbine", "Pigeon"));
            AspectList.Add(new Aspect("Animal", "Avian", "Corvids", "Raven"));
            AspectList.Add(new Aspect("Goop", "Toppings", "PaleGoo", "Mayonaise"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Equines", "Horse"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Bovine", "Cow"));
            AspectList.Add(new Aspect("Animal", "Avian", "Phasian", "Chicken"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "Domestic Dog"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Feline", "Domestic Cat"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Sciuromorph", "Squirrel"));
            AspectList.Add(new Aspect("Animal", "Avian", "Anatidine", "Duck"));
            AspectList.Add(new Aspect("Animal", "Avian", "Anatidine", "Goose"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "Wolf"));
            AspectList.Add(new Aspect("Animal", "Mythic", "Draco", "Dragon"));
            AspectList.Add(new Aspect("Animal", "Mythic", "AvFelid", "Griffon"));
            AspectList.Add(new Aspect("Animal", "Mythic", "Draco", "Salamander"));
            AspectList.Add(new Aspect("Animal", "Aquatic", "Lamnidine", "Shark"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Hyaedine", "Gnoll"));
            AspectList.Add(new Aspect("Animal", "Reptile", "Sapius", "Lizardfolk"));
            AspectList.Add(new Aspect("Goop", "Mythic", "Synthetic", "Slime"));
            AspectList.Add(new Aspect("Animal", "Aquatic", "Cirolandine", "Giant Isopod"));
            AspectList.Add(new Aspect("Animal", "Arthopod", "Lycosidine", "Wolf Spider"));
            AspectList.Add(new Aspect("Animal", "Mythic", "Draco", "Kobold"));
            AspectList.Add(new Aspect("Animal", "Mythic", "AvFelid", "Paven"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "Red Fox"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "Fennec Fox"));
            AspectList.Add(new Aspect("Animal", "Reptile", "Colubridae", "Grass Snake"));
            AspectList.Add(new Aspect("Animal", "Reptile", "Pythonine", "Black Headed Python"));
            AspectList.Add(new Aspect("Animal", "Reptile", "Boidine", "Green Anaconda"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Girrafine", "Giraffe"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Feline", "Lion"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Feline", "Leopard"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Feline", "Tiger"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Hyaedine", "Spotted Hyena"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Ursine", "Black Bear"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Ursine", "Polar Bear"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Canine", "African Wild Dog"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Rodent", "House Mouse"));
            AspectList.Add(new Aspect("Animal", "Mammal", "Rodent", "Grey Rat"));
            AspectList.Add(new Aspect("Toy", "Plastic", "Articulated", "Figurine"));
            AspectList.Add(new Aspect("Animal", "Mythic", "Serpentine", "Naga"));

        }
    }
}
