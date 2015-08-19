using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    class GSMCallHistoryTest
    {
        public static List<Calls> calls;
        public GSMCallHistoryTest()
        {
            
        }
        public static List<Calls> Calls
        {
            get { return GSMCallHistoryTest.calls; }
            set { GSMCallHistoryTest.calls = value; }
        }

        public static void Test()
        {
            GSM phone = new GSM("Samsung", "Galaxy S3");

            //Add calls
            GSMCallHistoryTest.Calls = new List<Calls>
            {
                new Calls(new DateTime(2015, 03, 17, 10, 32, 23), "0887591529", 35),
                new Calls(new DateTime(2015, 03, 17, 11, 32, 23), "0887595629", 56),
                new Calls(new DateTime(2015, 03, 17, 13, 32, 23), "0887576529", 39)
            };
            foreach (Calls call in GSMCallHistoryTest.Calls)
            {
                phone.AddCall(call);
            }

            GSMCallHistoryTest.PrintInfoCalls(GSM.CallHistory);

            Console.WriteLine("Total price is {0:F2}", GSM.CalculateTotalPrice(0.37));
            RemoveLongestCall(phone, GSM.CallHistory);
            Console.WriteLine("Total price without the longest call is {0:F2}", GSM.CalculateTotalPrice(0.37));
            phone.ClearCallHistory();
        }

        public static void PrintInfoCalls(List<Calls> CallHistory)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine("{0} call: {1}, {2}, {3} s", i + 1, CallHistory[i].Date, CallHistory[i].DialedPhone, CallHistory[i].Duration);
            }
        }

        public static List<Calls> RemoveLongestCall(GSM phone, List<Calls> CallHistory)
        {
            Calls longestCall = CallHistory[0];
            foreach (Calls call in CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            phone.DeleteCall(longestCall);
            return CallHistory;
        }
    }
}
