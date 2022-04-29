namespace Design_Pattern.Singleton
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了单例模式，该模式确保只能创建类的单个实例(单例)
    /// https://dofactory.com/net/singleton-design-pattern#structural
    /// </remarks>
    public class Structural
    {
        public class Singleton
        {
            private static Singleton _instance;

            protected Singleton()
            {

            }

            public static Singleton Instance()
            {
                //Uses lazy initialization
                //Note:this is not thread safe.
                if (_instance == null)
                {
                    _instance=new Singleton();
                }

                return _instance;
            }
        }
    }
}
