using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse<Equipment>();

            var ringPlate = warehouse.GetEquipment();
            ringPlate.CakeName = "Cupcake";
            Console.WriteLine(
                "Ring plate ordered on {0:MM/dd/yyyy hh:mm:ss.fff tt} used for {1}",
                ringPlate.OrderedAt,
                ringPlate.CakeName);

            warehouse.ReleaseEquipment(ringPlate);
            ringPlate.CakeName = "Birthday cake";
            Console.WriteLine(
                "Ring plate ordered on {0:MM/dd/yyyy hh:mm:ss.fff tt} used for {1}",
                ringPlate.OrderedAt,
                ringPlate.CakeName);
        }
    }
}
