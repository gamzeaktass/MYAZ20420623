namespace CollectionsTest
{
    public class ListTests
    {
        [Fact]
        public void Colllections_Instersection_Test()
        {
            //Arrange
            var l1=new List<int>() {1,3,4 };
            var l2=new List<int>() {1,10,20,3}; 
            int count = 0;
            //Act
            var list= l1
                .Intersect(l2)
                .ToList();
            foreach(var item in list)
            {
                count++;
            }
            //Assertion
            Assert.Equal(2, count);
        }
        [Fact]
        public void Collections_Union_Tes()
        {
            //Arrange
            var list1 = new List<char>() { 'a', 'b', 'c', 'd' };
            var list2= new List<char>() { 'a', 'b', 'h', 'k' };
           
            //Act
            var newList= list1.Union(list2).ToList();
            
            //Assertion
            Assert.Equal(6, newList.Count); //listde countun otomatik özelliði mevcut
            Assert.Collection<char>(newList,
                item => Assert.Equal('a', item),
                item => Assert.Equal('b', item),
                item => Assert.Equal('c', item),
                item => Assert.Equal('d', item),
                item => Assert.Equal('h', item),
                item => Assert.Equal('k', item));
        }
    }
}