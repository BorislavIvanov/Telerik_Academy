using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTableImplementation;

namespace SetImplementation
{
    public class Set<T> : IEnumerable<T>
    {
        private HashTable<int, T> elements;

        public Set()
        {
            this.elements = new HashTable<int, T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element.GetHashCode(), element);
        }

        public void Remove(T element)
        {
            this.elements.Remove(element.GetHashCode());
        }

        public T Find(T element)
        {
            T returnedElement;
            if (this.elements.Find(element.GetHashCode(), out returnedElement))
            {
                return returnedElement;
            }

            return default(T);
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public Set<T> Intersect(Set<T> other)
        {
            Set<T> newSet = new Set<T>();

            foreach (var element in this)
            {
                foreach (var otherElement in other)
                {
                    if (element.Equals(otherElement))
                    {
                        newSet.Add(element);
                    }
                }
            }

            return newSet;
        }

        public Set<T> Union(Set<T> other)
        {
            Set<T> newSet = new Set<T>();

            foreach (var element in this)
            {
                newSet.Add(element);
            }

            foreach (var element in other)
            {
                newSet.Add(element);
            }

            return newSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.elements)
            {
                yield return pair.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }
    }
}
