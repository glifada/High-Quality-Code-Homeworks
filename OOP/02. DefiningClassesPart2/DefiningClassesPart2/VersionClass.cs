using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [Version("2.11")]
    class VersionClass
    {
        public static void TestVersion()
        {
            Type type = typeof(VersionClass);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine("The version of the class is {0}", item.Version);
            }
        }
    }
}
