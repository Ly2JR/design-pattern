namespace Design_Pattern.Bridge
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了将接口于其实现分离(解耦)的桥接模式。
    /// 实现可以在不改变使用对象抽象的客户端的情况下发展。
    /// https://www.dofactory.com/net/bridge-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Abstraction
        {
            protected Implementor implementor = null!;

            public Implementor Implementor
            {
                set => implementor = value;
            }

            public virtual void Operation()
            {
                implementor.Operation();
            }
        }

        public abstract class Implementor
        {
            public abstract void Operation();
        }

        public class RefinedAbstraction:Abstraction
        {
            public override void Operation()
            {
                implementor.Operation();
            }
        }

        public class ConcreteImplementorA : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorA Operation");
            }
        }

        public class ConcreteImplementorB:Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorB Operation");
            }
        }
    }
}
