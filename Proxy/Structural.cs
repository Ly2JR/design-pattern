using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Proxy
{
    public  class Structural
    {
        /// <summary>
        /// The 'subject' abstract class
        /// </summary>
        public abstract class Subject
        {
            public abstract void Request();
        }

        public class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }

        public class Proxy : Subject
        {
            private RealSubject _realSubject;
            public override void Request()
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
        }
    }
}
