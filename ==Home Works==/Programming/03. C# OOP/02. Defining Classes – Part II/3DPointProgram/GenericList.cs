using System;
using System.Text;

namespace _3DPointProgram
{
    public class GenericList<T> where T : IComparable // Task 5
    {
        private T[] elements;
        private int count = 0;
        private const int defaultCapacity = 4;

        public GenericList()
            : this(defaultCapacity) // Task 5
        {
        }
        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        private void StretchCapacity() // Task 6
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, tempArray, elements.Length);
            elements = tempArray;
        }

        public void AddElement(T element) // Task 5
        {
            if (this.count >= this.elements.Length)
            {
                StretchCapacity();
            }
            else
            {
                this.elements[this.count] = element;
                count++;
            }
        }

        public void RemoveElementAtIndex(int index) // Task 5
        {
            T[] tempArray = (T[])elements.Clone();
            elements = new T[tempArray.Length];

            for (int i = 0, j = 0; i < tempArray.Length; i++, j++)
            {
                if (i != index)
                {
                    elements[j] = tempArray[i];
                }
                else
                {
                    j--;
                }
            }
        }

        public int FindElement(T value) // Task 5
        {
            int index = Array.IndexOf(elements, value);
            return index;
        }

        public void InsertElement(int index, T element) // Task 5
        {
            if (count >= elements.Length)
            {
                StretchCapacity();
            }

            T[] tempArray = (T[])elements.Clone();
            elements = new T[tempArray.Length];

            for (int i = 0, j = 0; i < elements.Length; i++, j++)
            {
                if (i != index)
                {
                    elements[i] = tempArray[j];
                }
                else
                {
                    elements[i] = element;
                    j--;
                }
            }
        }

        public T Max() // Task 7
        {
            dynamic maxElement = int.MinValue;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] > maxElement)
                {
                    maxElement = this.elements[i];
                }
            }

            return maxElement;
        }

        public T Min() // Task 7
        {
            dynamic minElement = int.MaxValue;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] < minElement)
                {
                    minElement = this.elements[i];
                }
            }

            return minElement;
        }

        public void Clear() // Task 5
        {
            this.elements = new T[defaultCapacity];
        }

        public int Lenght()
        {
            return this.elements.Length;
        }

        public override string ToString() // Task 5
        {
            StringBuilder print = new StringBuilder();
            
            foreach (T element in elements)
            {
                print.AppendFormat("{0} ", element);
            }

            return print.ToString().Trim();
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
    }
}
