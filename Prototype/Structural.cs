namespace Design_Pattern.Prototype
{
    /// <summary>
    /// Prototype Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了原型模式，其中通过复制同一类的预先存在的对象(原型)来创建新对象。
    /// https://dofactory.com/net/prototype-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Prototype
        {
            private string _id;

            protected Prototype(string id)
            {
                _id = id;
            }

            public string Id
            {
                get { return _id; }
            }

            public abstract Prototype Clone();
        }

        public class ConcretePrototype1 : Prototype
        {
            public ConcretePrototype1(string id) : base(id)
            {
            }

            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }

        public class ConcretePrototype2:Prototype
        {
            public ConcretePrototype2(string id) : base(id)
            {
            }

            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }
    }
}
