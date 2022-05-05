namespace Design_Pattern.Chain
{
    /// <summary>
    /// Chain of Responsibility
    /// </summary>
    /// <remarks>
    /// 演示了责任链模式。
    /// 其中为多个链接对象(链)提供了响应请求或将其交给下一个对象的机会
    /// https://dofactory.com/net/chain-of-responsibility-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Handler
        {
            protected Handler successor;

            public void SetSuccessor(Handler successor)
            {
                this.successor = successor;
            }

            public abstract void HandleRequest(int request);
        }

        public class ConcreteHandler1 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request is >= 0 and < 10)
                {
                    Console.WriteLine($"{this.GetType().Name} handled request {request}");

                }else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        public class ConcreteHandler2 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request is >= 10 and < 20)
                {
                    Console.WriteLine($"{this.GetType().Name} handled request {request}");

                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }

        public class ConcreteHandler3 : Handler
        {
            public override void HandleRequest(int request)
            {
                if (request is >= 20 and < 30)
                {
                    Console.WriteLine($"{this.GetType().Name} handled request {request}");

                }
                else if (successor != null)
                {
                    successor.HandleRequest(request);
                }
            }
        }
    }
}
