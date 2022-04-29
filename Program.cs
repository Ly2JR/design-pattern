// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;
using Singleton= Design_Pattern.Singleton;
using AbstractFactory = Design_Pattern.AbstractFactory;
using Builder=Design_Pattern.Builder;
using FactoryMethod=Design_Pattern.FactoryMethod;
using Prototype=Design_Pattern.Prototype;
using Adapter=Design_Pattern.Adapter;
using Mediator= Design_Pattern.Mediator;
using Interpreter= Design_Pattern.Interpreter;
using Chain=Design_Pattern.Chain;
using Memento=Design_Pattern.Memento;


#region 1. 单件模式

//Console.WriteLine("Singleton:Structural code");

//var s1 = Singleton.Structural.Singleton.Instance();
//var s2 = Singleton.Structural.Singleton.Instance();
////Test for same instance
//if (s1==s2)
//{
//    Console.WriteLine("Objects are the same instance");
//}

//Console.WriteLine("\r\nSingleton:RealWorld code");

//var b1 = Singleton.RealWorld.LoadBalancer.GetLoadBalancer();
//var b2 = Singleton.RealWorld.LoadBalancer.GetLoadBalancer();
//var b3= Singleton.RealWorld.LoadBalancer.GetLoadBalancer();
//var b4= Singleton.RealWorld.LoadBalancer.GetLoadBalancer();

////Same instance?
//if (b1 == b2 && b2 == b3 && b3 == b4)
//{
//    Console.WriteLine("Same instance\n");
//}

////Load balance 15 server requests

//var balancer = Singleton.RealWorld.LoadBalancer.GetLoadBalancer();
//for (var i = 0; i < 15; i++)
//{
//    var server = balancer.Server;
//    Console.WriteLine($"Dispatch Request to:{server}");
//}

#endregion

#region 2. 抽象工厂

//Console.WriteLine("AbstractFactory:Structural code");

////Abstract factory #1
//var factory1 = new AbstractFactory.Structural.ConcreteFactory1();
//var client1 = new AbstractFactory.Structural.Client(factory1);
//client1.Run();

////Abstract factory #2
//var factory2 = new AbstractFactory.Structural.ConcreteFactory2();
//var client2 = new AbstractFactory.Structural.Client(factory2);
//client2.Run();

//Console.WriteLine("\r\nAbstractFactory:RealWorld code");

//var africa = new AbstractFactory.RealWorld.AfricaFactory();
//var world = new AbstractFactory.RealWorld.AnimalWorld(africa);
//world.RunFoodChain();

//var america = new AbstractFactory.RealWorld.AmericalFactory();
//world = new AbstractFactory.RealWorld.AnimalWorld(america);
//world.RunFoodChain();

#endregion

#region 3. 建造者模式

//Console.WriteLine("Builder:Structural code");

//var director = new Builder.Structural.Director();

//var b1 = new Builder.Structural.ConcreteBuilder1();
//var b2 = new Builder.Structural.ConcreteBuilder2();

//director.Construct(b1);
//var p1 = b1.GetResult();
//p1.Show();

//director.Construct(b2);
//var p2 = b2.GetResult();
//p2.Show();

//Console.WriteLine("Builder:RealWorld code");

//Builder.RealWorld.VehicleBuilder builder;

//var shop = new Builder.RealWorld.Shop();
//builder = new Builder.RealWorld.ScooterBuilder();
//shop.Construct(builder);
//builder.Vehicle.Show();

//builder = new Builder.RealWorld.CarBuilder();
//shop.Construct(builder);
//builder.Vehicle.Show();

//builder = new Builder.RealWorld.MotorCycleBuilder();
//shop.Construct(builder);
//builder.Vehicle.Show();

#endregion

#region 4. 工厂方法模式

//Console.WriteLine("Factory Method:Structural code");

//var creators = new FactoryMethod.Structural.Creator[2];
//creators[0] = new FactoryMethod.Structural.ConcreteCreatorA();
//creators[1] = new FactoryMethod.Structural.ConcreteCreatorB();
//foreach (var creator in creators)
//{
//    var product = creator.FactoryMethod();
//    Console.WriteLine($"Created {product.GetType().Name}");
//}

//Console.WriteLine("\r\nFactory Method:RealWorld code");

//var documents = new FactoryMethod.RealWorld.Document[2];
//documents[0] = new FactoryMethod.RealWorld.Resume();
//documents[1] = new FactoryMethod.RealWorld.Report();

//foreach (var document in documents)
//{
//    Console.WriteLine($"\n{document.GetType().Name}--");
//    foreach (var page in document.Pages)
//    {
//        Console.WriteLine($" {page.GetType().Name}");
//    }
//}

#endregion

#region 5. 原型模式

//Console.WriteLine("Prototype:Structural code");

//var p1 = new Prototype.Structural.ConcretePrototype1("I");
//var c1 = (Prototype.Structural.ConcretePrototype1)p1.Clone();
//Console.WriteLine($"Cloned:{c1.Id}");

