namespace Uniza.CSharp.Generics.DataStructures
{
    /// <summary>
    /// Vrchol obojsmerne zretazeneho zoznamu.
    /// </summary>
    /// <typeparam name="T">Typ prvku, ktoreho hodnotu bude vrchol obsahovat v <see cref="Data"/>.</typeparam>
    class DoublyLinkedNode<T>
    {

        public DoublyLinkedNode<T> Previous { get; set; }

        public DoublyLinkedNode<T> Next { get; set; }

        public T Data { get; set; }

        public DoublyLinkedNode(T data)
        {
            Data = data;
        }
    }
}
