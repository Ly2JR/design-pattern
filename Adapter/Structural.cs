namespace Design_Pattern.Adapter
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了适配器模式，该模式将一个类的接口映射到另一个类，以便它们可以一起工作。
    /// 这些不兼容的类可能来自不同的库或框架。
    /// https://dofactory.com/net/adapter-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Target
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }

        public class Adapter:Target
        {
            private readonly Adaptee _adapter = new Adaptee();

            public override void Request()
            {
                _adapter.SpecificRequest();
            }
        }

        public class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}
