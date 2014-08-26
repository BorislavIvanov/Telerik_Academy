using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedList
{
    class LinkedList
    {
        public class LinkedList<T>
        where T : IComparable
        {
            private ListItem firstElement;

            private class ListItem
            {
                private T value;
                private ListItem nextItem;

                public ListItem(T value)
                {
                    this.Value = value;
                    this.Next = null;
                }

                public T Value
                {
                    get { return this.value; }
                    set { this.value = value; }
                }

                public ListItem Next
                {
                    get { return this.nextItem; }
                    set { this.nextItem = value; }
                }

                public override string ToString()
                {
                    return this.Value.ToString();
                }
            }

            /// <summary>
            /// Default constructor
            /// </summary>
            public LinkedList()
            {
                this.firstElement = null;
            }

            /// <summary>
            /// The first element from the Linked List
            /// </summary>
            public T FirstElement
            {
                get
                {
                    return this.firstElement.Value;
                }
            }

            /// <summary>
            /// Adds a new item to the Linked List
            /// </summary>
            /// <param name="element">The item to add</param>
            public void AddItem(T element)
            {
                if (this.firstElement == null)
                {
                    this.firstElement = new ListItem(element);
                }

                else
                {
                    var currentElement = this.firstElement;
                    while (currentElement.Next != null)
                    {
                        currentElement = currentElement.Next;
                    }
                    currentElement.Next = new ListItem(element);
                }
            }

            /// <summary>
            /// Removes an item from the Linked List
            /// </summary>
            /// <param name="element">The item to remove</param>
            public void RemoveItem(T element)
            {
                if (this.firstElement == null)
                {
                    //emptyList
                    return;
                }

                var currentItem = this.firstElement;

                if (currentItem.Value.CompareTo(element) == 0)
                {
                    //even if null it will work OK
                    this.firstElement = currentItem.Next;
                    return;
                }

                while (currentItem.Next != null)
                {
                    if (currentItem.Next.Value.CompareTo(element) == 0)
                    {
                        currentItem.Next = currentItem.Next.Next;
                        return;
                    }

                    currentItem = currentItem.Next;
                }
            }

            /// <summary>
            /// Adds an element in the begining of the Linked List
            /// </summary>
            /// <param name="element">The element to add to the begining</param>
            public void AddFirst(T element)
            {
                var newNode = new ListItem(element);
                newNode.Next = this.firstElement;
                this.firstElement = newNode;
            }

            /// <summary>
            /// Removes an element from the begining of the Linked List
            /// </summary>
            /// <param name="element">The element to remove from the begining</param>
            public void RemoveFirst()
            {
                this.firstElement = this.firstElement.Next;
            }

            public override string ToString()
            {
                if (this.firstElement == null)
                {
                    return string.Format("[ ]");
                }

                StringBuilder sb = new StringBuilder("[ ");

                var currItem = this.firstElement;
                sb.Append(currItem.Value);

                while (currItem.Next != null)
                {
                    sb.Append(", ");
                    sb.Append(currItem.Next);
                    currItem = currItem.Next;
                }

                sb.Append(" ]");

                return sb.ToString();
            }
        }
    }
}
