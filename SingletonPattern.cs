namespace Design_Pattern
{
    /// <summary>
    /// 单列模式
    /// </summary>
    public class SingletonPattern
    {
        //#region  方式一

        //private static SingletonPattern? _theSingleton;

        //private SingletonPattern() { }

        //public static SingletonPattern Instance()
        //{
        //    return _theSingleton ??= new SingletonPattern();
        //}


        //#endregion

        #region  方式二

        private static readonly SingletonPattern TheSingleton = new SingletonPattern();

        private SingletonPattern() { }

        public static SingletonPattern Instance()
        {
            return TheSingleton;
        }

        #endregion
    }
}
