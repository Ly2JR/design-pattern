namespace Design_Pattern.Interpreter
{
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了解释器模式，它使用定义的语法提供处理已解析语句的解释器。
    /// https://dofactory.com/net/interpreter-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Context
        {
        }

        public abstract class AbstractExpression
        {
            public abstract void Interpret(Context context);
        }

        public class TerminalExpression : AbstractExpression
        {
            public override void Interpret(Context context)
            {
                Console.WriteLine("Called Terminal.Interpret()");
            }
        }

        public class NonterminalExpression : AbstractExpression
        {
            public override void Interpret(Context context)
            {
                Console.WriteLine("Called nonterminal.Interpret()");
            }
        }
    }
}
