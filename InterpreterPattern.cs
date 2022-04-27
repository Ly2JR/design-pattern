using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    /// <summary>
    /// 解释器模式
    /// </summary>
    public class InterpreterPattern
    {

        #region Structural code

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

        #endregion

    }
}
