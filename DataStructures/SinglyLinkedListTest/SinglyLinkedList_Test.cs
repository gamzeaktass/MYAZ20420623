using LinkedList;

namespace SinglyLinkedListTest
{
    public class SinglyLinkedList_Test
    {
        [Fact]
        public void SinlglyLinkedList_AddFirstTest()
        {
            //Arrange
            var linkedlist = new SinglyLinkedList<int>();

            //Act
            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddFirst(30); //Son eklediðimiz head olarak baþa gelir 

            //Assertion
            Assert.Equal(linkedlist.Head.Value,30);
            Assert.Equal(linkedlist.Head.Next.Value,20);
            Assert.Equal(linkedlist.Head.Next.Next.Value, 10);
        }

        [Fact]
        public void SinlglyLinkedList_AddLastTest()
        {
            //Arrange
            var linkedList = new SinglyLinkedList<int>();

            //Act
            linkedList.AddLast(10);//Sona ekleme yapýldýðý için ilk eklenen head olur.
            linkedList.AddLast(50);
            linkedList.AddLast(100);

            //Assertion
            Assert.Equal(linkedList.Head.Value,10);
            Assert.Equal(linkedList.Head.Next.Value,50);
            Assert.Equal(linkedList.Head.Next.Next.Value,100);
        }
        [Fact]
        public void SinglyLinkedList_AddBefore_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            linkedList.AddBefore(linkedList.Head.Next, 'x');  // c [x] b a


            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'x');

        }

        [Fact]
        public void SinglyLinkedList_AddBefore_Throw_ExceptionTest()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('y');

            // assert
            Assert.Throws<Exception>(() => linkedList.AddBefore(node, 'x'));
        }

        
        [Fact]
        public void SinglyLinkedList_AddAfter_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            linkedList.AddAfter(linkedList.Head.Next, 'x');  // c b [x] a ------>Belirtilen yere x deðerini yerleþtiriyor


            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'x');

        }

        
        [Fact]
        public void SinglyLinkedList_AddAfter_Throw_ExceptionTest()//Olmayan bir þey üstünden ekleme yapmaya çalýþtýðýmýz için hata verecektir
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('y');

            // assert
            Assert.Throws<Exception>(() => linkedList.AddBefore(node, 'x'));
        }

       
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var item = linkedList.RemoveFirst();  // b a


            // assert
            Assert.Equal('c', item);
            Assert.Equal('b', linkedList.Head.Value);
        }

        [Fact]
        public void SinglyLinkedList_RemoveFirst_One_Item_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a

            var item = linkedList.RemoveFirst();  // null


            // assert
            Assert.Equal('a', item);
            Assert.True(linkedList.Head is null);
        }
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Exception_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // assert
            Assert.Throws<Exception>(() => linkedList.RemoveFirst());
        }

        [Fact]
        public void SinglyLinkedList_RemoveLast_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            // act
            var item1 = linkedList.RemoveLast();
            var item2 = linkedList.RemoveLast();
            var item3 = linkedList.RemoveLast();

            // assert
            Assert.Equal('a', item1);
            Assert.Equal('b', item2);

            // -> Son eleman
            Assert.Equal('c', item3);
        }

        [Fact]
        public void SinglyLinkedList_RemoveLast_Exception_Test()//Eleman yokken çýkarma iþlemi yaptýðý için hata fýrlatýr.
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // assert
            Assert.Throws<Exception>(() => linkedList.RemoveLast());
        }
        [Fact]
        public void SinglyLinkedList_Remove_Test()
        {
            // arrange 
            var newNode = new SinglyLinkedListNode<char>('x');
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            // act



            // assert
            Assert.Throws<Exception>(() => linkedList.Remove(newNode));


        }
    }
}
