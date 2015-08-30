using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyACake
{
    //Represents a product created by the builder
    public class Cake: CakePrototype
    {
        private readonly string cakeType;

        public Cake(string cakeType, string cakeBase, string cream)
        {
            this.cakeType = cakeType;
            this.CakeBase = cakeBase;
            this.Cream = cream;
        }

        public string CakeBase { get; set; }
        public string Cream { get; set; }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("{0} with {1} base and {2} cream", this.cakeType, this.CakeBase, this.Cream);
        }

        public override Cake Clone()
        {
            return this.MemberwiseClone() as Cake;
        }
    }
}
