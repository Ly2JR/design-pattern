namespace Design_Pattern.Flyweight
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了享元模式。
    /// 其中相对少量的对象被不同的客户端多次共享。
    /// https://www.dofactory.com/net/flyweight-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class FlyweightFactory
        {
            private Dictionary<string, Flyweight> Flyweights { get; } = new Dictionary<string, Flyweight>();

            public FlyweightFactory()
            {
                Flyweights.Add("X", new ConcreteFlyweight());
                Flyweights.Add("Y", new ConcreteFlyweight());
                Flyweights.Add("Z", new ConcreteFlyweight());
            }

            public Flyweight GetFlyweight(string key)
            {
                return Flyweights[key];
            }
        }

        public abstract class Flyweight
        {
            public abstract void Operation(int extrinsicstate);
        }

        public class ConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicstate)
            {
                Console.WriteLine($"ConcreteFlyweight:{extrinsicstate}");
            }
        }

        public class UnsharedConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicstate)
            {
                Console.WriteLine($"UnsharedConcreteFlyweight:{extrinsicstate}");
            }
        }
    }
}
