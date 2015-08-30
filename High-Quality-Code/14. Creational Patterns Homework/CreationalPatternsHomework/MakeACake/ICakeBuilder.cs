using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //The builder abstraction
    public interface ICakeBuilder
    {
        void SetCream(string flavour);

        void SetBases(int count);

        Cake GetResult();
    }
}