//var p2=new Prototype.Structural.ConcretePrototype2("II");
//var c2 = (Prototype.Structural.ConcretePrototype2)p2.Clone();
//Console.WriteLine($"Cloned:{c2.Id}");


//Console.WriteLine("\r\nPrototype:RealWorld code");

//var colorManager = new Prototype.RealWorld.ColorManager
//{
//    ["red"] = new Prototype.RealWorld.Color(255, 0, 0),
//    ["green"] = new Prototype.RealWorld.Color(0, 255, 0),
//    ["blue"] = new Prototype.RealWorld.Color(0, 0, 255)
//};

////User adds personalized colors
//colorManager["angry"]=new Prototype.RealWorld.Color(255, 54, 0);
//colorManager["peace"] = new Prototype.RealWorld.Color(128, 211, 128);
//colorManager["flame"] = new Prototype.RealWorld.Color(211, 34, 20);

////User clones selected colors
//var color1 = colorManager["red"].Clone() as Prototype.RealWorld.Color;
//var color2 = colorManager["peace"].Clone() as Prototype.RealWorld.Color;
//var color3= colorManager["flame"].Clone() as Prototype.RealWorld.Color;

#endregion

#region 6. 适配器模式

Console.WriteLine("Adapter:Structural code");

var target = new Adapter.Structural.Adapter();
target.Request();


Console.WriteLine("\r\nAdapter:RealWorld code");

var unknown = new Adapter.RealWorld.Compound();
unknown.Display();

var water = new Adapter.RealWorld.RichCompound("Water");
water.Display();

var benzene = new Adapter.RealWorld.RichCompound("Benzene");
benzene.Display();

var ethanol = new Adapter.RealWorld.RichCompound("Ethanol");
ethanol.Display();

#endregion

#region 7. 桥接模式

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

#region 8. 装饰模式

//Console.WriteLine("装饰模式(Decorator Pattern):");

//var thirdPartyOne = new DecoratorPattern.ThirdParty();
//var decorator1 = new DecoratorPattern.Decorator1(thirdPartyOne);
//var decorator2 = new DecoratorPattern.Decorator2(decorator1);
//Console.WriteLine(decorator2.SayMsg());

#endregion

#region  9. 外观模式

//Console.WriteLine("外观模式(Facade Pattern)：");

//FacadePattern.Facade facade = new FacadePattern.Facade();
//facade.MethodA();
//facade.MethodB();

#endregion

#region 10. 享元模式

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

#region 11. 代理模式

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

#region 12. 模板方法

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

#region 13. 命令模式

//Console.WriteLine("命令模式(Command Pattern):");

#region 示例一

//var receiver = new CommandPattern.Receiver();
//var command = new CommandPattern.ConcreteCommand(receiver);
//var invoker = new CommandPattern.Invoker();
//invoker.SetCommand(command);
//invoker.ExecuteCommand();

#endregion

#region 示例二

//var user = new CommandPattern.User();
//user.Compute('+',100);
//user.Compute('-',50);
//user.Compute('*',10);
//user.Compute('/',2);

//user.Undo(4);
//user.Redo(3);

#endregion

#endregion

#region 14. 迭代器模式

#region Structural Code

//var aggregate = new IteratorPattern.ConcreteAggregate
//{
//    [0] = "Item A",
//    [1] = "Item B",
//    [2] = "Item C",
//    [3] = "Item D"
//};

//var iterator = aggregate.CreateIterator();
//Console.WriteLine("Iterating over collection:");

//object? item = iterator.First();
//while (item != null)
//{
//    Console.WriteLine(item);
//    item = iterator.Next();
//}

#endregion

#region Real-word Code

//var collection = new IteratorPattern.Collection
//{
//    [0] = new("Item 0"),
//    [1] = new("Item 1"),
//    [2] = new("Item 2"),
//    [3] = new("Item 3"),
//    [4] = new("Item 4"),
//    [5] = new("Item 5"),
//    [6] = new("Item 6"),
//    [7] = new("Item 7"),
//    [8] = new("Item 8"),
//};

//var iterator = collection.CreateIterator();
//iterator.Step = 2;

//Console.WriteLine("Iterating over collection:");

//for (var item=iterator.First();!iterator.IsDone;item=iterator.Next())
//{
//    if (item != null) Console.WriteLine(item.Name);
//}
#endregion


#endregion

#region 15. 观察者模式

#region Structrual code

//var s = new ObserverPattern.ConcreteSubject();
//s.Attach(new ObserverPattern.ConcreteObserver(s,"x"));
//s.Attach(new ObserverPattern.ConcreteObserver(s, "y"));
//s.Attach(new ObserverPattern.ConcreteObserver(s, "z"));

//s.SubjectState = "ABC";
//s.Notify();

#endregion

#region Real-world code

//var ibm = new ObserverPattern.IBM("IBM", 120.00);
//ibm.Attach(new ObserverPattern.Investor("Sorros"));
//ibm.Attach(new ObserverPattern.Investor("Berkshire"));

