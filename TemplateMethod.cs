namespace Design_Pattern
{
    /// <summary>
    /// 模板方法
    /// </summary>
    public  class TemplateMethod
    {
        #region 示例一

        //public abstract class AbstractClass
        //{
        //    public abstract void PrimitiveOperation1();
        //    public abstract void PrimitiveOperation2();

        //    public void TemplateMethod()
        //    {
        //        PrimitiveOperation1();
        //        PrimitiveOperation2();
        //        Console.WriteLine();
        //    }
        //}

        //public class ConcreteClassA : AbstractClass
        //{
        //    public override void PrimitiveOperation1()
        //    {
        //        Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        //    }
        //    public override void PrimitiveOperation2()
        //    {
        //        Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        //    }
        //}

        //public class ConcreteClassB : AbstractClass
        //{
        //    public override void PrimitiveOperation1()
        //    {
        //        Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        //    }
        //    public override void PrimitiveOperation2()
        //    {
        //        Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        //    }
        //}
        #endregion

        #region 示例二
        public abstract class DataAccessor
        {
            public abstract void Connect();
            public abstract void Select();
            public abstract void Process(int top);

            public abstract void Disconnect();

            public void Run(int top)
            {
                Connect();
                Select();
                Process(top);
                Disconnect();
            }
        }

        public class Categories : DataAccessor
        {
            private List<string>? _categories;

            public override void Connect()
            {
                _categories = new List<string>();
            }

            public override void Disconnect()
            {
                _categories?.Clear();
            }

            public override void Process(int top)
            {
                Console.WriteLine("Categories --- ");
                for(var i = 0; i < top; i++)
                {
                    Console.WriteLine(_categories[i]);
                }
                Console.WriteLine();
            }

            public override void Select()
            {
                if (_categories != null)
                {
                    _categories.Add("Red");
                    _categories.Add("Green");
                    _categories.Add("Blue");
                    _categories.Add("Yellow");
                    _categories.Add("Purple");
                    _categories.Add("White");
                    _categories.Add("Black");
                }
            }
        }

        public class Products : DataAccessor
        {
            private List<string>? _products;

            public override void Connect()
            {
                _products = new List<string>();
            }

            public override void Disconnect()
            {
                _products?.Clear();
            }

            public override void Process(int top)
            {
                Console.WriteLine("Products --- ");
                for (var i = 0; i < top; i++)
                {
                    Console.WriteLine(_products?[i]);
                }
                Console.WriteLine();
            }

            public override void Select()
            {
                if (_products != null)
                {
                    _products.Add("Car");
                    _products.Add("Bike");
                    _products.Add("Boat");
                    _products.Add("Truck");
                    _products.Add("Moped");
                    _products.Add("Rollerskate");
                    _products.Add("Stroller");
                }
            }
        }
        #endregion
    }
}
