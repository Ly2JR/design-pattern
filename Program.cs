// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using Singleton= Design_Pattern.Singleton;
using AbstractFactory = Design_Pattern.AbstractFactory;
using Builder=Design_Pattern.Builder;
using FactoryMethod=Design_Pattern.FactoryMethod;
using Prototype=Design_Pattern.Prototype;
using Adapter=Design_Pattern.Adapter;
using Bridge=Design_Pattern.Bridge;
using Decorator=Design_Pattern.Decorator;
using Composite=Design_Pattern.Composite;
using Facade=Design_Pattern.Facade;
using Flyweight=Design_Pattern.Flyweight;
using Proxy=Design_Pattern.Proxy;
using TemplateMethod=Design_Pattern.TemplateMethod;
using Command=Design_Pattern.Command;
using Iterator=Design_Pattern.Iterator;
using Observer=Design_Pattern.Observer;
using Interpreter = Design_Pattern.Interpreter;
using Mediator= Design_Pattern.Mediator;
using Chain=Design_Pattern.Chain;
using Memento=Design_Pattern.Memento;
using Strategy=Design_Pattern.Strategy;


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

//Console.WriteLine("Adapter:Structural code");

//var target = new Adapter.Structural.Adapter();
//target.Request();


//Console.WriteLine("\r\nAdapter:RealWorld code");

//var unknown = new Adapter.RealWorld.Compound();
//unknown.Display();

//var water = new Adapter.RealWorld.RichCompound("Water");
//water.Display();

//var benzene = new Adapter.RealWorld.RichCompound("Benzene");
//benzene.Display();

//var ethanol = new Adapter.RealWorld.RichCompound("Ethanol");
//ethanol.Display();

#endregion

#region 7. 桥接模式

//Console.WriteLine("Bridge:Structural code");

//var ab = new Bridge.Structural.RefinedAbstraction
//{
//    Implementor = new Bridge.Structural.ConcreteImplementorA()
//};
//ab.Operation();

//ab.Implementor = new Bridge.Structural.ConcreteImplementorB();
//ab.Operation();

//Console.WriteLine("\r\nRealWorld code");

//var customers = new Bridge.RealWorld.Customers
//{
//    Data = new Bridge.RealWorld.CustomersData("Chicago")
//};

//customers.Show();
//customers.Next();
//customers.Show();
//customers.Next();
//customers.Show();
//customers.Add("Henry Velasquez");
//customers.ShowAll();

#endregion

#region 8. 装饰模式

//Console.WriteLine("Decorator:Structural code ------ ");
//var c = new Decorator.Structural.ConcreteComponent();
//var d1 = new Decorator.Structural.ConcreteDecoratorA();
//var d2= new Decorator.Structural.ConcreteDecoratorB();

//d1.SetComponent(c);
//d2.SetComponent(d1);

//d2.Operation();

//Console.WriteLine("\r\nRealWorld code ------- ");

//var book = new Decorator.RealWorld.Book("Worley", "Inside ASP.NET", 10);
//book.Display();

//var video = new Decorator.RealWorld.Video("Spielberg", "Jaws", 23, 92);
//video.Display();

//Console.WriteLine("\nMaking video borrowable:");

//var borrowvideo = new Decorator.RealWorld.Borrowable(video);
//borrowvideo.BorrowItem("Customer #1");
//borrowvideo.BorrowItem("Customer #2");
//borrowvideo.Display();

#endregion

#region  9. 外观模式

//Console.WriteLine("Facade:Structural code ------ ");

//var facade = new Facade.Structural.Facade();
//facade.MethodA();
//facade.MethodB();

//Console.WriteLine("\r\nFacade:RealWorld code ------ ");

//var mortgage = new Facade.RealWorld.Mortgage();

//var customer = new Facade.RealWorld.Customer("Ann McKinsey");
//bool eligible = mortgage.IsEligible(customer, 125000);
//Console.WriteLine($"\n{customer.Name} has been {(eligible?"Approved":"Rejected")}");

#endregion

#region 10. 享元模式

//Console.WriteLine("Flyweight:Structural code ------ ");

////Arbitrary extrinsic state
//int extrinsicstate = 22;
//var factory = new Flyweight.Structural.FlyweightFactory();
////Work with different flyweight instances

