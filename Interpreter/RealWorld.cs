namespace Design_Pattern.Interpreter
{
    /// <summary>
    /// Interpreter Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了用于将罗马数字转为十进制的解释器模式。
    /// https://dofactory.com/net/interpreter-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class Context
        {
            private int _output;

            public Context(string input)
            {
                Input = input;
            }

            public string Input { get; set; }

            public int Output { get => _output; set => _output = value; }
        }

        public abstract class Expression
        {
            public void Interpret(Context context)
            {
                if (context.Input.Length == 0) return;

                if (context.Input.StartsWith(Nine()))
                {
                    context.Output += (9 * Multiplier());
                    context.Input = context.Input.Substring(2);
                }
                else if (context.Input.StartsWith(Four()))
                {
                    context.Output += (4 * Multiplier());
                    context.Input = context.Input.Substring(2);
                }
                else if (context.Input.StartsWith(Five()))
                {
                    context.Output += (5 * Multiplier());
                    context.Input = context.Input.Substring(1);
                }

                while (context.Input.StartsWith(One()))
                {
                    context.Output += (1 * Multiplier());
                    context.Input = context.Input.Substring(1);
                }
            }

            public abstract string One();

            public abstract string Four();

            public abstract string Five();

            public abstract string Nine();

            public abstract int Multiplier();
        }

        public class ThousandExpression : Expression
        {
            public override string Five()
            {
                return " ";
            }

            public override string Four()
            {
                return " ";
            }

            public override int Multiplier()
            {
                return 1000;
            }

            public override string Nine()
            {
                return " ";
            }

            public override string One()
            {
                return "M";
            }
        }

        public class HundredExpress : Expression
        {
            public override string Five()
            {
                return "D";
            }
            public override string Four()
            {
                return "CD";
            }

            public override int Multiplier()
            {
                return 100;
            }

            public override string Nine()
            {
                return "CM";
            }

            public override string One()
            {
                return "C";
            }
        }

        public class TenExpress : Expression
        {
            public override string One()
            {
                return "X";
            }

            public override string Four()
            {
                return "XL";
            }

            public override string Five()
            {
                return "L";
            }

            public override string Nine()
            {
                return "XC";
            }

            public override int Multiplier()
            {
                return 10;
            }
        }

        public class OneExpress : Expression
        {
            public override string One()
            {
                return "I";
            }

            public override string Four()
            {
                return "IV";
            }

            public override string Five()
            {
                return "V";
            }

            public override string Nine()
            {
                return "IX";
            }

            public override int Multiplier()
            {
                return 1;
            }
        }
    }
}
