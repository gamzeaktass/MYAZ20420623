namespace ArrayTests
{
    public class ArrayTest
    {
        [Fact]
        public void Array_Count_Test()
        {
            //Arrange(Düzenleme)
            var array = new Array.Array();
            array.Add("Gamze");
            array.Add("Hacer");
            array.Add("Sýla");
            array.Add("Gülsüm");
            //Act(Eylem)
            int count = array.count;
            //Assertion(Ýddia)
            Assert.Equal(4,count);//Buradaki 4 beklenen(Expected), count ise gerçek(Actual) iafededir.
            //Beklenen=Gerçek ise test geçer deðilse fail olur.
            Assert.Equal(4, array.capacity);
        }
        [Fact]
        public void GetItem_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Gamze");
            array.Add("Hacer");
            array.Add("Sýla");
            array.Add("Gülsüm");
            //Act
            var item = array.GetItem(1);
            //Assertion
            Assert.Equal(item, "Hacer");

        }
        [Fact]
        public void Array_GetItem_Exception_Test()
        {
            try 
            {
                //Arrange
                var array = new Array.Array();
                array.Add("Gamze");
                array.Add("Hacer");
                array.Add("Sýla");
                array.Add("Gülsüm");
                //Act
                var item = array.GetItem(-1);
                //assertion
                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);//-1. elemanda IndexOutOfRangeException hatasýný vermeden getirmesini saðlarýz.
            }
           
        }
        [Fact]
        public void Array_Find_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add(5);
            array.Add(6);
            array.Add(9);
            array.Add(8);
            //Act
            var item1 = array.Find(6);
            var item2 = array.Find(9);
            //Assertion
            Assert.Equal(1,item1);
            Assert.Equal(2,item2 );
        }
        [Fact]
        public void Array_Swap_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Gamze");//0
            array.Add("Hacer");//1
            array.Add("Sýla");//2
            array.Add("Gülsüm");//3
            //Act
            array.Swap(0, 2); //Bu iþlem 0 ve 2 pozsyonlarýndaki deðerlerin yer deðiþtirmesini saðlar
            var item1 = array.GetItem(0);//Sýla
            var item2 = array.GetItem(2);//Gamze
            //Assertion
            Assert.Equal(item1, "Sýla");
            Assert.Equal(item2,"Gamze" );
        }
        [Fact]
        public void Array_RemoveItem_Exception_Test()
        {
            try
            {
                //Arrange
                var array = new Array.Array();
                array.Add(0);
                array.Add(1);
                array.Add(2);
                array.Add(3);
                //Act
                var item = array.RemoveItem(-1);
                //assertion
                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }

        }
        [Fact]
        public void Array_Remove_Test()
        {
            //try-catch de önce try çalýþtýrýlýr eðer hata varsa da kod durdurullmaz hata bilgisi catchde verilir.
            try
            {
                //Arrange
                var array = new Array.Array();
                array.Add(0);
                array.Add(1);
                array.Add(2);
                array.Add(3);
                array.Add(4);
                //Act
                var item1 = array.RemoveItem(2);
                var item2 = array.GetItem(2);
                array.RemoveItem(3);
                //Assertion
                Assert.Equal(2,item1);
                Assert.Equal(3,item2);
                Assert.Equal(4, array.capacity);            }
            catch (Exception)
            {
                Assert.True(true);
            }
           
        }
        [Fact]
        public void Array_GetEnumerator_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Ayþe");
            array.Add("Fatma");
            array.Add("Nil");

            string result = "";
            foreach(var item in array)//Objectten dolayý collection üzerinde koþamadýðýmýz için concatla birleþtirip yazdýk.
            {
                result=string.Concat(result, item);
            }
            Assert.Equal(result, "AyþeFatmaNil");
        }
        [Fact]
        public void Array_Copy_Test()
        {    
            //Arrange
            var array = new Array.Array();
            array.Add("Gamze"); //0
            array.Add("Hacer"); //1
            array.Add("Sýla");  //2
            array.Add("Gülsüm");//3
            //Act
           // var newArray = array.Copy(2, 3);//2 dahil,3deðil----->dizi tek elemanlý
           // var item = newArray[0];
            //Assertion
           // Assert.Equal("Sýla", item);
        }
    }
}