using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    class CupCakeBuilder: CakeBuilder
    {
        public CupCakeBuilder()
        {
            this.Cake = new Cake("CupCake");
        }

        public override void BakeBase()
        {
            Cake.CakeBase = "Vanila";
        }

        public override void BeatCream()
        {
            Cake.Cream = "Choco";
        }
    }
}
