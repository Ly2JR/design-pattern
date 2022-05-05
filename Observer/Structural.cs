namespace Design_Pattern.Observer
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了观察者模式。
    /// 在该模式中，已注册对象被通知并随着状态更改而更新。
    /// https://www.dofactory.com/net/observer-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Subject
        {
            private readonly List<Observer> _observers = new();

            public void Attach(Observer observer)
            {
                _observers.Add(observer);
            }

            public void Detach(Observer observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (var o in _observers)
                {
                    o.Update();
                }
            }
        }

        public class ConcreteSubject : Subject
        {
            public string? SubjectState { get; set; }
        }

        public abstract class Observer
        {
            public abstract void Update();
        }

        public class ConcreteObserver : Observer
        {
            private readonly string _name;
            private string? _observerState;
            private ConcreteSubject _subject;

            public ConcreteObserver(ConcreteSubject subject, string name)
            {
                _subject = subject;
                _name = name;
            }
            public override void Update()
            {
                _observerState = _subject.SubjectState;
                Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
            }

            public ConcreteSubject Subject
            {
                get => _subject;
                set => _subject = value;
            }
        }
    }
}
