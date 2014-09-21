namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Cant make sort operation on null collection!");
            }

            IList<T> sortedCollection = this.QuickSort(collection);

            collection.Clear();

            for (int i = 0; i < sortedCollection.Count; i++)
            {
                collection.Add(sortedCollection[i]);
            }
        }

        private IList<T> QuickSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            T pivotIndex = collection[collection.Count / 2];
            collection.Remove(pivotIndex);

            IList<T> arrayLess = new List<T>();
            IList<T> arrayGreater = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(pivotIndex) <= 0)
                {
                    arrayLess.Add(collection[i]);
                }
                else if (collection[i].CompareTo(pivotIndex) > 0)
                {
                    arrayGreater.Add(collection[i]);
                }
            }

            arrayLess = this.QuickSort(arrayLess);
            arrayGreater = this.QuickSort(arrayGreater);

            arrayLess.Add(pivotIndex);
            arrayLess = arrayLess.Concat(arrayGreater).ToList();

            return arrayLess;
        }
    }
}
