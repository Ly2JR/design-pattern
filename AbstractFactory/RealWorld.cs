namespace Design_Pattern.AbstractFactory
{
    /// <summary>
    /// Abstract Factory Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了使用不同工厂为电脑游戏创建不同的动物世界。
    /// 虽然大陆工厂创造的动物不同，但动物之间的互动是一样的。
    /// https://dofactory.com/net/abstract-factory-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class ContinentFactory
        {
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        }

        public class AfricaFactory:ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        public class AmericalFactory:ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }

        public abstract class Herbivore
        {

        }

        public abstract class Carnivore
        {
            public abstract void Eat(Herbivore h);
        }

        public class Wildebeest:Herbivore
        {
            
        }

        public class Lion:Carnivore
        {
            public override void Eat(Herbivore h)
            {
                //Eat Wildebeest
                Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
            }
        }

        public class Bison : Herbivore
        {

        }

        public class Wolf:Carnivore
        {
            public override void Eat(Herbivore h)
            {
                //Eat Bison
                Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
            }
        }

        public  class AnimalWorld
        {
            private Herbivore _herbivore;
            private Carnivore _carnivore;

            public AnimalWorld(ContinentFactory factory)
            {
                _carnivore = factory.CreateCarnivore();
                _herbivore = factory.CreateHerbivore();
            }

            public void RunFoodChain()
            {
                _carnivore.Eat(_herbivore);
            }
        }
    }
}
