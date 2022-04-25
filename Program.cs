// See https://aka.ms/new-console-template for more information

using Design_Pattern;

Console.WriteLine("23种设计模式:");

#region 单件模式(Singleton Pattern):

//Console.WriteLine("单件模式(Singleton Pattern):");
//var s1 = SingletonPattern.Instance();
//var s2 = SingletonPattern.Instance();
//if (s1.Equals(s2))
//{
//    Console.WriteLine("see,only one instance.");
//}
//Console.ReadKey();

#endregion

#region 抽象工厂(Abstract Factory):

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

//Console.ReadKey();
#endregion

#region 建造者模式(Builder):

//Console.WriteLine("建造者模式(Builder):");
//var pd = new Builder.PersonDirector();
//var person = pd.ConstructPerson(new Builder.ManBuilder());
//Console.WriteLine(person.Body);
//Console.WriteLine(person.Foot);
//Console.WriteLine(person.Head);
//Console.ReadKey();

#endregion

#region 工厂方法模式(Factory Method):

//Console.WriteLine("工厂方法模式(Factory Method):");
//var shreddedPorkWithPotatoesFactory = new FactoryMethod.ShreddedPorkWithPotatoesFactory();
//var tomatoScrambledEggsFactory = new FactoryMethod.TomatoScrambledEggsFactory();

//var tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
//tomatoScrambleEggs.Print();

//var shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
//shreddedPorkWithPotatoes.Print();
//Console.ReadKey();

#endregion

#region 原型模式(Prototype):

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
//Console.ReadKey();

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

//Console.ReadKey();

#endregion


#endregion

#region 适配器模式(Adapter Pattern):

//Console.WriteLine(" 适配器模式(Adapter Pattern):");
//var adapterClass = new AdapterPattern.AdapterClass();
//adapterClass.Request();
//Console.WriteLine();
//var adapterInterface = new AdapterPattern.AdapterInterface();    
//adapterInterface.Request();

//var defaultAdapter = new AdapterPattern.MyInteresting();
//defaultAdapter.F3();
//Console.ReadKey();

#endregion

#region 桥接模式(Bridge Pattern):

//var shapes = new BridgePattern.IShape[2];
//shapes[0] = new BridgePattern.CircleShape(1, 2, 3, new BridgePattern.DrawingApi1());
//shapes[1] = new BridgePattern.CircleShape(5, 7, 11, new BridgePattern.DrawingApi2());
//foreach (var shape in shapes)
//{
//    shape.ResizeByPercentage(2.5);
//    shape.Draw();
//}
//Console.ReadKey();

#endregion

#region 装饰模式(Decorator Pattern):

//Console.WriteLine("装饰模式(Decorator Pattern):");
//var thirdPartyOne = new DecoratorPattern.ThirdParty();
//var decorator1 = new DecoratorPattern.Decorator1(thirdPartyOne);
//var decorator2 = new DecoratorPattern.Decorator2(decorator1);
//Console.WriteLine(decorator2.SayMsg());
//Console.ReadKey();

#endregion

#region  外观模式(Facade Pattern)：

//Console.WriteLine("外观模式(Facade Pattern)：");
//FacadePattern.Facade facade = new FacadePattern.Facade();
//facade.MethodA();
//facade.MethodB();
//// Wait for user  
//Console.ReadKey();

#endregion

#region 享元模式(Flyweight Pattern):

Console.WriteLine("享元模式(Flyweight Pattern):");

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

//Console.ReadKey();
#endregion

#region 示例二

string document = "AAZZBBZB";
var chars = document.ToCharArray();

var factory = new FlyweightPattern.CharacterFactory();

//extrinsic state
int pointSize = 10;

//for each character use a flyweight object
foreach (var c in chars)
{
    pointSize++;
    var character = factory.GetCharacter(c);
    character.Display(pointSize);
}

Console.ReadKey();

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

//Console.ReadKey();

#endregion
