using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    public class BirthdayCakeBuilder: CakeBuilder
    {
        public BirthdayCakeBuilder()
        {
            this.Cake = new Cake("Birthday Cake");
        }

        public override void BakeBase()
        {
            Cake.CakeBase = "Choco";
        }

        public override void BeatCream()
        {
            Cake.Cream = "Strawberry";
        }
    }
}
