namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Cant make sort operation on null collection!");
            }

            for (int p = 0; p < collection.Count - 1; p++)
            {
                int indexOfMinElement = p;

                for (int i = p + 1; i < collection.Count; i++)
                {
                    if (collection[i].CompareTo(collection[indexOfMinElement]) < 0)
                    {
                        indexOfMinElement = i;
                    }
                }

                if (indexOfMinElement > p)
                {
                    T swapValue = collection[p];
                    collection[p] = collection[indexOfMinElement];
                    collection[indexOfMinElement] = swapValue;
                }
            }
        }
    }
}
