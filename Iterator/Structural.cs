namespace Design_Pattern.Iterator
{
    /// <summary>
    /// Iterator Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了迭代器模式。
    /// 该模式提供了一种遍历(迭代)项目集合的方法，而无需详细说明集合的底层结构。
    /// https://www.dofactory.com/net/iterator-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public abstract class Aggregate
        {
            public abstract Iterator CreateIterator();
        }

        public class ConcreteAggregate : Aggregate
        {
            private readonly List<object> _items = new();

            public override Iterator CreateIterator()
            {
                return new ConcreteIterator(this);
            }

            public int Count => _items.Count;

            public object this[int index]
            {
                get => _items[index];
                set => _items.Insert(index, value);
            }
        }

        public abstract class Iterator
        {
            public abstract object? First();
            public abstract object? Next();

            public abstract bool IsDone();

            public abstract object CurrentItem();
        }

        public class ConcreteIterator : Iterator
        {
            private readonly ConcreteAggregate _aggregate;
            private int _current;

            public ConcreteIterator(ConcreteAggregate aggregate)
            {
                _aggregate = aggregate;
            }

            public override object? First()
            {
                return _aggregate[0];
            }

            public override object? Next()
            {
                object? ret = null;
                if (_current < _aggregate.Count - 1)
                {
                    ret = _aggregate[++_current];
                }
                return ret;
            }

            public override bool IsDone()
            {
                return _current >= _aggregate.Count;
            }

            public override object CurrentItem()
            {
                return _aggregate[_current];
            }
        }
    }
}
