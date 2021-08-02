using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serum_Roller
{
    public abstract class serumEffects
    {
        public sEffect[] Blatants;
        public sEffect[] Latents;
        public serumEffects()
        {

        }

        public abstract sEffect GetBlatantSEffect(int roll);
        public abstract sEffect GetLatentSEffect(int roll);
        
    }
}
