namespace Design_Pattern.AbstractFactory
{
    /// <summary>
    /// AbstractFactory Design Patter
    /// </summary>
    /// <remarks>
    /// 演示了创建对象的并行层次结构的抽象工厂模式。
    /// 对象创建已被抽象化，客户端代码中不需要硬编码的类名。
    /// https://dofactory.com/net/abstract-factory-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class AbstractFactory
        {
            public abstract AbstractProductA CreateProductA();
            public abstract AbstractProductB CreateProductB();
        }

        public class ConcreteFactory1 : AbstractFactory
        {
            public override AbstractProductA CreateProductA()
            {
                return new ProductA1();
            }

            public override AbstractProductB CreateProductB()
            {
                return new ProductB1();
            }
        }

        public class ConcreteFactory2 : AbstractFactory
        {
            public override AbstractProductA CreateProductA()
            {
                return new ProductA2();
            }

            public override AbstractProductB CreateProductB()
            {
                return new ProductB2();
            }
        }

        public abstract class AbstractProductA
        {

        }

        public abstract class AbstractProductB
        {
            public abstract void Interact(AbstractProductA a);
        }

        public class ProductA1 : AbstractProductA
        {

        }

        public class ProductB1 : AbstractProductB
        {
            public override void Interact(AbstractProductA a)
            {
                Console.WriteLine($"{this.GetType().Namespace} interacts with {a.GetType().Name}");
            }
        }

        public class ProductA2 : AbstractProductA
        {

        }

        public class ProductB2 : AbstractProductB
        {
            public override void Interact(AbstractProductA a)
            {
                Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
            }
        }

        public class Client
        {
            private AbstractProductA _abstractProductA;
            private AbstractProductB _abstractProductB;

            public Client(AbstractFactory factory)
            {
                _abstractProductA=factory.CreateProductA();
                _abstractProductB=factory.CreateProductB();
            }

            public void Run()
            {
                _abstractProductB.Interact(_abstractProductA);
            }
        }
    }
}
