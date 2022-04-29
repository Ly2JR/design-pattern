using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Command
{
    public  class Structural
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
