namespace Design_Pattern
{
    /// <summary>
    /// 观察者模式
    /// </summary>
    public class ObserverPattern
    {
        #region Structural code

        //public abstract class Subject
        //{
        //    private readonly List<Observer> _observers=new();

        //    public void Attach(Observer observer)
        //    {
        //        _observers.Add(observer);
        //    }

        //    public void Detach(Observer observer)
        //    {
        //        _observers.Remove(observer);
        //    }

        //    public void Notify()
        //    {
        //        foreach (var o in _observers)
        //        {
        //            o.Update();
        //        }
        //    }
        //}

        //public class ConcreteSubject : Subject
        //{
        //    public string? SubjectState { get; set; }
        //}

        //public abstract class Observer
        //{
        //    public abstract void Update();
        //}

        //public class ConcreteObserver : Observer
        //{
        //    private readonly string _name;
        //    private string? _observerState;
        //    private ConcreteSubject _subject;

        //    public ConcreteObserver(ConcreteSubject subject, string name)
        //    {
        //        _subject = subject;
        //        _name = name;
        //    }
        //    public override void Update()
        //    {
        //        _observerState = _subject.SubjectState;
        //        Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
        //    }

        //    public ConcreteSubject Subject
        //    {
        //        get => _subject;
        //        set => _subject = value;
        //    }
        //}

        #endregion

        #region Real-world code

        public abstract class Stock
        {
            private string _symbol;
            private double _price;
            private List<IInvestor> _investors=new List<IInvestor>();

            public Stock(string symbol, double price)
            {
                _symbol=symbol;
                _price=price;
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

        public class IBM :ObserverPattern.Stock
        {
            public IBM(string symbol, double price) : base(symbol, price)
            {

            }
        }

        public interface IInvestor
        {
            void Update(ObserverPattern.Stock stock);
        }

        public class Investor : IInvestor
        {
            private string _name;
            private ObserverPattern.Stock _stock;

            public Investor(string name)
            {
                _name=name;
            }

            public void Update(ObserverPattern.Stock stock)
            {
                Console.WriteLine($"Notified {_name } of {stock.Symbol}'s change  to {stock.Price:C}");
            }

            public ObserverPattern.Stock Stock
            {
                get => _stock;
                set => _stock = value;
            }
        }

        #endregion
    }
}
