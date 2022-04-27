namespace Design_Pattern
{
    /// <summary>
    /// 迭代器模式
    /// </summary>
    public class IteratorPattern
    {
        #region Structural code

        //public abstract class Aggregate
        //{
        //    public abstract Iterator CreateIterator();
        //}

        //public class ConcreteAggregate : Aggregate
        //{
        //    private readonly List<object> _items = new();

        //    public override Iterator CreateIterator()
        //    {
        //        return new ConcreteIterator(this);
        //    }

        //    public int Count => _items.Count;

        //    public object this[int index]
        //    {
        //        get => _items[index];
        //        set => _items.Insert(index,value);
        //    }
        //}

        //public abstract class Iterator
        //{
        //    public abstract object? First();
        //    public abstract object? Next();

        //    public abstract bool IsDone();

        //    public abstract object CurrentItem();
        //}

        //public class ConcreteIterator : Iterator
        //{
        //    private readonly ConcreteAggregate _aggregate;
        //    private int _current;

        //    public ConcreteIterator(ConcreteAggregate aggregate)
        //    {
        //        _aggregate=aggregate;
        //    }

        //    public override object? First()
        //    {
        //        return _aggregate[0];
        //    }

        //    public override object? Next()
        //    {
        //        object? ret = null;
        //        if (_current < _aggregate.Count - 1)
        //        {
        //            ret=_aggregate[++_current];
        //        }
        //        return ret;
        //    }

        //    public override bool IsDone()
        //    {
        //        return _current >= _aggregate.Count;
        //    }

        //    public override object CurrentItem()
        //    {
        //        return _aggregate[_current];
        //    }
        //}

        #endregion

        #region  Real-world code

        public class Item
        {
            public Item(string name)
            {
                Name=name;
            }

            public string Name { get; }
        }

        public interface IAbstractCollection
        {
            Iterator CreateIterator();
        }

        public class Collection : IAbstractCollection
        {
            readonly List<Item> _items=new();

            public Iterator CreateIterator()
            {
                return new Iterator(this);
            }

            public int Count => _items.Count;

            public Item this[int index]
            {
                get => _items[index];
                set => _items.Add(value);
            }
        }

        public interface IAbstractIterator
        {
            Item First();
            Item? Next();
            bool IsDone { get; }

            Item CurrentItem { get; }
        }

        public class Iterator : IAbstractIterator
        {
            private readonly Collection _collection;

            private int _current;
            private int _step = 1;

            public Iterator(Collection collection)
            {
                _collection=collection;
            }

            public Item First()
            {
                _current = 0;
                return _collection[_current];
            }

            public Item? Next()
            {
                _current += _step;
                if (!IsDone) return _collection[_current];
                return null;
            }
            public int Step
            {
                get => _step;
                set=> _step = value;
            }

            public bool IsDone => _current >= _collection.Count;
            public Item CurrentItem => _collection[_current];
        }

        #endregion
    }
}
