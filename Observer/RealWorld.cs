using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Observer
{
    public  class RealWorld
    {
        public abstract class Stock
        {
            private string _symbol;
            private double _price;
            private List<IInvestor> _investors = new List<IInvestor>();

            public Stock(string symbol, double price)
            {
                _symbol = symbol;
                _price = price;
            }

            public void Attach(IInvestor investor)
            {
                _investors.Add(investor);
            }

            public void Detach(IInvestor investor)
            {
                _investors.Remove(investor);
            }

            public void Notify()
            {
                foreach (var investor in _investors)
                {
                    investor.Update(this);
                }

                Console.WriteLine("");
            }

            public double Price
            {
                get => _price;
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                        Notify();
                    }
                }
            }

            public string Symbol => _symbol;
        }

        public class IBM : Stock
        {
            public IBM(string symbol, double price) : base(symbol, price)
            {

            }
        }

        public interface IInvestor
        {
            void Update(Stock stock);
        }

        public class Investor : IInvestor
        {
            private string _name;
            private Stock _stock;

            public Investor(string name)
            {
                _name = name;
            }

            public void Update(Stock stock)
            {
                Console.WriteLine($"Notified {_name } of {stock.Symbol}'s change  to {stock.Price:C}");
            }

            public Stock Stock
            {
                get => _stock;
                set => _stock = value;
            }
        }
    }
}
