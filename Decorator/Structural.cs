namespace Design_Pattern.Decorator
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了装饰器模式，它动态地向现有对象添加额外的功能。
    /// https://www.dofactory.com/net/decorator-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Component
        {
            public abstract void Operation();
        }

        public class ConcreteComponent:Component
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteComponent.Operation()");
            }
        }

        public abstract class Decorator:Component
        {
            protected Component Component;

            public void SetComponent(Component component)
            {
                this.Component = component;
            }

            public override void Operation()
            {
                if (Component != null)
                {
                    Component.Operation();
                }
            }
        }

        public class ConcreteDecoratorA:Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorA.Operation()");
            }
        }

        public class ConcreteDecoratorB:Decorator
        {
            public override void Operation()
            {
                base.Operation();
                AddedBehavior();
                Console.WriteLine("ConcreteDecoratorB.Operation()");
            }

            void AddedBehavior()
            {

            }
        }
    }
}
