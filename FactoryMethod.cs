namespace Design_Pattern
{
    /// <summary>
    /// 工厂方法
    /// </summary>
    public  class FactoryMethod
    {
        public abstract class Food
        {
            public abstract void Print();
        }

        public class TomatoScrambleEggs : Food
        {
            public override void Print()
            {
                Console.WriteLine("西红柿炒鸡蛋");
            }
        }

        public class ShreddedPorkWithPotatoes : Food
        {
            public override void Print()
            {
                Console.WriteLine("土豆肉丝");
            }
        }

        public abstract class Creator
        {
            public abstract Food CreateFoodFactory();
        }

        public class TomatoScrambledEggsFactory : Creator
        {
            public override Food CreateFoodFactory()
            {
                return new TomatoScrambleEggs();
            }
        }

        public class ShreddedPorkWithPotatoesFactory : Creator
        {
            public override Food CreateFoodFactory()
            {
                return new ShreddedPorkWithPotatoes();
            }
        }
    }
}
