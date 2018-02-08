using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class ListNode<T>
    {
        public ListNode<T> Previous;
        public ListNode<T> Next;
        public T Value;
        public ListNode(T value)
        {
            Value = value;
        }
    }
    class LinkedList<T> : IEnumerable<T>,IList<T>
    {
        private ListNode<T> _head;
        private ListNode<T> _tail;
        public LinkedList(params T[] list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }
        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public T this[int index] {
            get
            {
                return GetElementByIndex(index).Value;
            }
            set
            {
                GetElementByIndex(index).Value = value;
            }
        }

        public void Add(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
                _tail = node;
            }
            Count++;
        }
        public bool Remove(T item)
        {
            ListNode<T> current = GetElementByValue(item);
            if (current != null)
            {
                current.Previous.Next = current.Next;
                Count--;
                return true;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            ListNode<T> current = _head;
            for(int i = 0; i < Count; i++)
            {
                if (current.Value.Equals(item))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }
        private ListNode<T>GetElementByIndex(int index)
        {
            if ((index > Count - 1) | (index < 0))
            {
                throw new IndexOutOfRangeException();
            }
            ListNode<T> current = _head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }
        private ListNode<T>GetElementByValue(T item)
        {
            ListNode<T> current = _head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Insert(int index, T item)
        {
            ListNode<T> current = GetElementByIndex(index);

            if (current.Equals(_tail))
            {
                Add(item);
            }
            else
            {
                var newItem = new ListNode<T>(item)
                {
                    Next = current,
                    Previous = current.Previous
                };
                current.Previous.Next = newItem;
                current.Previous = newItem;
                Count++;
            }
        }

        public void RemoveAt(int index)
        {
            ListNode<T> current = GetElementByIndex(index);
            if (current != null)
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
            } 
        }

        public void Clear()
        {
            Count = 0;
            _head = null;
            _tail = null;
        }

        public bool Contains(T item)
        {
            if (GetElementByValue(item) != null)
            {
                return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
    }
}

