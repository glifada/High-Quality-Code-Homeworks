using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //Concrete builder implementation
    public abstract class CakeBuilder
    {
        public Cake Cake { get; set; }

        public abstract void BakeBase();

        public abstract void BeatCream();
    }
}
