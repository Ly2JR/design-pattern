namespace Design_Pattern
{
    /// <summary>
    /// 享元模式
    /// </summary>
    public class FlyweightPattern
    {
        #region 示例一

        // /// <summary>
        // /// The 'FlyweightFactory' class
        // /// </summary>
        // public class FlyweightFactory
        // {
        //     private Dictionary<string, Flyweight> Flyweights { get; } = new Dictionary<string, Flyweight>();
        //
        //     public FlyweightFactory()
        //     {
        //         Flyweights.Add("X", new ConcreteFlyweight());
        //         Flyweights.Add("Y", new ConcreteFlyweight());
        //         Flyweights.Add("Z", new ConcreteFlyweight());
        //     }
        //
        //     public Flyweight GetFlyweight(string key)
        //     {
        //         return Flyweights[key];
        //     }
        // }
        //
        // /// <summary>
        // /// The 'Flyweight' abstract class
        // /// </summary>
        // public abstract class Flyweight
        // {
        //     public abstract void Operation(int extrinsicstate);
        // }
        //
        // /// <summary>
        // /// The 'ConcreteFlyweight' class
        // /// </summary>
        // public class ConcreteFlyweight : Flyweight
        // {
        //     public override void Operation(int extrinsicstate)
        //     {
        //         Console.WriteLine($"ConcreteFlyweight:{extrinsicstate}");
        //     }
        // }
        //
        // public class UnsharedConcreteFlyweight : Flyweight
        // {
        //     public override void Operation(int extrinsicstate)
        //     {
        //         Console.WriteLine($"UnsharedConcreteFlyweight:{extrinsicstate}");
        //     }
        // }

        #endregion

        #region 示例二

        public class CharacterFactory
        {
            private Dictionary<char,Character> _characters = new Dictionary<char,Character>();

            public Character GetCharacter(char key)
            {
                //Uses "lazy initialization"
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    switch (key)
                    {
                        case 'A': character = new CharacterA();break;
                        case 'B': character = new CharacterB();break;
                        case 'Z': character = new CharacterZ();break;
                    }
                    _characters.Add(key,character);
                }

                return character;
            }
        }

        /// <summary>
        /// The 'Flyweight' abstract class
        /// </summary>
        public abstract class Character
        {
            protected char symbol;
            protected int width;
            protected int height;
            protected int ascent;
            protected int descent;
            protected int pointSize;

            public abstract void Display(int pointSize);
        }

        /// <summary>
        /// A 'ConcreteFlyweight' class
        /// </summary>
        public class CharacterA : Character
        {
            public CharacterA()
            {
                symbol = 'A';
                height = 100;
                width = 120;
                ascent = 70;
                descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine($"{symbol} (pointSize {pointSize})");
            }
        }

        public class CharacterB : Character
        {
            public CharacterB()
            {
                symbol = 'B';
                height = 100;
                width = 140;
                ascent = 72;
                descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine($"{symbol} (pointSize {pointSize})");
            }
        }

        public class CharacterZ : Character
        {
            public CharacterZ()
            {
                symbol = 'Z';
                height = 100;
                width = 100;
                ascent = 68;
                descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine($"{symbol} (pointSize {pointSize})");
            }
        }
        #endregion
    }
}
