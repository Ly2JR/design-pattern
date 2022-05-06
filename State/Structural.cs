namespace Design_Pattern.State
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了状态模式。
    /// 该模式允许账户根据其余额表现出不同的行为。
    /// 行为上的差异被委托给称为RedState、SilverState和GoldSate的State对象。
    /// 这些状态代码透支账户、初始账户和信誉良好的账户。
    /// https://www.dofactory.com/net/state-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class State
        {
            public abstract void Handle(Context context);
        }

        public class ConcreteStateA:State
        {
            public override void Handle(Context context)
            {
                context.State = new ConcreteStateB();
            }
        }

        public class ConcreteStateB : State
        {
            public override void Handle(Context context)
            {
                context.State = new ConcreteStateA();
            }
        }

        public class Context
        {
            private State _state;

            public Context(State state)
            {
                _state= state;
            }

            public State State
            {
                get => _state;
                set
                {
                    _state = value;
                    Console.WriteLine($"State:{_state.GetType().Name}");
                }
            }

            public void Request()
            {
                _state.Handle(this);
            }
        }
    }
}