//var fx = factory.GetFlyweight("X");
//fx.Operation(--extrinsicstate);

//var fy = factory.GetFlyweight("Y");
//fy.Operation(--extrinsicstate);

//var fz = factory.GetFlyweight("Z");
//fz.Operation(--extrinsicstate);


//Console.WriteLine("\r\nFlyweight:RealWorld code ------ ");

//var fu = new Flyweight.Structural.UnsharedConcreteFlyweight();
//fu.Operation(--extrinsicstate);

//string document = "AAZZBBZB";
//var chars = document.ToCharArray();

//var factory2 = new Flyweight.RealWorld.CharacterFactory();

////extrinsic state
//int pointSize = 10;

////for each character use a flyweight object
//foreach (var c in chars)
//{
//    pointSize++;
//    var character = factory2.GetCharacter(c);
//    character.Display(pointSize);
//}

#endregion

#region 11. 代理模式

//Console.WriteLine("Proxy:Structural code ------ ");

//var proxy = new Proxy.Structural.Proxy();
//proxy.Request();


//Console.WriteLine("\r\nProxy:RealWorld code ------ ");

//var proxy2 = new Proxy.RealWorld.MathProxy();
//Console.WriteLine($"4 + 2 = {proxy2.Add(4, 2)}");
//Console.WriteLine($"4 - 2 = {proxy2.Sub(4, 2)}");
//Console.WriteLine($"4 * 2 = {proxy2.Mul(4, 2)}");
//Console.WriteLine($"4 / 2 = {proxy2.Div(4, 2)}");

#endregion

#region 12. 模板方法

//Console.WriteLine("Template Method:Structural code ------ ");

//var aA = new TemplateMethod.Structural.ConcreteClassA();
//aA.TemplateMethod();

//var aB = new TemplateMethod.Structural.ConcreteClassB();
//aB.TemplateMethod();


//Console.WriteLine("\r\nTemplate Method:RealWorld code ------ ");


//var categories = new TemplateMethod.RealWorld.Categories();
//categories.Run(5);

//var products = new TemplateMethod.RealWorld.Products();
//products.Run(3);

#endregion

#region 13. 命令模式

//Console.WriteLine("Command:Structural code ------ ");

//var receiver = new Command.Structural.Receiver();
//var command = new Command.Structural.ConcreteCommand(receiver);
//var invoker = new Command.Structural.Invoker();
//invoker.SetCommand(command);
//invoker.ExecuteCommand();

//Console.WriteLine("\r\nCommand:RealWorld code ------ ");

//var user = new Command.RealWorld.User();
//user.Compute('+', 100);
//user.Compute('-', 50);
//user.Compute('*', 10);
//user.Compute('/', 2);

//user.Undo(4);
//user.Redo(3);

#endregion

#region 14. 迭代器模式

//Console.WriteLine("Iterator:Structural code ------ ");

//var aggregate = new Iterator.Structural.ConcreteAggregate
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


//Console.WriteLine("\r\nIterator:RealWorld code ------ ");

//var collection = new Iterator.RealWorld.Collection
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

//var iterator2 = collection.CreateIterator();
//iterator2.Step = 2;

//Console.WriteLine("Iterating over collection:");

//for (var item2 = iterator2.First(); !iterator2.IsDone; item2 = iterator2.Next())
//{
//    if (item2 != null) Console.WriteLine(item2.Name);
//}


#endregion

#region 15. 观察者模式

//Console.WriteLine("Observer:Structural code ------ ");

//var s = new Observer.Structural.ConcreteSubject();
//s.Attach(new Observer.Structural.ConcreteObserver(s, "x"));
//s.Attach(new Observer.Structural.ConcreteObserver(s, "y"));
//s.Attach(new Observer.Structural.ConcreteObserver(s, "z"));

//s.SubjectState = "ABC";
//s.Notify();


//Console.WriteLine("\r\nObserver:RealWorld code ------ ");

//var ibm = new Observer.RealWorld.IBM("IBM", 120.00);
//ibm.Attach(new Observer.RealWorld.Investor("Sorros"));
//ibm.Attach(new Observer.RealWorld.Investor("Berkshire"));

