using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ObserverPattern
    {
        static void Main(string[] args)
        {
            var stockTicker = new ConcreteStockTicker();
            var ibmObserver = new IBMStockObserver("ROBER KANASZ");
            var allObserver = new AllStockObserver("IVOR LOTOCASH");

            stockTicker.Register(ibmObserver);
            stockTicker.Register(allObserver);

            foreach (var s in StockData.getNext())
                stockTicker.Stock = s;
        }
    }
}
