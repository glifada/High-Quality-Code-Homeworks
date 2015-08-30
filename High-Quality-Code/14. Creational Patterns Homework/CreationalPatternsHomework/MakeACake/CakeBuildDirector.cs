using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //The director
    public class CakeBuildDirector
    {
        public Cake Construct(int bases, string cream)
        {
            CakeBuilder builder = new CakeBuilder();

            builder.SetCream(cream);
            builder.SetBases(bases);

            return builder.GetResult();
        }
    }
}
