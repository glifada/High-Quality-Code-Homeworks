using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    class CheeseCakeBuilder: CakeBuilder
    {
        public CheeseCakeBuilder()
        {
            this.Cake = new Cake("Cheese Cake");
        }

        public override void BakeBase()
        {
            Cake.CakeBase = "Vanila";
        }

        public override void BeatCream()
        {
            Cake.Cream = "Cheese";
        }
    }
}
