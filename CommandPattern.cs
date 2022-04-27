
namespace Design_Pattern
{
    /// <summary>
    /// 命令模式
    /// </summary>
    public class CommandPattern
    {
        #region 示例一

        //public abstract class Command
        //{
        //    protected Receiver Receiver;

        //    protected Command(Receiver receiver)
        //    {
        //        this.Receiver= receiver;
        //    }

        //    public abstract  void Execute();
        //}

        //public class ConcreteCommand : Command
        //{
        //    public ConcreteCommand(Receiver receiver) : base(receiver)
        //    {

        //    }
        //    public override void Execute()
        //    {
        //        Receiver.Action();
        //    }
        //}

        //public class Receiver
        //{
        //    public void Action()
        //    {
        //        Console.WriteLine("Called Receiver.Action()");
        //    }
        //}

        //public class Invoker
        //{
        //    private Command _command = null!;

        //    public void SetCommand(Command command)
        //    {
        //        this._command=command;
        //    }

        //    public void ExecuteCommand()
        //    {
        //        _command.Execute();
        //    }
        //}

        #endregion

        #region 示例二

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

        #endregion
    }
}
