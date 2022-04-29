using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Iterator
{
    public  class RealWorld
    {
        public class Item
        {
            public Item(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }

        public interface IAbstractCollection
        {
            Iterator CreateIterator();
        }

        public class Collection : IAbstractCollection
        {
            readonly List<Item> _items = new();

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
                _collection = collection;
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
                set => _step = value;
            }

            public bool IsDone => _current >= _collection.Count;
            public Item CurrentItem => _collection[_current];
        }
    }
}
