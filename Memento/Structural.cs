namespace Design_Pattern.Memento
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了临时保存和恢复另一个对象的内部状态的备忘录模式
    /// https://dofactory.com/net/memento-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Originator
        {
            private string? _state;

            public string? State
            {
                get => _state;
                set
                {
                    _state = value;
                    Console.WriteLine($"State = {_state}");
                }
            }

            public Memento CreateMemento()
            {
                return new Memento(_state);
            }

            public void SetMemento(Memento memento)
            {
                Console.WriteLine("Restoring state...");
                State=memento.State;
            }
        }

        public class Memento
        {
            public Memento(string? state)
            {
                State=state;
            }

            public string? State { get; }
        }

        public class Caretaker
        {
            public Memento Memento { get; set; } = null!;
        }
    }
}
