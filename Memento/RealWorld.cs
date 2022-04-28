namespace Design_Pattern.Memento
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了临时保存然后恢复SalesProspect的内部状态的Memento模式
    /// https://dofactory.com/net/memento-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class SaleProspect
        {
            private string _name = null!;
            private string _phone = null!;
            private double _budget;

            public string Name
            {
                get => _name;
                set
                {
                    _name = value;
                    Console.WriteLine($"Name: {_name}");
                }
            }

            public string Phone
            {
                get => _phone;
                set
                {
                    _phone = value;
                    Console.WriteLine($"Phone: {_phone}");
                }
            }

            public double Budget
            {
                get => _budget;
                set
                {
                    _budget = value;
                    Console.WriteLine($"Budget: {_budget}");
                }
            }

            public Memento SaveMemento()
            {
                Console.WriteLine("\nSaving state -- \n");
                return new Memento(_name, _phone, _budget);
            }

            public void RestoreMemento(Memento memento)
            {
                Console.WriteLine("\nRestoring state --\n");
                Name=memento.Name;
                Phone=memento.Phone;
                Budget=memento.Budget;
            }
        }

        public class Memento
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public double Budget { get; set; }

            public Memento(string name, string phone, double budget)
            {
                Name = name;
                Phone = phone;
                Budget = budget;
            }
        }

        public class ProspectMemory
        {
            public Memento Memento { get; set; } = null!;
        }
    }
}
