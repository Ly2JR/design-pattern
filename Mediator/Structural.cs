namespace Design_Pattern.Mediator
{
    /// <summary>
    /// Mediator Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了促进不同对象和对象类型之间松散耦合通信的中介者模式。中介是一个中心枢纽，所有的互动都必须通过它进行。
    /// https://dofactory.com/net/mediator-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Mediator
        {
            public abstract void Send(string message, Colleague colleague);
        }

        public class ConcreteMediator:Mediator
        {
            private ConcreteColleague1 _colleague1 = null!;
            private ConcreteColleague2 _colleague2 = null!;

            public ConcreteColleague1 Colleague1
            {
                set => _colleague1 = value;
            }

            public ConcreteColleague2 Colleague2
            {
                set => _colleague2 = value;
            }

            public override void Send(string message, Colleague colleague)
            {
                if (_colleague1 == colleague)
                {
                    _colleague2.Notify(message);
                }
                else
                {
                    _colleague1.Notify(message);
                }
            }
        }

        public abstract class Colleague
        {
            protected Mediator Mediator;

            protected Colleague(Mediator mediator)
            {
                Mediator=mediator;
            }
        }

        public class ConcreteColleague1 : Colleague
        {
            public ConcreteColleague1(Mediator mediator) : base(mediator)
            {
            }

            public void Send(string message)
            {
                Mediator.Send(message,this);
            }

            public void Notify(string message)
            {
                Console.WriteLine($"Colleague1 gets message:{message}");
            }
        }

        public class ConcreteColleague2 : Colleague
        {
            public ConcreteColleague2(Mediator mediator) : base(mediator)
            {
            }

            public void Send(string message)
            {
                Mediator.Send(message,this);
            }

            public void Notify(string message)
            {
                Console.WriteLine($"Colleague2 gets message:{message}");
            }
        }
    }
}
