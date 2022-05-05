namespace Design_Pattern.Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了由MathProxy对象表示的Math对象的代理模式。
    /// https://www.dofactory.com/net/proxy-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public interface IMath
        {
            double Add(double x, double y);
            double Sub(double x, double y);
            double Mul(double x, double y);
            double Div(double x, double y);
        }

        public class Math : IMath
        {
            public double Add(double x, double y)
            {
                return x + y;
            }

            public double Sub(double x, double y)
            {
                return x - y;
            }

            public double Mul(double x, double y)
            {
                return x * y;
            }

            public double Div(double x, double y)
            {
                return x / y;
            }
        }

        public class MathProxy : IMath
        {
            private readonly Math _math = new Math();

            public double Add(double x, double y)
            {
                return _math.Add(x, y);
            }

            public double Div(double x, double y)
            {
                return _math.Div(x, y);
            }

            public double Mul(double x, double y)
            {
                return _math.Mul(x, y);
            }

            public double Sub(double x, double y)
            {
                return _math.Sub(x, y);
            }
        }
    }
}