//ibm.Price = 120.10;
//ibm.Price = 121.00;
//ibm.Price = 120.50;
//ibm.Price = 120.75;

#endregion

#endregion

#region 16. 解释器模式

//Console.WriteLine("Interpreter:Structural code");
//var structuralContext = new Interpreter.Structural.Context();
//var list = new List<Interpreter.Structural.AbstractExpression>
//{
//    new Interpreter.Structural.TerminalExpression(),
//    new Interpreter.Structural.NonterminalExpression(),
//    new Interpreter.Structural.TerminalExpression(),
//    new Interpreter.Structural.TerminalExpression()
//};

//foreach (var expression in list)
//{
//    expression.Interpret(structuralContext);
//}


//Console.WriteLine("\r\nInterpreter:RealWorld code");
//var roman = "MCMXXVIII";
//var realWorldContext = new Interpreter.RealWorld.Context(roman);

//var tree = new List<Interpreter.RealWorld.Expression>()
//{
//    new Interpreter.RealWorld.ThousandExpression(),
//    new Interpreter.RealWorld.HundredExpress(),
//    new Interpreter.RealWorld.TenExpress(),
//    new Interpreter.RealWorld.OneExpress(),
//};

//foreach (var exp in tree)
//{
//    exp.Interpret(realWorldContext);
//}

//Console.WriteLine($"{roman} = {realWorldContext.Output}");


#endregion

#region 17. 中介者模式

//Console.WriteLine("Mediator:Structural code");

//var m = new Mediator.Structural.ConcreteMediator();
//var c1 = new Mediator.Structural.ConcreteColleague1(m);
//var c2=new Mediator.Structural.ConcreteColleague2(m);
//m.Colleague1 = c1;
//m.Colleague2 = c2;

//c1.Send("How are you?");
//c2.Send("Fine,thanks");

//Console.WriteLine("\r\nMediator:RealWorld code");

//var chartRoom = new Mediator.RealWorld.ChatRoom();

//var george = new Mediator.RealWorld.Beatle("George");
//var paul = new Mediator.RealWorld.Beatle("Paul");
//var ringo = new Mediator.RealWorld.Beatle("Ringo");
//var john = new Mediator.RealWorld.Beatle("John");
//var yoko = new Mediator.RealWorld.NonBeatle("Yoko");

//chartRoom.Register(george);
//chartRoom.Register(paul);
//chartRoom.Register(ringo);
//chartRoom.Register(john);
//chartRoom.Register(yoko);

//yoko.Send("John","Hi John!");
//paul.Send("Ringo","All you need is love");
//ringo.Send("George","My sweet Lord");
//paul.Send("John","Can't buy me love");
//john.Send("Yoko","My sweet love");

#endregion

#region 18. 责任链模式

//Console.WriteLine("Chain:Structural code");

//var h1 = new Chain.Structural.ConcreteHandler1();
//var h2 = new Chain.Structural.ConcreteHandler2();
//var h3 = new Chain.Structural.ConcreteHandler3();
//h1.SetSuccessor(h2);
//h2.SetSuccessor(h3);

//int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
//foreach (var request in requests)
//{
//    h1.HandleRequest(request);
//}

//Console.WriteLine("\r\nChain:RealWorld code");

//var larry = new Chain.RealWorld.Director();
//var sam = new Chain.RealWorld.Director.VicePresident();
//var tammy = new Chain.RealWorld.Director.President();

//larry.SetSuccessor(sam);
//sam.SetSuccessor(tammy);

//var p = new Chain.RealWorld.Purchase(2034, 450, "Supplies");
//larry.ProcessRequest(p);

//p = new Chain.RealWorld.Purchase(2035, 32590.10, "Project X");
//larry.ProcessRequest(p);

//p = new Chain.RealWorld.Purchase(2036, 122100.00, "Project Y");
//larry.ProcessRequest(p);

#endregion

#region 19. 备忘录模式

//Console.WriteLine("Memento:Structural code");

//var o = new Memento.Structural.Originator
//{
//    State = "On"
//};
//var c =new Memento.Structural.Caretaker
//{
//    Memento = o.CreateMemento()
//};

//o.State = "Off";
//o.SetMemento(c.Memento);

//Console.WriteLine("\r\nMemento:RealWorld code");

//var s = new Memento.RealWorld.SaleProspect()
//{
//    Name = "Noel van Halen",
//    Phone = "(412) 256-0990",
//    Budget = 25000.0
//};

//var m = new Memento.RealWorld.ProspectMemory
//{
//    Memento = s.SaveMemento()
//};

//s.Name = "Leo Welch";
//s.Phone = "(310) 209-7111";
//s.Budget = 1000000.0;

//s.RestoreMemento(m.Memento);

#endregion

#region  20. 组合模式

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

#region 21. 策略模式


#endregion

#region 22. 策略模式


#endregion

#region 23. 策略模式


#endregion



Console.WriteLine("按任意键结束...");
Console.ReadKey();
