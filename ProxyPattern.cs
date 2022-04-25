namespace Design_Pattern
{
    /// <summary>
    /// 代理模式
    /// </summary>
    public class ProxyPattern
    {

        #region 示例一
        ///// <summary>
        ///// The 'subject' abstract class
        ///// </summary>
        //public abstract class Subject
        //{
        //    public abstract void Request();
        //}

        //public class RealSubject : Subject
        //{
        //    public override void Request()
        //    {
        //        Console.WriteLine("Called RealSubject.Request()");
        //    }
        //}

        //public class Proxy : Subject
        //{
        //    private RealSubject _realSubject;
        //    public override void Request()
        //    {
        //        if (_realSubject == null)
        //        {
        //            _realSubject = new RealSubject();
        //        }
        //        _realSubject.Request();
        //    }
        //}
        #endregion

        #region 示例二

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
                return x+ y; 
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
            private Math _math=new Math();

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
        #endregion
    }
}
