using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //The director
    public class CakeConstructor
    {
        public void Construct(CakeBuilder cakeBuilder)
        {
            cakeBuilder.BakeBase();
            cakeBuilder.BeatCream();
        }
    }
}
