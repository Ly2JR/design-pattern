namespace Design_Pattern
{
    public  class Builder
    {
        public interface IPersonBuilder
        {
            void BuildHead();
            void BuildBody();
            void BuildFoot();
            Person BuildPerson();
        }

        /// <summary>
        /// 具体构造工具
        /// </summary>
        public class ManBuilder : IPersonBuilder
        {
            private readonly Person _person;
            public ManBuilder()
            {
                _person = new Person();
            }

            public void BuildBody()
            {
                _person.Body = "建造男人的身体";
            }

            public void BuildFoot()
            {
                _person.Foot = "建造男人的脚";
            }

            public void BuildHead()
            {
                _person.Head = "建造男人的头";
            }

            public Person BuildPerson()
            {
                return _person;
            }
        }
        /// <summary>
        /// 建造者
        /// </summary>
        public class PersonDirector
        {
            public Person ConstructPerson(IPersonBuilder pb)
            {
                pb.BuildHead();
                pb.BuildBody();
                pb.BuildFoot();
                return pb.BuildPerson();
            }
        }
        /// <summary>
        /// Product
        /// </summary>
        public class Person
        {
            public string Head { get; set; }

            public string Body { get; set; }

            public string Foot { get; set; }
        }

        public class Man : Person {}
    }
}
