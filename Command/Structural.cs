namespace Design_Pattern.Command
{
    /// <summary>
    /// Command Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了命令模式。
    /// 该模式将请求存储为允许客户端执行或回放请求的对象。
    /// https://www.dofactory.com/net/command-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Command
        {
            protected Receiver Receiver;

            protected Command(Receiver receiver)
            {
                this.Receiver = receiver;
            }

            public abstract void Execute();
        }

        public class ConcreteCommand : Command
        {
            public ConcreteCommand(Receiver receiver) : base(receiver)
            {

            }
            public override void Execute()
            {
                Receiver.Action();
            }
        }

        public class Receiver
        {
            public void Action()
            {
                Console.WriteLine("Called Receiver.Action()");
            }
        }

        public class Invoker
        {
            private Command _command = null!;

            public void SetCommand(Command command)
            {
                this._command = command;
            }

            public void ExecuteCommand()
            {
                _command.Execute();
            }
        }
    }
}
