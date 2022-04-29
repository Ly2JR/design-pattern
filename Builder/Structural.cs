namespace Design_Pattern.Builder
{
    /// <summary>
    /// Builder Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了构建器模式，其中以逐步方式创建复杂对象。
    /// 构建过程可以创建不同的对象表示并提供对对象组装的高级控制
    /// https://dofactory.com/net/builder-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Director
        {
            public void Construct(Builder builder)
            {
                builder.BuildPartA();
                builder.BuildPartB();
            }
        }

        public abstract class Builder
        {
            public abstract void BuildPartA();
            public abstract void BuildPartB();
            public abstract Product GetResult();
        }

        public class ConcreteBuilder1:Builder
        {
            private readonly Product _product = new Product();

            public override void BuildPartA()
            {
                _product.Add("PartA");
            }

            public override void BuildPartB()
            {
                _product.Add("PartB");
            }

            public override Product GetResult()
            {
                return _product;
            }
        }

        public class ConcreteBuilder2:Builder
        {
            private readonly Product _product=new Product();

            public override void BuildPartA()
            {
                _product.Add("PartX");
            }

            public override void BuildPartB()
            {
                _product.Add("PartY");
            }

            public override Product GetResult()
            {
                return _product;
            }
        }

        public class Product
        {
            private readonly List<string> _parts = new List<string>();

            public void Add(string part)
            {
                _parts.Add(part);
            }

            public void Show()
            {
                Console.WriteLine("\n Product Parts -------");
                foreach (string part in _parts)
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
