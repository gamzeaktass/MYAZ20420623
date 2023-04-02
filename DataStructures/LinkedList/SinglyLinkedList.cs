using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T>? Head { get; set; }
        public int Count { get; set; }
       
        public void AddFirst(T item)//Yeni eklenen elamanı heade atama
        {
            //Burada Tden olayı önce düğüm tasarımı yapmamız gerekir.
            var node = new SinglyLinkedListNode<T>()
            {
                Value = item//Bu işlem SinglyLinkedListNode da ctor olmadığı için gereklidir
            };
            if(Head is null)
            {
                Head = node;
                return;
            }
            else
            {
                node.Next = Head;//Önce nodenext elamınının headi göstermesini sağlıyoruz daha sonra ise yeni headimiz node oluyor.
                Head = node;
                return;
            }
        }
        public void AddLast(T item)
        {
            var node = new SinglyLinkedListNode<T>(item);
            //{
            //    value = item----------->SinglyLinkedLİstNodeda value=value alan bir ctor oluşturduk
            //};
            if (Head is null)
            {
                Head = node;
                return;
            }
                var current = Head;
                var prev = current;
                while (current != null)
                {
                    prev= current;  
                    current = current.Next;
                }
                prev.Next = node;
                return;

            

        }
        public void AddBefore(SinglyLinkedListNode<T> node, T item)
        {
            if (Head is null)
            {
                AddFirst(item);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(item);

            var current = Head;
            var prev = current;

            while (current is not null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("The node could not be found in the linked list.");
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            var current = Head;//Burada head üzerinden değil de current üzerinden gitmemiz sebebi diğer elemanlara olan erişimi kaybetmemektir.
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new Exception("The node could not be found in the linked list.");
        }

        public T RemoveFirst()
        {
            if (Head == null)
            {
                throw new Exception("The node could not be found in the linked list.");
            }
            else if (Head.Next == null)
            {
                var item = Head.Value;//Dönüş tipi T olduğu için item kullandık
                Head = null;
                return item;
            }
            else
            {
                var item = Head.Value;
                Head = Head.Next;
                return item;
            }
        }
        public T RemoveLast()
        {

            if (Head == null)
            {
                throw new Exception("The node could not be found in the linked list.");
            }
            else if (Head.Next == null)
            {
                var item = Head.Value;
                Head = null;
                return item;
            }
            else
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Next.Next == null)
                    {
                        var item = current.Next.Value;
                        current.Next = null;
                        return item;
                    }
                    current = current.Next;
                }
                throw new Exception();
            }
        }
        public T Remove(SinglyLinkedListNode<T> node)
        {
            if (Head == null)
            {
                throw new Exception("The node could not be found in the linked list.");
            }
            else if (Head.Value.Equals(node.Value))
            {
                var item = Head.Value;
                Head = Head.Next;
                return item;
            }
            else
            {

                var current = Head;
                while (current.Next != null)
                {
                    if (current.Next.Equals(node))
                    {
                        var item = current.Next.Value;
                        current.Next = current.Next.Next;
                        return item;
                    }
                    current = current.Next;
                }
                throw new Exception("Node not found");
            }
        }


    }
}
