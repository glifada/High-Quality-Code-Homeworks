using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteStockTicker : StockTickerBase
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                Notify();
            }
        }

        public override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Notify(stock);
            }
        }
    }
}
