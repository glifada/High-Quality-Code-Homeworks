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
            // Choose concrete constructor (director)
            CakeConstructor constructor = new CakeConstructor();

            // Choose concrete builder
            CakeBuilder builder = new BirthdayCakeBuilder();
            constructor.Construct(builder);
            builder.Cake.Show();

            builder = new CheeseCakeBuilder();
            constructor.Construct(builder);
            builder.Cake.Show();

            builder = new CupCakeBuilder();
            constructor.Construct(builder);
            builder.Cake.Show();
        }
    }
}
