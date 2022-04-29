namespace Design_Pattern.Prototype
{
    /// <summary>
    /// Prototype Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了原型模式，其中通过复制预先存在的、用户定义的相同类型的颜色来创建新的颜色对象。
    /// https://dofactory.com/net/prototype-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class ColorPrototype
        {
            public abstract ColorPrototype Clone();
        }

        public class Color:ColorPrototype
        {
            private int _red;
            private int _green;
            private int _blue;

            public Color(int red,int green,int blue)
            {
                _red = red;
                _green = green;
                _blue = blue;
            }

            public override ColorPrototype Clone()
            {
                Console.WriteLine($"Cloning color RGB:{_red,3},{_green,3},{_blue,3}");
                return this.MemberwiseClone() as ColorPrototype;
            }
        }

        public class ColorManager
        {
            private Dictionary<string,ColorPrototype> _colors=new Dictionary<string,ColorPrototype>();

            public ColorPrototype this[string key]
            {
                get { return _colors[key]; }
                set{_colors.Add(key,value);}
            }
        }
    }
}
