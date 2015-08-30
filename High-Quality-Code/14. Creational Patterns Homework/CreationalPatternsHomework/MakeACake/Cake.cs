using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //Represents a product created by the builder
    public class Cake
    {
        public Cake()
        {
        }

        public int Bases { get; set; }

        public string Cream { get; set; }
    }
}
