using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    class SingleLinkedList<T>
    {
        public SingleLinkedList()
        {
            Head = null;
        }
        public Node<T> Head { get; set; }

        public void InsertFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> temp = GetLastNode();
                temp.Next = newNode;
            }

        }
       
        public void InsertAfter(Node<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                throw new NullReferenceException("The given previous node Cannot be null");
            }
            Node<T> newNode = new Node<T>(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        public void ReverseLinkedList()
        {
            Node<T> prevNode = null;
            Node<T> current = Head;
            Node<T> temp = null;

            while (current != null)
            {
                temp = current.Next;
                current.Next = prevNode;
                prevNode = current;
                current = temp;
            }
            Head = prevNode;
        }

        public  void DeleteNodebyKey(T key)
        {
            Node<T> temp = Head;
            Node<T> prevNode = null;
            if (temp != null && temp.Data.Equals(key))
            {
                Head = temp.Next;
                return;
            }
            while (temp != null && !temp.Data.Equals(key))
            {
                prevNode = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return;
            }
            prevNode.Next = temp.Next;
        }
        private Node<T> GetLastNode()
        {
            if (Head == null)
                return null;
            else
            {
                Node<T> temp = Head;

                while (temp.Next != null)
                    temp = temp.Next;
                return temp;
            }
        }
    }
}
