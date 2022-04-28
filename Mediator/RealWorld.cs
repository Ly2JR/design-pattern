namespace Design_Pattern.Mediator
{
    /// <summary>
    /// Mediator Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了中介者模式，促进了在聊天室注册的不同参与者之间的松散耦合通信。聊天室是进行所有交流的中心枢纽。
    /// 此时聊天室中仅实现了一对一的通信，但更改为一对多将是微不足道的。
    /// https://dofactory.com/net/mediator-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class AbstractChatRoom
        {
            public abstract void Register(Participant participant);

            public abstract void Send(string from, string to, string message);
        }

        public class ChatRoom : AbstractChatRoom
        {
            private readonly Dictionary<string,Participant> _participants = new();

            public override void Register(Participant participant)
            {
                if (!_participants.ContainsValue(participant))
                {
                    _participants[participant.Name] = participant;
                }

                participant.ChatRoom = this;
            }

            public override void Send(string from, string to, string message)
            {
                var participant = _participants[to];
                if (participant != null)
                {
                    participant.Receive(from, message);
                }
            }
        }

        public class Participant
        {
            private ChatRoom _chatRoom = null!;
            private readonly string _name;

            public Participant(string name)
            {
                _name=name;
            }

            public string Name => _name;

            public ChatRoom ChatRoom
            {
                get => _chatRoom;
                set => _chatRoom = value;
            }

            public void Send(string to, string message)
            {
                _chatRoom.Send(_name,to,message);
            }


            public virtual void Receive(string from, string message)
            {
                Console.WriteLine($"{from} to {Name}:'{message}'");
            }
        }

        public class Beatle : Participant
        {
            public Beatle(string name) : base(name)
            {
            }

            public override void Receive(string from, string message)
            {
                Console.Write("To a Beatle: ");

                base.Receive(from, message);
            }
        }

        public class NonBeatle : Participant
        {
            public NonBeatle(string name) : base(name)
            {
            }

            public override void Receive(string from, string message)
            {
                Console.Write("To a non-Beatle: ");
                base.Receive(from, message);
            }
        }
    }
}
