namespace Design_Pattern.TemplateMethod
{
    /// <summary>
    /// Template Method Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了模板方法。
    /// 它提供了方法的骨架调用序列。一个或多个步骤可以推迟到实现这些步骤的子类，而不改变整个调用顺序。
    /// https://www.dofactory.com/net/template-method-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class AbstractClass
        {
            public abstract void PrimitiveOperation1();
            public abstract void PrimitiveOperation2();

            public void TemplateMethod()
            {
                PrimitiveOperation1();
                PrimitiveOperation2();
                Console.WriteLine();
            }
        }

        public class ConcreteClassA : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
            }
        }

        public class ConcreteClassB : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
            }
        }
    }
}
