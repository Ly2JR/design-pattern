using System.Text;

namespace Design_Pattern
{
    /// <summary>
    /// 组合模式
    /// </summary>
    public class CompositePattern
    {
        /// <summary>
        /// 抽象接口类
        /// </summary>
        public abstract class Company
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public Company() { }

            public Company(string name) : this()
            {
                this._name = name;
            }

            public abstract void Add(Company company);

            public abstract void Remove(Company company);

            public abstract void Display(int depth);
        }

        /// <summary>
        /// 枝节点类
        /// </summary>
        public class ConcreteCompany : Company
        {
            private readonly List<Company> _companyList;

            public ConcreteCompany()
            {
                _companyList = new List<Company>();
            }

            public ConcreteCompany(string name) : base(name)
            {
                _companyList = new List<Company>();
            }

            public override void Add(Company company)
            {
                _companyList.Add(company);
            }

            public override void Display(int depth)
            {
                var sb = new StringBuilder("");
                for (var i = 0; i < depth; i++)
                {
                    sb.Append("-");
                }
                Console.WriteLine($"{sb}{base.Name}");
                foreach (var c in _companyList)
                {
                   c.Display(depth+2);
                }
            }

            public override void Remove(Company company)
            {
                _companyList.Remove(company);
            }
        }

        /// <summary>
        /// 两个叶节点类
        /// </summary>
        public class HRDepartment : Company
        {
            public HRDepartment(string name) : base(name)
            {

            }
            public override void Add(Company company)
            {
               
            }

            public override void Remove(Company company)
            {
                
            }

            public override void Display(int depth)
            {
                var sb = new StringBuilder();
                for (var i = 0; i < depth; i++)
                {
                    sb.Append("-");
                }
                Console.WriteLine($"{sb}{base.Name}");
            }
        }

        public class FinanceDepartment : Company
        {
            public FinanceDepartment(string name):base(name){}

            public override void Add(Company company)
            {
                
            }

            public override void Remove(Company company)
            {
               
            }

            public override void Display(int depth)
            {
                var sb = new StringBuilder();
                for (var i = 0; i < depth; i++)
                {
                    sb.Append("-");
                }
                Console.WriteLine($"{sb}{base.Name}");
            }
        }
    }
}
