namespace Design_Pattern.Observer
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了观察者模式。
    /// 在该模式中，每次股票价值发生变化时都回通知注册投资者。
    /// https://www.dofactory.com/net/observer-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class Stock
        {
            private double _price;
            private readonly List<IInvestor> _investors = new List<IInvestor>();

            protected Stock(string symbol, double price)
            {
                Symbol = symbol;
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

            public string Symbol { get; }
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
            private readonly string _name;

            public Investor(string name)
            {
                _name = name;
            }

            public void Update(Stock stock)
            {
                Console.WriteLine($"Notified {_name } of {stock.Symbol}'s change  to {stock.Price:C}");
            }

            public Stock Stock { get; set; }
        }
    }
}
