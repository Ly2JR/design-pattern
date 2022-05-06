namespace Design_Pattern.State
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了状态模式。
    /// 它允许账户更具其愈合
    /// https://www.dofactory.com/net/state-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class State
        {
            protected Account account;
            protected double balance;
            protected double Interest;
            protected double LowerLimit;
            protected double UpperLimit;

            public Account Account
            {
                get => account;
                set => account = value;
            }

            public double Balance
            {
                get => balance;
                set => balance = value;
            }

            public abstract void Deposit(double amount);
            public abstract void Withdraw(double amount);
            public abstract void PayInterest();
        }

        public class RedState : State
        {
            private double _serviceFee;

            public RedState(State state)
            {
                balance=state.Balance;
                account = state.Account;
                Initialize();
            }

            private void Initialize()
            {
                Interest = 0.0;
                LowerLimit = -100.0;
                UpperLimit = 0.0;
                _serviceFee = 15.00;
            }

            public override void Deposit(double amount)
            {
                balance+=amount;
                StateChangeCheck();
            }

            public override void Withdraw(double amount)
            {
                amount = amount - _serviceFee;
                Console.WriteLine("No founds available for withdrawal!");
            }

            public override void PayInterest()
            {
                
            }

            private void StateChangeCheck()
            {
                if (balance > UpperLimit)
                {
                    account.State = new SilverState(this);
                }
            }
        }

        public class SilverState : State
        {
            public SilverState(State state) : this(state.Balance, state.Account)
            {

            }

            public SilverState(double balance, Account account)
            {
                this.balance = balance;
                this.account=account;
                Initialize();
            }

            private void Initialize()
            {
                Interest = 0.0;
                LowerLimit = 0.0;
                UpperLimit = 1000.0;
            }

            public override void Deposit(double amount)
            {
                balance += amount;
                StateChangeCheck();
            }

            public override void Withdraw(double amount)
            {
                balance -= amount;
                StateChangeCheck();
            }

            public override void PayInterest()
            {
                balance += Interest * balance;
                StateChangeCheck();
            }

            private void StateChangeCheck()
            {
                if (balance < LowerLimit)
                {
                    account.State = new RedState(this);
                }
                else if (balance > UpperLimit)
                {
                    account.State = new GoldState(this);
                }
            }
        }

        public class GoldState : State
        {
            public GoldState(State state) : this(state.Balance, state.Account)
            {

            }

            public GoldState(double balance, Account account)
            {
                this.balance=balance;
                this.account = account;
                Initialize();
            }

            private void Initialize()
            {
                Interest = 0.05;
                LowerLimit = 1000.0;
                UpperLimit = 10000000.0;
            }

            public override void Deposit(double amount)
            {
                balance+=amount;
                StateChangeCheck();
            }

            public override void Withdraw(double amount)
            {
                balance -= amount;
                StateChangeCheck();
            }

            public override void PayInterest()
            {
                balance+=Interest * balance;
                StateChangeCheck();
            }

            private void StateChangeCheck()
            {
                if (balance < 0.0)
                {
                    account.State = new RedState(this);
                }
                else if (balance < LowerLimit)
                {
                    account.State = new SilverState(this);
                }
            }
        }

        public class Account
        {
            private string _owner;

            public Account(string owner)
            {
                _owner=owner;
                State = new SilverState(0.0, this);
            }

            public double Balance => State.Balance;

            public State State { get; set; }

            public void Deposit(double amount)
            {
                State.Deposit(amount);
                Console.WriteLine($"Deposited {amount:C} --- ");
                Console.WriteLine($" Balance = {this.Balance:C}");
                Console.WriteLine($" Status = {this.State.GetType().Name}");
                Console.WriteLine("");
            }

            public void Withdraw(double amount)
            {
                State.Withdraw(amount);
                Console.WriteLine($"Withdraw {amount:C} --- ");
                Console.WriteLine($" Balance = {this.Balance:C}");
                Console.WriteLine($" Status = {this.State.GetType().Name}\n");
                Console.WriteLine("");
            }

            public void PayInterest()
            {
                State.PayInterest();
                Console.WriteLine("Interest Paid --- ");
                Console.WriteLine($" Balance = {this.Balance:C}");
                Console.WriteLine($" Status = {this.State.GetType().Name}\n");
                Console.WriteLine("");
            }
        }
    }
}
