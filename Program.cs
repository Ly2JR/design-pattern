// See https://aka.ms/new-console-template for more information

Console.WriteLine("23种设计模式:");

#region 1. 单件模式(Singleton Pattern):

//Console.WriteLine("单件模式(Singleton Pattern):");

//var s1 = SingletonPattern.Instance();
//var s2 = SingletonPattern.Instance();
//if (s1.Equals(s2))
//{
//    Console.WriteLine("see,only one instance.");
//}

#endregion

#region 2. 抽象工厂(Abstract Factory):

//Console.WriteLine("抽象工厂(Abstract Factory):");

//var winFactory = new AbstractFactory.WinFactory();
//var maxFactory = new AbstractFactory.MacFactory();
//var iButton=winFactory.CreateButton();
//iButton.Display();
//var iBorder= winFactory.CreateBorder();
//iBorder.Display();

//iButton = maxFactory.CreateButton();
//iButton.Display();
//iBorder = maxFactory.CreateBorder();
//iBorder.Display();

#endregion

#region 3. 建造者模式(Builder):

//Console.WriteLine("建造者模式(Builder):");

//var pd = new Builder.PersonDirector();
//var person = pd.ConstructPerson(new Builder.ManBuilder());
//Console.WriteLine(person.Body);
//Console.WriteLine(person.Foot);
//Console.WriteLine(person.Head);

#endregion

#region 4. 工厂方法模式(Factory Method):

//Console.WriteLine("工厂方法模式(Factory Method):");

//var shreddedPorkWithPotatoesFactory = new FactoryMethod.ShreddedPorkWithPotatoesFactory();
//var tomatoScrambledEggsFactory = new FactoryMethod.TomatoScrambledEggsFactory();

//var tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
//tomatoScrambleEggs.Print();

//var shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
//shreddedPorkWithPotatoes.Print();

#endregion

#region 5. 原型模式(Prototype):

//Console.WriteLine("原型模式(Prototype):");

#region 浅复制

//var redColor = new Prototype.RedColor
//{
//    Red = 255
//};
//Console.WriteLine($"RedColor - Red {redColor.Red}");

//var redColorClone = redColor.Clone();
//if (redColorClone != null)
//{
//    redColorClone.Red = 224;
//    Console.WriteLine($"RedColorClone - Red {redColorClone.Red}");
//}

//Console.WriteLine($"RedColor - Red {redColor.Red}");

#endregion

#region 深复复制

//var redColor = new Prototype.RedColor
//{
//    Red = 255,
//    F = new Prototype.Factory() { Name = "RedColor" }
//};
//Console.WriteLine($"RedColor - Factory:{redColor.F.Name}; Red - {redColor.Red}");

//var redColorClone = redColor.Clone();
//if (redColorClone != null)
//{
//    redColorClone.Red = 234;
//    if (redColorClone.F != null)
//    {
//        redColorClone.F.Name = "RedColorClone";
//        Console.WriteLine($"RedColorClone - Factory {redColorClone.F.Name}; Red - {redColorClone.Red}");
//    }
//}

#endregion

#endregion

#region 6. 适配器模式(Adapter Pattern):

//Console.WriteLine(" 适配器模式(Adapter Pattern):");

//var adapterClass = new AdapterPattern.AdapterClass();
//adapterClass.Request();
//Console.WriteLine();
//var adapterInterface = new AdapterPattern.AdapterInterface();    
//adapterInterface.Request();

//var defaultAdapter = new AdapterPattern.MyInteresting();
//defaultAdapter.F3();

#endregion

#region 7. 桥接模式(Bridge Pattern):

//Console.WriteLine("桥接模式(Bridge Pattern):");

//var shapes = new BridgePattern.IShape[2];
//shapes[0] = new BridgePattern.CircleShape(1, 2, 3, new BridgePattern.DrawingApi1());
//shapes[1] = new BridgePattern.CircleShape(5, 7, 11, new BridgePattern.DrawingApi2());
//foreach (var shape in shapes)
//{
//    shape.ResizeByPercentage(2.5);
//    shape.Draw();
//}

#endregion

#region 8. 装饰模式(Decorator Pattern):

//Console.WriteLine("装饰模式(Decorator Pattern):");

//var thirdPartyOne = new DecoratorPattern.ThirdParty();
//var decorator1 = new DecoratorPattern.Decorator1(thirdPartyOne);
//var decorator2 = new DecoratorPattern.Decorator2(decorator1);
//Console.WriteLine(decorator2.SayMsg());

#endregion

#region  9. 外观模式(Facade Pattern)：

//Console.WriteLine("外观模式(Facade Pattern)：");

//FacadePattern.Facade facade = new FacadePattern.Facade();
//facade.MethodA();
//facade.MethodB();

#endregion

#region 10. 享元模式(Flyweight Pattern):

