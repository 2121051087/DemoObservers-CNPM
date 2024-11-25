using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObservers
{
    public class Product : ISubject
    {
        private readonly List<IObserver> _observers = new();
        public int ProductID { get; set; }
        public string Name { get; set; }
        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify(); // Thông báo đến các Observer khi giá thay đổi
                }
            }
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
