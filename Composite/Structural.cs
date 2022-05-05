namespace Design_Pattern.Composite
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了复合模式。
    /// 它允许创建一个树结构，其中单个节点被统一访问，无论它们是叶节点还是分支(复合)节点
    /// https://www.dofactory.com/net/composite-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Component
        {
            protected string Name;

            protected Component(string name)
            {
                this.Name = name;
            }

            public abstract void Add(Component c);

            public abstract void Remove(Component c);

            public abstract void Display(int depth);
        }

        public class Composite : Component
        {
            private readonly List<Component> _children=new List<Component>();
            public Composite(string name) : base(name)
            {
            }

            public override void Add(Component c)
            {
                _children.Add(c);
            }

            public override void Remove(Component c)
            {
                _children.Remove(c);
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new string('-',3)+Name);

                foreach (var component in _children)
                {
                    component.Display(depth+2);
                }
            }
        }

        public class Leaf : Component
        {
            public Leaf(string name) : base(name)
            {
            }

            public override void Add(Component c)
            {
                Console.WriteLine("Cannot add to a leaf");
            }

            public override void Remove(Component c)
            {
                Console.WriteLine("Cannot remove from a leaf");
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new String('-',depth)+Name);
            }
        }
    }
}
