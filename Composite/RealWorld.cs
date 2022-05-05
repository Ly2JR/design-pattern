namespace Design_Pattern.Composite
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了用于构建由原始节点(线、圆等)和复合节点(组成更复杂元素的绘图元素组)组成的图形树结构的复合模式。
    /// https://www.dofactory.com/net/composite-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class DrawingElement
        {
            protected string Name;

            protected DrawingElement(string name)
            {
                this.Name= name;
            }

            public abstract void Add(DrawingElement d);

            public abstract void Remove(DrawingElement d);

            public abstract void Display(int indent);
        }

        public class PrimitiveElement:DrawingElement
        {
            public PrimitiveElement(string name) : base(name)
            {
            }

            public override void Add(DrawingElement d)
            {
                Console.WriteLine("Cannot add to a PrimitiveElement");
            }

            public override void Remove(DrawingElement d)
            {
                Console.WriteLine("Cannot remove from a PrimitiveElement");
            }

            public override void Display(int indent)
            {
               Console.WriteLine(new string('-',indent)+" "+Name);
            }
        }

        public class CompositeElement:DrawingElement
        {
            private readonly List<DrawingElement> _elements = new List<DrawingElement>();

            public CompositeElement(string name) : base(name)
            {
            }

            public override void Add(DrawingElement d)
            {
                _elements.Add(d);
            }

            public override void Remove(DrawingElement d)
            {
                _elements.Remove(d);
            }

            public override void Display(int indent)
            {
                Console.WriteLine(new string('-',indent)+"+ "+Name);

                foreach (var d in _elements)
                {
                    d.Display(indent+2);
                }
            }
        }
    }
}
