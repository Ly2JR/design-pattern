namespace Design_Pattern.Bridge
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了桥接模式，其中BusinessObject抽象于DataObject中的实现分离。
    /// DataObject实现可以动态发展而无需更改任何客户端。
    /// https://www.dofactory.com/net/bridge-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class CustomerBase
        {
            private DataObject _dataObject = null!;

            public DataObject Data
            {
                get => _dataObject;
                set=> _dataObject = value;
            }

            public virtual void Next()
            {
                _dataObject.NextRecord();
            }

            public virtual void Prior()
            {
                _dataObject.PriorRecord();
            }

            public virtual void Add(string customer)
            {
                _dataObject.AddRecord(customer);
            }

            public virtual void Delete(string customer)
            {
                _dataObject.DeleteRecord(customer);
            }

            public virtual void Show()
            {
                _dataObject.ShowRecord();
            }

            public virtual void ShowAll()
            {
                _dataObject.ShowAllRecords();
            }
        }

        public class Customers : CustomerBase
        {
            public override void ShowAll()
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                base.ShowAll();
                Console.WriteLine("-----------------------------");
            }
        }
        public abstract class DataObject
        {
            public abstract void NextRecord();
            public abstract void PriorRecord();
            public abstract void AddRecord(string name);
            public abstract void DeleteRecord(string name);
            public abstract string GetCurrentRecord();
            public abstract void ShowRecord();
            public abstract void ShowAllRecords();
        }

        public class CustomersData : DataObject
        {
            private readonly List<string> _customers = new List<string>();
            private int _current;
            private readonly string _city;

            public CustomersData(string city)
            {
                _city=city;
                _customers.Add("Jim Jones");
                _customers.Add("Samual Jackson");
                _customers.Add("Allen Good");
                _customers.Add("Ann Stills");
                _customers.Add("Lisa Giolani");
            }

            public override void NextRecord()
            {
                if (_current <= _customers.Count - 1)
                {
                    _current++;
                }
            }

            public override void PriorRecord()
            {
                if (_current > 0)
                {
                    _current--;
                }
            }

            public override void AddRecord(string customer)
            {
                _customers.Add(customer);
            }

            public override void DeleteRecord(string customer)
            {
                _customers.Remove(customer);
            }

            public override string GetCurrentRecord()
            {
                return _customers[_current];
            }

            public override void ShowRecord()
            {
                Console.WriteLine(_customers[_current]);
            }

            public override void ShowAllRecords()
            {
                Console.WriteLine($"Customer City: {_city}");
                foreach (var customer in _customers)
                {
                    Console.WriteLine($" {customer}");
                }
            }
        }
    }
}
