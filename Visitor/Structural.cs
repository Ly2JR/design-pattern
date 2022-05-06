namespace Design_Pattern.Visitor
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了访问者模式。
    /// 其中对象遍历对象结构并对该结构中的每个节点执行相同的操作。
    /// 不同的访问者对象定义了不同的操作。
    /// https://www.dofactory.com/net/visitor-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Visitor
        {
            public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

            public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
        }

        public class ConcreteVisitor1 : Visitor
        {
            public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
            {
                Console.WriteLine($"{concreteElementA.GetType().Name} visited by {this.GetType().Name}");
            }

            public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
            {
                Console.WriteLine($"{concreteElementB.GetType().Name} visited by {this.GetType().Name}");
            }
        }

        public class ConcreteVisitor2:Visitor
        {
            public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
            {
                Console.WriteLine($"{concreteElementA.GetType().Name} visited by {this.GetType().Name}");
            }

            public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
            {
                Console.WriteLine($"{concreteElementB.GetType().Name} visited by {this.GetType().Name}");
            }
        }

        public abstract class Element
        {
            public abstract void Accept(Visitor visitor);
        }

        public class ConcreteElementA:Element
        {
            public override void Accept(Visitor visitor)
            {
                visitor.VisitConcreteElementA(this);
            }

            public void OperationA()
            {

            }
        }

        public class ConcreteElementB:Element
        {
            public override void Accept(Visitor visitor)
            {
                visitor.VisitConcreteElementB(this);
            }

            public void OperationB()
            {

            }
        }

        public class ObjectStructure
        {
            private readonly List<Element> _elements=new List<Element>();

            public void Attach(Element element)
            {
                _elements.Add(element);
            }

            public void Detach(Element element)
            {
                _elements.Remove(element);
            }

            public void Accept(Visitor visitor)
            {
                foreach (var element in _elements)
                {
                    element.Accept(visitor);
                }
            }
        }
    }
}
