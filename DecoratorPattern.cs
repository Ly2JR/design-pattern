namespace Design_Pattern
{
    /// <summary>
    /// 装饰模式
    /// </summary>
    public class DecoratorPattern
    {
        public interface IThirdParty
        {
            string SayMsg();
        }

        public class ThirdParty : IThirdParty
        {
            public string SayMsg()
            {
                return "Hello";
            }
        }

        public class Decorator1 : IThirdParty
        {
            private readonly IThirdParty _thirdParty;

            public Decorator1(IThirdParty thirdParty)
            {
                this._thirdParty = thirdParty;
            }

            public string SayMsg()
            {
                return $"##1{_thirdParty.SayMsg()}##1";
            }
        }

        public class Decorator2 : IThirdParty
        {
            private readonly IThirdParty _thirdParty;

            public Decorator2(IThirdParty thirdParty)
            {
                this._thirdParty = thirdParty;
            }

            public string SayMsg()
            {
                return $"##2{_thirdParty.SayMsg()}##2";
            }
        }
    }
}
