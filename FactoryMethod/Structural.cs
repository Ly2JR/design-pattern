namespace Design_Pattern.FactoryMethod
{
    /// <summary>
    /// Factory Method Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了Factory方法，它在创建不同对象方面提供了极大的灵活性。
    /// Abstract类可以提供一个默认对象，但每个子类都可以实例化该对象的扩展版本。
    /// https://dofactory.com/net/factory-method-design-pattern#structural
    ///</remarks>
    public class Structural
    {
        public abstract class Product
        {

        }

        public class ConcreteProductA:Product
        {
            
        }

        public class ConcreteProductB:Product
        {
            
        }

        public abstract class Creator
        {
            public abstract Product FactoryMethod();
        }

        public class ConcreteCreatorA:Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }

        public class ConcreteCreatorB : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }
    }
}
