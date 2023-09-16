using _2lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Collections
{
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;
        private Node current;
        private int count;

        public MyCustomCollection()
        {
            head = null;
            current = null;
            count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Node currentNode = head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Data;
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Node currentNode = head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Data = value;
            }
        }

        public void Reset()
        {
            current = head;
        }

        public void Next()
        {
            if (current != null)
            {
                current = current.Next;
            }
        }

        public T Current()
        {
            if (current == null)
                throw new InvalidOperationException("Курсор находится за пределами коллекции");

            return current.Data;
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(T item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                Node lastNode = head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
            count++;
        }

        public void Remove(T item)
        {
            Node currentNode = head;
            Node previousNode = null;

            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Data, item))
                {
                    if (previousNode == null)
                    {
                        // Удаляемый элемент - первый в коллекции
                        head = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    if (current == currentNode)
                    {
                        current = previousNode;
                    }

                    count--;
                    return;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public T RemoveCurrent()
        {
            if (current == null)
                throw new InvalidOperationException("Курсор находится за пределами коллекции");

            T dataToRemove = current.Data;
            Remove(dataToRemove);
            return dataToRemove;
        }

        public bool Any(Func<T, bool> predicate)
        {
            for (int i = 0; i < Count; i++)
            {
                if (predicate(this[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
