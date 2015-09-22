using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class StockTickerBase
    {
        readonly protected List<IStockObserverBase> _observers = new List<IStockObserverBase>();

        public void Register(IStockObserverBase observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unregister(IStockObserverBase observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public abstract void Notify();
    }
}
