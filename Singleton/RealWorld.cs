namespace Design_Pattern.Singleton
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    /// <remarks>
    /// 将单列模式演示为LoadBalancing对象。只能创建该类的单个实例(单列),
    /// 因为服务器可能回动态地联机或脱机，并且每个请求都必须通过一个了解(网络)农场状态的对象。
    /// https://dofactory.com/net/singleton-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class LoadBalancer
        {
            private static LoadBalancer _instance = null!;
            private readonly List<string> _servers = new();
            readonly Random _random = new();

            //Lock synchronization object
            private static readonly object Locker=new();

            //Constructor (protected)
            protected LoadBalancer()
            {
                _servers.Add("ServerI");
                _servers.Add("ServerII");
                _servers.Add("ServerIII");
                _servers.Add("ServerIV");
                _servers.Add("ServerV");
            }

            public static LoadBalancer GetLoadBalancer()
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each 
                // time the method is invoked
                if (_instance == null)
                {
                    lock (Locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new LoadBalancer();
                        }
                    }
                }

                return _instance;
            }

            /// <summary>
            /// Simple,but effective random load balancer
            /// </summary>
            public string Server
            {
                get
                {
                    int r = _random.Next(_servers.Count);
                    return _servers[r];
                }
            }
        }
    }
}
