namespace LinkedList
{
    public class SinglyLinkedListNode<T>
       // where T : class -----> Sadece classlarda erişim
    {
        public T? Value { get; set; }//----->? null değer alabilir
        public SinglyLinkedListNode<T> Next { get; set; }//SinglyLinkedListNode<T> şeklinde bir yapı varsa muhakkak onu başlatmamız gerekir.
        public SinglyLinkedListNode()
        {

        }
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"{Value}";
        }

    }
}