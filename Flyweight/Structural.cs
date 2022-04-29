using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Flyweight
{
    public  class Structural
    {
        /// <summary>
        /// The 'FlyweightFactory' class
        /// </summary>
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

        /// <summary>
        /// The 'Flyweight' abstract class
        /// </summary>
        public abstract class Flyweight
        {
            public abstract void Operation(int extrinsicstate);
        }

        /// <summary>
        /// The 'ConcreteFlyweight' class
        /// </summary>
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
