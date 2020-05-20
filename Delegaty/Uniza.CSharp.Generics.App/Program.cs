using System;
using Uniza.CSharp.Generics.DataStructures;
using Uniza.CSharp.Generics.Tools;

namespace Uniza.CSharp.Generics.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapExample();
            DoublyLinkedListExample();
        }

        private static void SwapExample()
        {
            var a = 10;
            var b = 20;
            Swapper.Swap(ref a, ref b);
            // V premennych by mali byt tieto hodnoty:
            // a = 20, b = 10
            Console.WriteLine($"{a} {b}");

            var d1 = Math.PI;
            var d2 = Math.E;
            Swapper.Swap(ref d1, ref d2);
            // V premennych by mali byt tieto hodnoty:
            // d1 = Math.E, d2 = Math.PI
            Console.WriteLine($"{d1} {d2}");

            var hello = "Ahoj";
            var world = "svet";
            Swapper.Swap(ref hello, ref world);
            // V premennych by mali byt tieto hodnoty:
            // hello = "svet", world = "Ahoj"
            Console.WriteLine($"{hello} {world}");

            // Pozadovany vystup:
            // 20 10
            // 2,718281828459045 3,141592653589793
            // svet Ahoj
        }

        private static void DoublyLinkedListExample()
        {
            var list = new DoublyLinkedList<string>();
            list.Add("biela");
            list.Add("modra");
            list.Add("cervena");

            var numbers = new DoublyLinkedList<int>();
            for (int i = 1; i < 6; i++)
                numbers.Add(i);

            // Prechodcez indexer
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            // Prechod cez enumerator
            var enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var number = enumerator.Current;
                Console.WriteLine(number);
            }

            // Prechod cez foreach - s vyuzitim enumeratora
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
