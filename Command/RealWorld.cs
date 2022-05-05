namespace Design_Pattern.Command
{
    /// <summary>
    /// Command Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了在一个简单的计算器中使用的命令模式，它具有无线数量的撤销和重做。
    /// 请注意，在C#中,"运算符"一词是关键字。用`@`作为前缀允许将其用作标识符。
    /// https://www.dofactory.com/net/command-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class Command
        {
            public abstract void Execute();

            public abstract void UnExecute();
        }

        public class CalculatorCommand : Command
        {
            private readonly char _operator;
            private readonly int _operand;
            private readonly Calculator _calculator;

            public CalculatorCommand(Calculator calculator, char @operator, int operand)
            {
                _calculator = calculator;
                _operator = @operator;
                _operand = operand;
            }

            public char Operator => _operator;

            public int Operand => _operand;

            public override void Execute()
            {
                _calculator.Operation(_operator, _operand);
            }

            public override void UnExecute()
            {
                _calculator.Operation(Undo(_operator), _operand);
            }

            private char Undo(char @operator)
            {
                switch (@operator)
                {
                    case '+': return '-';
                    case '-': return '+';
                    case '*': return '/';
                    case '/': return '*';
                    default: throw new ArgumentException("@operator");
                }
            }
        }

        public class Calculator
        {
            private int _current;

            public void Operation(char @operator, int operand)
            {
                switch (@operator)
                {
                    case '+': _current += operand; break;
                    case '-': _current -= operand; break;
                    case '*': _current *= operand; break;
                    case '/': _current /= operand; break;
                }
                Console.WriteLine($"Current value={_current,3} (following {@operator} {operand})");
            }
        }

        public class User
        {
            readonly Calculator _calculator = new();
            readonly List<Command> _commands = new();
            int _current;

            public void Redo(int levels)
            {
                Console.WriteLine($"\n--- Redo {levels} levels ");
                for (var i = 0; i < levels; i++)
                {
                    if (_current < _commands.Count - 1)
                    {
                        var command = _commands[_current++];
                        command.Execute();
                    }
                }
            }

            public void Undo(int levels)
            {
                Console.WriteLine($"\n--- Undo {levels} levels");

                for (int i = 0; i < levels; i++)
                {
                    if (_current > 0)
                    {
                        var command = _commands[--_current];
                        command.UnExecute();
                    }
                }
            }

            public void Compute(char @operator, int operand)
            {
                var command = new CalculatorCommand(_calculator, @operator, operand);
                command.Execute();

                _commands.Add(command);
                _current++;
            }
        }
    }
}
