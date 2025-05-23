﻿using System.ComponentModel;

namespace LearnDSAlgorithm
{
    //Lab Creating and Displaying Linked List
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e,Node n)
        {
            element = e;
            next = n;
        }
    }
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public int length()
        {
            return size;
        }
        public bool isEmpty()
        {
            return size == 0;
        }
        #region Remove Element at first
        public int removeFirstNode()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return - 1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (isEmpty())
                {
                    tail = null;
                   
                }
                return e;
            }
        }
        #endregion

        #region Remove Element at Last
        public int removeLastNode()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i<length()-1)
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }
        #endregion
        #region Remove Element at any position
        public int RemoveAnyNode(int position)
        {
            if (position <= 0 || position >= size -1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;
        }
        #endregion

        #region Insert Element at any position
        public void AddAny(int e, int position)
        {
            if (position <= 0 || position >=size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while (i<position -1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }
        #endregion

        #region Insert Element at last of linked list
        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;
        }
        #endregion

        #region Insert Element at Beginning of linked list
        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }
        #endregion

        #region Search Element of linked list
        public int search(int key)
        {
            Node p = head;
           int index = 0;
            while (p!=null)
            {
                if (p.element==key)
                {
                    return index;
                }
                p = p.next;
                index = index + 1;
            }
            return -1;
        }
        #endregion

        #region Insert Element at sorted order
        public void insertSorted(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {
                Node p = head;
                Node q = head;
                while (p!=null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p==head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }
        #endregion

        public void display()
        {
            Node p = head;
            while (p!=null)
            {
                Console.Write(p.element + "--> ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            LinkedList l = new LinkedList();
            //insert element at last
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size:"+l.length());
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //insert element at first
            l.addFirst(15);
            l.display();
            Console.WriteLine("Size:" + l.length());
            l.addFirst(25);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //insert element at anywhere
            l.AddAny(20, 3);
            l.display();
            Console.WriteLine("Size:" + l.length());
            l.AddAny(40,5);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //remove at first element
            int element = l.removeFirstNode();
            Console.WriteLine("Removed Element:" + element);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //remove at last element
            int element1 = l.removeLastNode();
            Console.WriteLine("Removed Element:" + element1);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //remove at any element
            int element2 = l.RemoveAnyNode(3);
            Console.WriteLine("Removed Element:" + element2);
            l.display();
            Console.WriteLine("Size:" + l.length());
            //search element
            int position = l.search(12);
            Console.WriteLine("Result:" + position);
            //insert element at sorted method
            l.insertSorted(7);
            l.insertSorted(17);
            l.insertSorted(78);
            l.display();
            Console.WriteLine("Size:" + l.length());
            Console.ReadKey();
        }
    }
}
