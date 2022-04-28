namespace Design_Pattern.Chain
{
    /// <summary>
    /// Chain of Responsibility Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了责任链模式，在该模式中，多个相关的经理和高管可以响应采购请求或将其交给上级。
    /// 每个职位都可以有自己的一套规则，他们可以批准这些订单。
    /// https://dofactory.com/net/chain-of-responsibility-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class Approver
        {
            protected Approver successor;

            public void SetSuccessor(Approver successor)
            {
                this.successor = successor;
            }

            public abstract void ProcessRequest(Purchase purchase);
        }

        public class Director:Approver
        {
            public override void ProcessRequest(Purchase purchase)
            {
                if (purchase.Amount < 10000)
                {
                    Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
                }
                else if (successor != null)
                {
                    successor.ProcessRequest(purchase);
                }
            }

            public class VicePresident : Approver
            {
                public override void ProcessRequest(Purchase purchase)
                {
                    if (purchase.Amount < 25000.0)
                    {
                        Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
                    }
                    else if (successor != null)
                    {
                        successor.ProcessRequest(purchase);
                    }
                }
            }

            public class President : Approver
            {
                public override void ProcessRequest(Purchase purchase)
                {
                    if (purchase.Amount < 100000.0)
                    {
                        Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
                    }
                    else
                    {
                        Console.WriteLine($"Request#{purchase.Number} requires an executive meeting!");
                    }
                }
            }
        }

        public class Purchase
        {
            public Purchase(int number,double amount,string purpose)
            {
                Number = number;
                Amount = amount;
                Purpose = purpose;
            }

            public int Number { get; set; }

            public double Amount { get; set; }

            public string Purpose { get; set; }
        }
    }
}