//Console.WriteLine("享元模式(Flyweight Pattern):");

#region 示例一
////Arbitrary extrinsic state
//int extrinsicstate = 22;
//var factory = new FlyweightPattern.FlyweightFactory();
////Work with different flyweight instances

//var fx = factory.GetFlyweight("X");
//fx.Operation(--extrinsicstate);

//var fy = factory.GetFlyweight("Y");
//fy.Operation(--extrinsicstate);

//var fz= factory.GetFlyweight("Z");
//fz.Operation(--extrinsicstate);

//var fu = new FlyweightPattern.UnsharedConcreteFlyweight();
//fu.Operation(--extrinsicstate);
#endregion

#region 示例二

//string document = "AAZZBBZB";
//var chars = document.ToCharArray();

//var factory = new FlyweightPattern.CharacterFactory();

////extrinsic state
//int pointSize = 10;

////for each character use a flyweight object
//foreach (var c in chars)
//{
//    pointSize++;
//    var character = factory.GetCharacter(c);
//    character.Display(pointSize);
//}

#endregion
#endregion

#region 11. 代理模式(Proxy Pattern):

//Console.WriteLine("代理模式(Proxy Pattern):");

#region 示例一

//var proxy = new ProxyPattern.Proxy() ;
//proxy.Request();

#endregion

#region 示例二

//var proxy = new ProxyPattern.MathProxy();
//Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
//Console.WriteLine($"4 - 2 = {proxy.Sub(4, 2)}");
//Console.WriteLine($"4 * 2 = {proxy.Mul(4, 2)}");
//Console.WriteLine($"4 / 2 = {proxy.Div(4, 2)}");

#endregion

#endregion

#region 12. 模板方法(Template Method):

//Console.WriteLine("模板方法(Template Method):");

#region 示例一

//var aA = new TemplateMethod.ConcreteClassA();
//aA.TemplateMethod();

//var aB = new TemplateMethod.ConcreteClassB();
//aB.TemplateMethod();

#endregion

#region 示例二

//var categories = new TemplateMethod.Categories();
//categories.Run(5);

//var products=new TemplateMethod.Products();
//products.Run(3);

#endregion

#endregion

#region  组合模式(Composite Pattern):

//Console.WriteLine("组合模式(Composite Pattern):");

//CompositePattern.Company root = new CompositePattern.ConcreteCompany();
//root.Name = "北京总公司";
//root.Add(new CompositePattern.HRDepartment("总公司人力资源部"));
//root.Add(new CompositePattern.FinanceDepartment("总公司财务部"));

//CompositePattern.Company shandongCompany = new CompositePattern.ConcreteCompany("山东分公司");
//shandongCompany.Add(new CompositePattern.HRDepartment("山东分公司人力资源部"));
//shandongCompany.Add(new CompositePattern.FinanceDepartment("山东分公司财务部"));

//CompositePattern.Company zaozhuangCompany = new CompositePattern.ConcreteCompany("枣庄办事处");
//zaozhuangCompany.Add(new CompositePattern.FinanceDepartment("枣庄办事处财务部"));
//zaozhuangCompany.Add(new CompositePattern.HRDepartment("枣庄办事处人力资源部"));

//CompositePattern.Company jinanCompany = new CompositePattern.ConcreteCompany("济南办事处");
//jinanCompany.Add(new CompositePattern.FinanceDepartment("济南办事处财务部"));
//jinanCompany.Add(new CompositePattern.HRDepartment("济南办事处人力资源部"));

//shandongCompany.Add(jinanCompany);
//shandongCompany.Add(zaozhuangCompany);

//CompositePattern.Company huadongCompany = new CompositePattern.ConcreteCompany("上海华东分公司");
//huadongCompany.Add(new CompositePattern.FinanceDepartment("上海华东分公司财务部"));
//huadongCompany.Add(new CompositePattern.HRDepartment("上海华东分公司人力资源部"));

//CompositePattern.Company hangzhouCompany = new CompositePattern.ConcreteCompany("杭州办事处");
//hangzhouCompany.Add(new CompositePattern.FinanceDepartment("杭州办事处财务部"));
//hangzhouCompany.Add(new CompositePattern.HRDepartment("杭州办事处人力资源部"));

//CompositePattern.Company nanjingCompany = new CompositePattern.ConcreteCompany("南京办事处");
//nanjingCompany.Add(new CompositePattern.FinanceDepartment("南京办事处财务部"));
//nanjingCompany.Add(new CompositePattern.HRDepartment("南京办事处人力资源部"));

//huadongCompany.Add(hangzhouCompany);
//huadongCompany.Add(nanjingCompany);

//root.Add(shandongCompany);
//root.Add(huadongCompany);
//root.Display(0);

#endregion

Console.WriteLine("按任意键结束...");
Console.ReadKey();
