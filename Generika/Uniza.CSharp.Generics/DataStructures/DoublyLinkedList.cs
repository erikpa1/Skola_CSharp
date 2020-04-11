using System;
using System.Collections;
using System.Collections.Generic;


namespace Uniza.CSharp.Generics.DataStructures
{
    /// <summary>
    /// Obojsmerne zretazeny zoznam s hlavou.
    /// </summary>
    /// <typeparam name="T">Typ, ktoreho hodnoty sa budu v zozname uchovavat.</typeparam>
    public class DoublyLinkedList<T> : IEnumerable<T>, IList<T> where T : IComparable<T>
        //public class DoublyLinkedList<T> : IEnumerable<T>, IComparable<T>, IList<T> where T : IComparable<T>
    {

        private readonly DoublyLinkedNode<T> _head;


        public int Count { get; private set; }

        public bool IsReadOnly => false;

        /// <summary>
        /// Vytvori objekt obojsmerne zretazeneho zoznamu.
        /// </summary>
        public DoublyLinkedList()
        {
            Count = 0;

            _head = new DoublyLinkedNode<T>(default);
            _head.Previous = _head;
            _head.Next = _head;
        }

        /// <summary>
        /// Prida prvok do zoznamu.
        /// </summary>
        /// <param name="item">Prvok, ktory sa prida do zoznamu.</param>
        public void Add(T item)
        {
            var node = new DoublyLinkedNode<T>(item);
            node.Next = _head;
            node.Previous = _head.Previous;

            _head.Previous.Next = node;
            _head.Previous = node;

            Count++;
        }

        /// <summary>
        /// Odstrani prvok zo zoznamu.
        /// </summary>
        /// <param name="item">Prvok, ktory sa ma odstranit zo zoznamu.</param>
        /// <returns>True, ak sa prvok najde a uspesne odstrani. Ak neexistuje, vrati False.</returns>
        public bool Remove(T item)
        {
            var node = Find(item);
            if (node == null)
                return false;

            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;

            node.Next = null;
            node.Previous = null;

            Count--;

            return true;
        }

        /// <summary>
        /// Vymaze cely zoznam.
        /// </summary>
        public void Clear()
        {
            _head.Next = _head;
            _head.Previous = _head;

            Count = 0;
        }

        /// <summary>
        /// Zisti, ci zoznam obsahuje prvok.
        /// </summary>
        /// <param name="item">Prvok, ktoreho pritomnost sa ma zistit v zozname.</param>
        /// <returns>True, ak sa nachadza v zozname. Inak vrati false.</returns>
        public bool Contains(T item)
        {
            return Find(item) != null;
        }

        public void Sort()
        {
            for (var i = 0; i < this.Count - 1; i++)
            {
                for (var j = 0; j < this.Count - i - 1; j++)
                {
                    if (this[j].CompareTo(this[j + 1]) < 0)
                    {
                        var tmp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = tmp;
                    }
                }
            }
        }

        private DoublyLinkedNode<T> Find(T item)
        {
            for (var node = _head.Next; node != _head; node = node.Next)
            {
                if (Equals(node.Data, item))
                {
                    return node;
                }
            }

            return null;
        }

        /// <summary>
        /// Skopiruje obsah zoznamu do pola od indexu <paramref name="arrayIndex"/>.
        /// </summary>
        /// <param name="array">Pole, ktoreho velkost musi byt vacsie alebo rovne ako pocet prvkov zoznamu.</param>
        /// <param name="arrayIndex">Index do pola, do ktoreho sa zacnu prvky zoznamu zapisovat.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), "arrayIndex is less than zero.");

            if (Count > array.Length - arrayIndex)
                throw new ArgumentException(
                    "The number of elements in the source is greater than the available space from index to the end of the destination array.");

            int idx = 0;
            for (var node = _head.Next; node != _head; node = node.Next)
                array[arrayIndex + idx++] = node.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (var node = _head.Next; node != _head; node = node.Next)
                yield return node.Data;
        }

        public IEnumerable<T> GetReverse()
        {
            for (var node = _head.Previous; node != _head; node = node.Previous)
                yield return node.Data;
        }

        private class Enumerator : IEnumerator<T>
        {
            private DoublyLinkedNode<T> head;
            private DoublyLinkedNode<T> node;

            public Enumerator(DoublyLinkedNode<T> head)
            {
                this.head = node = head;
            }

            public T Current => node.Data;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                node = node.Next;
                return node != head;
            }

            public void Reset()
            {
                node = head;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string ItemsToString()
        {
            string result = "[";

            foreach (var i in this)
            {
                result += i.ToString() + " ";
            }

            result += "]";

            return result;
        }

        public int IndexOf(T item)
        {
            int index = 0;

            for (var node = _head.Next; node != _head; node = node.Next)
            {
                if (node.Data.Equals(item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            this[index] = item;
        }

        public void RemoveAt(int index)
        {
            this.Remove(this[index]);
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                int idx = 0;
                for (var node = _head.Next; node != _head; node = node.Next)
                {
                    if (index == idx++)
                    {
                        return node.Data;
                    }
                }

                throw new Exception("Something is wrong. This line should be unreachable.");
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                int idx = 0;
                for (var node = _head.Next; node != _head; node = node.Next)
                {
                    if (index == idx++)
                    {
                        node.Data = value;
                        return;
                    }

                }

                throw new Exception("Something is wrong. This line should be unreachable.");
            }
            //set { /* set the specified index to value here */ }
        }


    }
}
