namespace Design_Pattern.Strategy
{
    /// <summary>
    /// Strategy Design Pattern
    /// </summary>
    /// <remarks>
    /// 展示了以排序对象的形式封装排序算法的策略模式。
    /// 这允许客户端动态更改排序策略，包括Quicksort、Shellsort和Mergesort。
    /// https://www.dofactory.com/net/strategy-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public  abstract class SortStrategy
        {
            public abstract void Sort(List<string> list);
        }

        public class QuickSort:SortStrategy
        {
            public override void Sort(List<string> list)
            {
                list.Sort();//Default is Quicksort
                Console.WriteLine("QuickSorted list ");
            }
        }

        public class ShellSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.ShellSort();not-implemented
                Console.WriteLine("ShellSorted list ");
            }
        }

        public class MergeSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.MergeSort();not-implemented
               Console.WriteLine("MergeSorted list ");
            }
        }

        public class SortedList
        {
            private List<string> list=new List<string>();
            private SortStrategy sortStrategy;

            public void SetSortStrategy(SortStrategy sortStrategy)
            {
                this.sortStrategy= sortStrategy;
            }

            public void Add(string name)
            {
                list.Add(name);
            }

            public void Sort()
            {
                sortStrategy.Sort(list);

                foreach (var name in list)
                {
                    Console.WriteLine(" "+name);
                }
            }
        }
    }
}
