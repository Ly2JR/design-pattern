using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Flyweight
{
    public  class RealWorld
    {
        public class CharacterFactory
        {
            private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

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
                        case 'A': character = new CharacterA(); break;
                        case 'B': character = new CharacterB(); break;
                        case 'Z': character = new CharacterZ(); break;
                    }
                    _characters.Add(key, character);
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
    }
}
