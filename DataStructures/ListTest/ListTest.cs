using System.Collections.Generic;

namespace ListTest
{
    public class ListTest
    {
        [Fact]
        public void List_Add_Test()
        {
            // Arrange
            List.List<int> list = new List.List<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            int capacity = list.Capacity;

            // Assert
            Assert.Equal(8, capacity);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item)
                );
        }

        [Fact]
        public void List_AddRange_Test()
        {
            // Arrange
            List.List<int> list = new List.List<int>();
            int[] intList = new int[] { 1, 2, 3, 4, 5, 6 };

            // Act
            list.AddRange(intList);

            // Assert
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item)
                );
        }

        [Fact]
        public void List_Remove_Test()
        {
            // Arrange
            List.List<int> list = new List.List<int>();
            int[] intList = new int[] { 1, 2, 3, 4, 5 };

            // Act
            list.AddRange(intList);

            bool test1 = list.Remove(2);
            bool _ = list.Remove(3);
            bool test2 = list.Remove(7);

            int capacity = list.Capacity;

            // Assert
            Assert.True(test1);
            Assert.True(!test2);
            Assert.Equal(4, capacity);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item)
                );
        }

        [Fact]
        public void List_RemoveAt_Test()
        {
            // Arrange
            List.List<string> list = new List.List<string>();
            string[] stringList = new string[] { "Gamze", "Hacer", "S�la", "�ebnem", "G�ls�m" };

            // Act
            list.AddRange(stringList);

            list.RemoveAt(2);

            // Assert
            Assert.Collection<string>(list,
                item => Assert.Equal("Gamze", item),
                item => Assert.Equal("Hacer", item),
                item => Assert.Equal("�ebnem", item),
                item => Assert.Equal("G�ls�m", item),
                item => Assert.Equal(null, item)
                );
        }

        [Fact]
        public void List_Intersect_Test()
        {
            // Arrange
            List.List<string> list = new List.List<string>() { "Gamze", "S�la", "Hacer", "G�ls�m", "�eyma" };
            string[] stringList = new string[] { "Gamze", "�bo", "Mami", "G�ls�m", "Ela" };

            // Act
            string[] interList = list.InterSect(stringList);

            // Assert
            Assert.Equal("Gamze", interList[0]);
            Assert.Equal("G�ls�m", interList[1]);
        }

        [Fact]
        public void List_Union_Test()
        {
            // Arrange
            List.List<string> list = new List.List<string>() { "Gamze", "S�la", "Hacer", "G�ls�m", "�eyma" };
            string[] stringList = new string[] { "Gamze", "�bo", "Mami", "G�ls�m", "Ela" };

            // Act
            string[] interList = list.Union(stringList);

            // Assert
            Assert.Equal("Gamze", interList[0]);
            Assert.Equal("S�la", interList[1]);
            Assert.Equal("Hacer", interList[2]);
            Assert.Equal("G�ls�m", interList[3]);
            Assert.Equal("�eyma", interList[4]);
            Assert.Equal("�bo", interList[5]);
            Assert.Equal("Mami", interList[6]);
            Assert.Equal("Ela", interList[7]);
        }

        [Fact]
        public void List_Except_Test()
        {
            // Arrange
            List.List<string> list = new List.List<string>() { "Gamze", "S�la", "Hacer", "G�ls�m", "�eyma" };
            string[] stringList = new string[] { "Gamze", "S�la", "�bo", "G�ls�m", "�eyma" };

            // Act
            string[] interList = list.Except(stringList);

            // Assert
            Assert.Equal("Hacer", interList[0]);
        }
    }
}