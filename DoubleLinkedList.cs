using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DNode<T>
    {
        public DNode(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
        public T Data { get; set; }
        public DNode<T> Next { get; set; }
        public DNode<T> Prev { get; set; }
    }

    class DoubleLinkedList<T>
    {
        public DoubleLinkedList()
        {
            Head = null;
        }
        public DNode<T> Head { get; set; }

        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);

            newNode.Next = Head;
            newNode.Prev = null;

            if (Head != null)
            {
                Head.Prev = newNode;
            }
            Head = newNode;
        }

        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (Head == null)
                Head = newNode;
            else
            {
                DNode<T> temp = GetLastNode();
                temp.Next = newNode;
                newNode.Prev = temp;
            }
        }

        public void InsertAfter(DNode<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                throw new Exception("The given prevoius node cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
            newNode.Prev = prevNode;
            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;
            }
        }

        public void ReverseLinkedList()
        {
            DNode<T> prevNode = null;
            DNode<T> current = Head;
            DNode<T> temp = null;

            while (current != null)
            {
                temp = current.Next;
                current.Next = prevNode;
                current.Prev = temp;
                prevNode = current;
                current = temp;
            }
            Head = prevNode;
        }

        public void DeleteNodebyKey(T key)
        {
            DNode<T> temp = Head;
            DNode<T> prevNode = null;
            if (temp != null && temp.Data.Equals(key))
            {
                Head = temp.Next;
                return;
            }
            while (temp != null && !temp.Data.Equals(key))
            {
                prevNode = temp;
                temp = temp.Next;
                temp.Prev = prevNode;
            }
            if (temp == null)
            {
                return;
            }
            prevNode.Next = temp.Next;
            temp.Next.Prev = prevNode;
        }
        private DNode<T> GetLastNode()
        {
            if (Head == null)
                return null;
            else
            {
                DNode<T> temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                return temp;
            }
        }
    }
}
