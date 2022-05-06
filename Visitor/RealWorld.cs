namespace Design_Pattern.Visitor
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了访问者模式。
    /// 其中两个对象遍历员工列表并对每个员工执行相同的操作。
    /// 这两个访问者对象定义了不同的操作---一个调整休假天数，另一个调整收入。
    /// https://www.dofactory.com/net/visitor-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public interface IVisitor
        {
            void Visit(Element element);
        }

        public class IncomeVisitor : IVisitor
        {
            public void Visit(Element element)
            {
                if (element is Employee employee)
                {
                    employee.Income *= 1.10;
                    Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income:{employee.Income:C}");
                }
            }
        }

        public class VacationVisitor:IVisitor
        {
            public void Visit(Element element)
            {
                if (element is Employee employee)
                {
                    employee.VacationDays += 3;

                    Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new Vacation days:{employee.VacationDays}");
                }
            }
        }

        public abstract class Element
        {
            public abstract void Accept(IVisitor visitor);
        }

        public class Employee:Element
        {
            public Employee(string name, double income, int vacationDays)
            {
                Name=name;
                Income=income;
                VacationDays = vacationDays;
            }

            public string Name { get; set; }

            public double Income { get; set; }

            public int VacationDays { get; set; }

            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class Employees
        {
            private readonly List<Employee> _employees=new List<Employee>();

            public void Attach(Employee employee)
            {
                _employees.Add(employee);
            }

            public void Detach(Employee employee)
            {
                _employees.Remove(employee);
            }

            public void Accept(IVisitor visitor)
            {
                foreach (var employee in _employees)
                {
                    employee.Accept(visitor);
                }
                Console.WriteLine();
            }
        }

        public class Clerk : Employee
        {
            public Clerk() : base("Kevin", 25000.0, 14)
            {
            }
        }

        public class Director : Employee
        {
            public Director() : base("Elly", 35000.0, 16)
            {
            }
        }

        public class President : Employee
        {
            public President() : base("Eric", 45000.0, 21)
            {
            }
        }
    }
}
