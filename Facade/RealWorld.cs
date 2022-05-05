namespace Design_Pattern.Facade
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    /// <remarks>
    /// 将Facade模式演示为MortgageApplication对象，该对象为测量申请人信用度的大型类子系统提供了一个简化的接口。
    /// https://www.dofactory.com/net/facade-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class Bank
        {
            public bool HasSufficientSavings(Customer c, int amount)
            {
                Console.WriteLine($"Check bank for {c.Name}");
                return true;
            }
        }

        public class Credit
        {
            public bool HasGoodCredit(Customer c)
            {
                Console.WriteLine($"Check credit for {c.Name}");
                return true;
            }
        }

        public class Loan
        {
            public bool HasNoBadLoans(Customer c)
            {
                Console.WriteLine($"Check loans for {c.Name}");
                return true;
            }
        }

        public class Customer
        {
            public Customer(string name)
            {
                Name=name;
            }

            public string Name { get; }
        }

        public class Mortgage
        {
            private readonly Bank _bank=new Bank();
            private readonly Loan _loan=new Loan();
            private readonly Credit _credit=new Credit();

            public bool IsEligible(Customer customer, int amount)
            {
                Console.WriteLine($"{customer.Name} applies for {amount:C} loan\n");
                var eligible = true;
                if (!_bank.HasSufficientSavings(customer, amount))
                {
                    eligible = false;
                }else if (!_loan.HasNoBadLoans(customer))
                {
                    eligible = false;
                }
                else if (!_credit.HasGoodCredit(customer))
                {
                    eligible = false;
                }

                return eligible;
            }
        }

    }
}
