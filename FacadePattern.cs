namespace Design_Pattern
{
    public class FacadePattern
    {
        // "Subsystem ClassA" 
        public class SubSystemOne
        {
            public void MethodOne()
            {
                Console.WriteLine(" SubSystemOne Method");
            }
        }

        // Subsystem ClassB"   
        public class SubSystemTwo
        {
            public void MethodTwo()
            {
                Console.WriteLine(" SubSystemTwo Method");
            }
        }
        // Subsystem ClassC"  
        public class SubSystemThree
        {
            public void MethodThree()
            {
                Console.WriteLine(" SubSystemThree Method");
            }
        }
        // Subsystem ClassD"  
        public class SubSystemFour
        {
            public void MethodFour()
            {
                Console.WriteLine(" SubSystemFour Method");
            }
        }
        // "Facade"   
        public class Facade
        {
            readonly SubSystemOne _one;
            readonly SubSystemTwo _two;
            readonly SubSystemThree _three;
            readonly SubSystemFour _four;
            public Facade()
            {
                _one = new SubSystemOne();
                _two = new SubSystemTwo();
                _three = new SubSystemThree();
                _four = new SubSystemFour();
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
