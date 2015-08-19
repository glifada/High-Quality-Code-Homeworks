using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    class GSMTest
    {
        private static GSM[] phone;

        public GSMTest(GSM[] phone)
        {
            GSMTest.phone = phone;
        }
        public GSM[] Phone 
        {
            get { return GSMTest.phone; }
            set { GSMTest.phone = value; }
        }

        public static void Test()
        {
            GSM[] phone = new GSM[]
            {
                new GSM ("Samsung", "Galaxy S5"),
                new GSM ("Samsung", "Galaxy S4"),
                new GSM ("Samsung", "Galaxy S3"),
                new GSM ("Apple", "IPhone 6S")
            };
            GSMTest test = new GSMTest(phone);

            Console.WriteLine(GSMTest.PrintInfo());
            Console.WriteLine(GSM.IPhone4S);
        }
        public static string PrintInfo()
        {
            string info = string.Empty;
            info = string.Format(string.Join<GSM>(Environment.NewLine, GSMTest.phone));
            return info;
        }
    }
}
