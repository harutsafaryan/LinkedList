using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.InsertFront(1);
            doubleLinkedList.InsertFront(2);
            doubleLinkedList.InsertFront(3);
            doubleLinkedList.InsertFront(4);
            doubleLinkedList.InsertFront(5);
            doubleLinkedList.InsertFront(6);
            doubleLinkedList.InsertFront(7);

            DoubleLinkedList<int> doubleLinkedList1 = new DoubleLinkedList<int>();
            doubleLinkedList1.InsertLast(1);
            doubleLinkedList1.InsertLast(2);
            doubleLinkedList1.InsertLast(3);
            doubleLinkedList1.InsertLast(4);
            doubleLinkedList1.InsertLast(5);
            doubleLinkedList1.InsertLast(6);
            doubleLinkedList1.InsertLast(7);
            doubleLinkedList1.DeleteNodebyKey(4);
            doubleLinkedList1.ReverseLinkedList();
            doubleLinkedList1.InsertAfter(doubleLinkedList1.Head.Next.Next, 20);

            SingleLinkedList<int> singleLinked = new SingleLinkedList<int>();
            singleLinked.InsertFront(1);
            singleLinked.InsertFront(2);
            singleLinked.InsertFront(3);
            singleLinked.InsertFront(4);
            singleLinked.InsertFront(5);
            singleLinked.DeleteNodebyKey(4);

            SingleLinkedList<int> singleLinked1 = new SingleLinkedList<int>();
            singleLinked1.InsertLast(1);
            singleLinked1.InsertLast(2);
            singleLinked1.InsertLast(3);
            singleLinked1.InsertLast(4);
            singleLinked1.InsertLast(5);
            singleLinked1.ReverseLinkedList();
            singleLinked.InsertAfter(singleLinked1.Head.Next.Next, 20);
            Console.WriteLine();
        }
    }
}
