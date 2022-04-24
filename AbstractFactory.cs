using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    public class AbstractFactory
    {
        public interface IButton
        {
            void Display();
        }

        public interface IBorder
        {
            void Display();
        }

        //实现抽象类
        public class MacButton : IButton
        {
            public void Display()
            {
                Console.WriteLine(nameof(MacButton));
            }
        }
        public class MacBorder : IBorder
        {
            public void Display()
            {
                Console.WriteLine(nameof(MacBorder));
            }
        }
        public class WinButton : IButton
        {
            public void Display()
            {
                Console.WriteLine(nameof(WinButton));
            }
        }
        public class WinBorder : IBorder
        {
            public void Display()
            {
                Console.WriteLine(nameof(WinBorder));
            }
        }

        /// <summary>
        /// 实现工厂
        /// </summary>
        public class MacFactory
        {
            public IButton CreateButton()
            {
                return new MacButton();
            }
            public IBorder CreateBorder()
            {
                return new MacBorder();
            }
        }

        public  class WinFactory
        {
            public IButton CreateButton()
            {
                return new WinButton();
            }
            public IBorder CreateBorder()
            {
                return new WinBorder();
            }
        }
    }
}
