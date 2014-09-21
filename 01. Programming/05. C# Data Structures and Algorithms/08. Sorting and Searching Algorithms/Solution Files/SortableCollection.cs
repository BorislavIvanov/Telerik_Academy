namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;
        private readonly Random randomGenerator;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
            this.randomGenerator = new Random();
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            bool isFound = false;

            for (int i = 0; i < this.Items.Count; i++)
            {
                if (!isFound && Items[i].CompareTo(item) == 0)
                {
                    isFound = true;
                }
            }

            return isFound;
        }

        public bool BinarySearch(T item)
        {
            bool isFound = false;

            int left = 0;
            int rigth = this.items.Count - 1;
            int middle = rigth / 2;

            while (left <= rigth)
            {

                if (item.CompareTo(this.items[middle]) == 0)
                {
                    isFound = true;
                    break;
                }
                else if (item.CompareTo(this.items[middle]) < 0)
                {
                    rigth = middle - 1;
                    middle = (rigth - left) / 2 + left;
                }
                else
                {
                    left = middle + 1;
                    middle = (rigth - left) / 2 + left;
                }
            }

            return isFound;
        }

        public void Shuffle()
        {
            for (int i = 0; i < this.Items.Count * 10; i++)
            {
                int randomIndexOne = default(int);
                int randomIndexTwo = default(int);

                do
                {
                    randomIndexOne = randomGenerator.Next(0, this.Items.Count);
                    randomIndexTwo = randomGenerator.Next(0, this.Items.Count);
                } while (randomIndexOne == randomIndexTwo);

                T swapper = this.items[randomIndexOne];
                this.items[randomIndexOne] = this.items[randomIndexTwo];
                this.items[randomIndexTwo] = swapper;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
