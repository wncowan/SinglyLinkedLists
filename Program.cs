using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList PlayList = new SinglyLinkedList();
            PlayList.Add(2).Add(5).Add(6).Remove();
            PlayList.Add(22);
            PlayList.Add(2222);
            PlayList.Add(2222222);
            PlayList.Remove();
            PlayList.RemoveAt(1);
            PlayList.Display();
            // SllNode target = PlayList.Find(22);
            // Console.WriteLine(target.Value);
            Console.WriteLine("Hello World!");
        }
    }
}
