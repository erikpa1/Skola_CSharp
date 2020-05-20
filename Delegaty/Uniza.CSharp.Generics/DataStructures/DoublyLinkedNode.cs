namespace Uniza.CSharp.Generics.DataStructures
{
    /// <summary>
    /// Vrchol obojsmerne zretazeneho zoznamu.
    /// </summary>
    /// <typeparam name="T">Typ prvku, ktoreho hodnotu bude vrchol obsahovat v <see cref="Data"/>.</typeparam>
    class DoublyLinkedNode<T>
    {
        /// <summary>
        /// Odkaz na predchadzajuci vrchol.
        /// </summary>
        public DoublyLinkedNode<T> Previous { get; set; }
        
        /// <summary>
        /// Odkaz na nasledujuci vrchol.
        /// </summary>
        public DoublyLinkedNode<T> Next { get; set; }

        /// <summary>
        /// Obsahuje hodnotu prvku.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Vytvori vrchol pre obojsmerne zretazeny zoznam.
        /// </summary>
        /// <param name="data">Hodnota prvku, ktory bude vrchol obsahovat.</param>
        public DoublyLinkedNode(T data)
        {
            Data = data;
        }
    }
}
