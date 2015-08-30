using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeBuildDirector cakeDirector = new CakeBuildDirector();
            Cake strawberryCake = cakeDirector.Construct(2, "Srawberry");
        }
    }
}
