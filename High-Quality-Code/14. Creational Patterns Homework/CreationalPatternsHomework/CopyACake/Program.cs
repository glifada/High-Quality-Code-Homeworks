using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyACake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copy cake
            Console.WriteLine();
            Console.WriteLine("--------------Copied cakes--------------");
            var cupcake = new Cake("Cupcake", "Choco", "Vanila");
            var anotherCupCake = cupcake.Clone();
            cupcake.Show();
            anotherCupCake.Show();
        }
    }
}
