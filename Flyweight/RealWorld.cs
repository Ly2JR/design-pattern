namespace Design_Pattern.Flyweight
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了享元模式。
    /// 其中相对少量的Character对象由可能具有许多字符的文档多次共享。
    /// https://www.dofactory.com/net/flyweight-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class CharacterFactory
        {
            private readonly Dictionary<char, Character> _characters = new Dictionary<char, Character>();

            public Character GetCharacter(char key)
            {
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    switch (key)
                    {
                        case 'A': character = new CharacterA(); break;
                        case 'B': character = new CharacterB(); break;
                        case 'Z': character = new CharacterZ(); break;
                    }
                    _characters.Add(key, character);
                }

                return character;
            }
        }

        public abstract class Character
        {
            protected char Symbol;
            protected int Width;
            protected int Height;
            protected int Ascent;
            protected int Descent;
            protected int PointSize;

            public abstract void Display(int pointSize);
        }

        public class CharacterA : Character
        {
            public CharacterA()
            {
                Symbol = 'A';
                Height = 100;
                Width = 120;
                Ascent = 70;
                Descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.PointSize = pointSize;
                Console.WriteLine($"{Symbol} (pointSize {pointSize})");
            }
        }

        public class CharacterB : Character
        {
            public CharacterB()
            {
                Symbol = 'B';
                Height = 100;
                Width = 140;
                Ascent = 72;
                Descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.PointSize = pointSize;
                Console.WriteLine($"{Symbol} (pointSize {pointSize})");
            }
        }

        public class CharacterZ : Character
        {
            public CharacterZ()
            {
                Symbol = 'Z';
                Height = 100;
                Width = 100;
                Ascent = 68;
                Descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.PointSize = pointSize;
                Console.WriteLine($"{Symbol} (pointSize {pointSize})");
            }
        }
    }
}
