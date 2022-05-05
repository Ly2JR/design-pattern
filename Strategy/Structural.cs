namespace Design_Pattern.Strategy
{
    /// <summary>
    /// Strategy Design Pattern
    /// </summary>
    /// <remarks>
    /// 此代码演示了以对象形式封装功能的策略模式。
    /// 这允许客户端动态更改算法策略。
    /// https://www.dofactory.com/net/strategy-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Strategy
        {
            public abstract void AlgorithmInterface();
        }

        public class ConcreteStrategyA : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
            }
        }

        public class ConcreteStrategyB : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
            }
        }

        public class ConcreteStrategyC:Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
            }
        }

        public class Context
        {
            private readonly Strategy _strategy;

            public Context(Strategy strategy)
            {
                this._strategy = strategy;
            }

            public void ContextInterface()
            {
                _strategy.AlgorithmInterface();
            }
        }
    }
}
