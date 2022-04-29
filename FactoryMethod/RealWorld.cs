namespace Design_Pattern.FactoryMethod
{
    /// <summary>
    /// Factory Method Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了工厂方法，它在创建不同的文档时提供了灵活性。
    /// 派生的Document类Report和Resume实例化Document类的扩展版本。
    /// 这里，工厂方法在Document基类的构造函数中被调用。
    /// https://dofactory.com/net/factory-method-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class Page
        {
            
        }

        public class SkillsPage:Page
        {
            
        }

        public class EducationPage:Page
        {

        }

        public class ExperiencePage:Page
        {
        }

        public class IntroductionPage:Page
        {
            
        }

        public class ResultPage:Page
        {
            
        }

        public class ConclusionPage:Page
        {
            
        }

        public class SummaryPage:Page
        {
            
        }

        public class BibliographyPage:Page
        {
            
        }

        public abstract class Document
        {
            private readonly List<Page> _pages=new List<Page>();

            protected Document()
            {
                this.CreatePages();
            }

            public List<Page> Pages
            {
                get { return _pages; }
            }

            public abstract void CreatePages();
        }

        public class Resume:Document
        {
            public override void CreatePages()
            {
                Pages.Add(new SkillsPage());
                Pages.Add(new EducationPage());
                Pages.Add(new ExperiencePage());
            }
        }

        public class Report:Document
        {
            public override void CreatePages()
            {
                Pages.Add(new IntroductionPage());
                Pages.Add(new ResultPage());
                Pages.Add(new ConclusionPage());
                Pages.Add(new SummaryPage());
                Pages.Add(new BibliographyPage());
            }
        }
    }
}
