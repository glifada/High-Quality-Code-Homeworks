namespace ClassBooleaninC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Boolean
    {
        const int MAX_COUNT = 6;
        class BooleanAsStr
        {
            internal void PrintBooleanAsString(bool boolean)
            {
                string booleanAsStr = boolean.ToString();
                Console.WriteLine(booleanAsStr);
            }
        }

        public static void Main()
        {
            Boolean.BooleanAsStr instance =
              new Boolean.BooleanAsStr();
            instance.PrintBooleanAsString(true);
        }
    }
}
