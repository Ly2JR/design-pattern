namespace Design_Pattern.Facade
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了外观模式。
    /// 它为类的大型子系统提供了一个简化且统一的接口。
    /// https://www.dofactory.com/net/facade-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class SubSystemOne
        {
            public void MethodOne()
            {
                Console.WriteLine(" SubSystemOne Method");
            }
        }

        public class SubSystemTwo
        {
            public void MethodTwo()
            {
                Console.WriteLine(" SubSystemTwo Method");
            }
        }

        public class SubSystemThree
        {
            public void MethodThree()
            {
                Console.WriteLine(" SubSystemThree Method");
            }
        }

        public class SubSystemFour
        {
            public void MethodFour()
            {
                Console.WriteLine(" SubSystemFour Method");
            }
        }

        public class Facade
        {
            private readonly SubSystemOne _one;
            private readonly SubSystemTwo _two;
            private readonly SubSystemThree _three;
            private readonly SubSystemFour _four;

            public Facade()
            {
                _one=new SubSystemOne();
                _two=new SubSystemTwo();
                _three=new SubSystemThree();
                _four=new SubSystemFour();
            }

            public void MethodA()
            {
                Console.WriteLine("\nMethodA() ---- ");
                _one.MethodOne();
                _two.MethodTwo();
                _four.MethodFour();
            }

            public void MethodB()
            {
                Console.WriteLine("\nMethodB() ---- ");
                _two.MethodTwo();
                _three.MethodThree();
            }
        }
    }
}
