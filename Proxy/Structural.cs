namespace Design_Pattern.Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了代理模式，它提供了一个代表对象(代理)来控制对另一个类似对象的访问。
    /// https://www.dofactory.com/net/proxy-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Subject
        {
            public abstract void Request();
        }

        public class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }

        public class Proxy : Subject
        {
            private RealSubject _realSubject;
            public override void Request()
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
        }
    }
}