//ibm.Price = 120.10;
//ibm.Price = 121.00;
//ibm.Price = 120.50;
//ibm.Price = 120.75;


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

//Console.WriteLine("Mediator:Structural code ------- ");

//var m = new Mediator.Structural.ConcreteMediator();
//var c1 = new Mediator.Structural.ConcreteColleague1(m);
//var c2 = new Mediator.Structural.ConcreteColleague2(m);
//m.Colleague1 = c1;
//m.Colleague2 = c2;

//c1.Send("How are you?");
//c2.Send("Fine,thanks");

//Console.WriteLine("\r\nMediator:RealWorld code ------ ");

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

//yoko.Send("John", "Hi John!");
//paul.Send("Ringo", "All you need is love");
//ringo.Send("George", "My sweet Lord");
//paul.Send("John", "Can't buy me love");
//john.Send("Yoko", "My sweet love");

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

//Console.WriteLine("Memento:Structural code ------ ");

//var o = new Memento.Structural.Originator
//{
//    State = "On"
//};
//var c = new Memento.Structural.Caretaker
//{
//    Memento = o.CreateMemento()
//};

//o.State = "Off";
//o.SetMemento(c.Memento);

//Console.WriteLine("\r\nMemento:RealWorld code ------ ");

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

//Console.WriteLine("Composite:Structural code ------ ");

//var root = new Composite.Structural.Composite("root");
//root.Add(new Composite.Structural.Leaf("Leaf A"));
//root.Add(new Composite.Structural.Leaf("Leaf B"));

//var comp = new Composite.Structural.Composite("Composite X");
//comp.Add(new Composite.Structural.Leaf("Leaf XA"));
//comp.Add(new Composite.Structural.Leaf("Leaf XB"));
//root.Add(comp);
//root.Add(new Composite.Structural.Leaf("Leaf C"));

//var leaf = new Composite.Structural.Leaf("Leaf D");
//root.Add(leaf);
//root.Remove(leaf);

//root.Display(1);

//Console.WriteLine("\r\nComposite:RealWorld code ------ ");

//var root2 = new Composite.RealWorld.CompositeElement("Picture");
//root2.Add(new Composite.RealWorld.PrimitiveElement("Red Line"));
//root2.Add(new Composite.RealWorld.PrimitiveElement("Blue Circle"));
//root2.Add(new Composite.RealWorld.PrimitiveElement("Green Box"));

//var comp2 = new Composite.RealWorld.CompositeElement("Two Circles");
//comp2.Add(new Composite.RealWorld.PrimitiveElement("Black Circle"));
//comp2.Add(new Composite.RealWorld.PrimitiveElement("White Circle"));
//root2.Add(comp2);

//var pe = new Composite.RealWorld.PrimitiveElement("Yellow Line");
//root2.Add(pe);
//root2.Remove(pe);

//root2.Display(1);

#endregion

#region 21. 策略模式

Console.WriteLine("Strategy:Structural code");

Strategy.Structural.Context context;

context = new Strategy.Structural.Context(new Strategy.Structural.ConcreteStrategyA());
context.ContextInterface();

context = new Strategy.Structural.Context(new Strategy.Structural.ConcreteStrategyB());
context.ContextInterface();

context = new Strategy.Structural.Context(new Strategy.Structural.ConcreteStrategyC());
context.ContextInterface();

Console.WriteLine("\r\nStrategy:RealWorld code");

var studentRecords = new Strategy.RealWorld.SortedList();
studentRecords.Add("Samual");
studentRecords.Add("Jimmy");
studentRecords.Add("Sandra");
studentRecords.Add("Vivek");
studentRecords.Add("Anna");

studentRecords.SetSortStrategy(new Strategy.RealWorld.QuickSort());
studentRecords.Sort();

studentRecords.SetSortStrategy(new Strategy.RealWorld.ShellSort());
studentRecords.Sort();

studentRecords.SetSortStrategy(new Strategy.RealWorld.MergeSort());
studentRecords.Sort();

#endregion

#region 22. 策略模式


#endregion

#region 23. 策略模式


#endregion



Console.WriteLine("按任意键结束...");
Console.ReadKey();
