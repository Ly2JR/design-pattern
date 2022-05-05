namespace Design_Pattern.Decorator
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了装饰器模式。
    /// 其中"可借"功能被添加到现有的图书馆项目(书籍和视频)中.
    /// https://www.dofactory.com/net/decorator-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public abstract class LibraryItem
        {
            public int NumCopies { get; set; }

            public abstract void Display();
        }

        public class Book:LibraryItem
        {
            private readonly string _author;
            private readonly string _title;

            public Book(string author, string title, int numCopies)
            {
                _author = author;
                _title = title;
                NumCopies = numCopies;
            }

            public override void Display()
            {
                Console.WriteLine("\nBook ------ ");
                Console.WriteLine($" Author:{_author}");
                Console.WriteLine($" Title:{_title}");
                Console.WriteLine($"# Copies: {NumCopies}");
            }
        }

        public class Video:LibraryItem
        {
            private readonly string _director;
            private readonly string _title;
            private readonly int _playTime;

            public Video(string director, string title, int numCopies, int playTime)
            {
                _director=director;
                _title=title;
                _playTime=playTime;
                NumCopies=numCopies;
            }

            public override void Display()
            {
                Console.WriteLine("\nVideo ------ ");
                Console.WriteLine($" Director: {_director}");
                Console.WriteLine($" Title: {_title}");
                Console.WriteLine($" # Copies: {NumCopies}");
                Console.WriteLine($" Playtime: {_playTime}\n");
            }
        }

        public abstract class Decorator:LibraryItem
        {
            protected LibraryItem libraryItem;

            protected Decorator(LibraryItem libraryItem)
            {
                this.libraryItem = libraryItem;
            }

            public override void Display()
            {
                libraryItem.Display();
            }
        }

        public class Borrowable:Decorator
        {
            protected readonly List<string> borrowers = new List<string>();
            public Borrowable(LibraryItem libraryItem) : base(libraryItem)
            {
            }

            public void BorrowItem(string name)
            {
                borrowers.Add(name);
                libraryItem.NumCopies--;
            }

            public void ReturnItem(string name)
            {
                borrowers.Remove(name);
                libraryItem.NumCopies++;
            }

            public override void Display()
            {
                base.Display();
                foreach (var borrow in borrowers)
                {
                    Console.WriteLine($" borrower:{borrow}");
                }
            }
        }
    }
}
