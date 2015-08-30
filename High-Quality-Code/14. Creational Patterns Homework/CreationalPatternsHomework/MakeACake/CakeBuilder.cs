using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //Concrete builder implementation
    public class CakeBuilder : ICakeBuilder
    {
        private Cake _cake;

        public CakeBuilder()
        {
            this._cake = new Cake();
        }

        public void SetCream(string flavour)
        {
            this._cake.Cream = flavour;
        }

        public void SetBases(int count)
        {
            this._cake.Bases = count;
        }

        public Cake GetResult()
        {
            return this._cake;
        }
    }
}
