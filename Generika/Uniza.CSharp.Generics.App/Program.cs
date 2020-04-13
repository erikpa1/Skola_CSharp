using System;
using System.Collections.Generic;

using Uniza.CSharp.Generics.DataStructures;
using Uniza.CSharp.Generics.Tools;


namespace Uniza.CSharp.Generics.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new DoublyLinkedList<string>();
            list.Add("C");
            list.Add("F");
            list.Add("E");
            list.Add("D");   
            list.Add("C");
            list.Add("B");
            list.Add("A");
            list.Add("G");
            list.Add("H");
            list.Add("Z");
            list.Add("H");

            list[0] = "Z";

            list.Insert(3, "F");

            int ind = list.IndexOf("E");

            Console.WriteLine(ind);

            list.RemoveAt(ind);

            Console.WriteLine(list[ind]);

            Console.WriteLine(list[0]);

            DoublyLinkedList<string> myList = (DoublyLinkedList<string>)list;

            myList.Sort();

            Console.WriteLine(myList.ItemsToString());

        }

    }
}
