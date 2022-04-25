namespace Design_Pattern
{
    /// <summary>
    /// 适配器模式
    /// </summary>
    public  class AdapterPattern
    {
        interface ITarget
        {
            void Request();
        }

        public class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest.");
            }
        }

        /// <summary>
        /// 类适配器
        /// </summary>
        public class AdapterClass : Adaptee, ITarget
        {
            public void Request()
            {
                this.SpecificRequest();
            }
        }

        /// <summary>
        /// 对象适配器
        /// </summary>
        public class AdapterInterface : ITarget
        {

            private readonly Adaptee _adaptee;

            public AdapterInterface()
            {
                _adaptee = new Adaptee();
            }

            public void Request()
            {
                _adaptee.SpecificRequest();
            }
        }


        /// <summary>
        /// 缺省适配器
        /// </summary>
        public abstract class Target
        {
            public abstract void F1();
            public abstract void F2();
            public abstract void F3();
        }

        public class DefaultAdapter : Target
        {
            public override void F1()
            {

            }

            public override void F2()
            {

            }

            public override void F3()
            {

            }
        }

        public class MyInteresting : DefaultAdapter
        {
            public override void F3()
            {
                Console.WriteLine("我对F3()方法感兴趣，别的不管了！");
            }
        }
    }
}
