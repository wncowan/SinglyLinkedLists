using System;

namespace SinglyLinkedLists
{
   public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            // your code here
            Head = null;
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public SinglyLinkedList Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            if(Head == null) 
            {
                Head = newNode;
                return this;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
                return this;
            }
        }   
        public SinglyLinkedList Remove() 
        {
            if(Head == null) 
            {
                return null;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = null;
                return this;
            }
        }   
        public void Display()
        {
            SllNode runner = Head;
            Console.WriteLine(runner.Value);
            while(runner.Next != null) 
            {
                runner = runner.Next;
                Console.WriteLine(runner.Value);
            }
        }
        public SllNode Find(int value)
        {
            SllNode runner = Head;
            while(runner.Value != value && runner != null)
            {
                runner = runner.Next;
            }
            return runner;
        } 
        public void RemoveAt(int index)
        {
            SllNode runner = Head;
            for(int i = 0; i < index-1; i++){
                runner = runner.Next;
            }
            runner.Next = runner.Next.Next;
        }
    } 
}