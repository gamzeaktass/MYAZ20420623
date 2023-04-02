using System.Collections;

namespace Array
{
    public class Array:IEnumerable
    {
        private Object[] _InnerArray; //Object[]? ---->? _InnerArray2ın null değer alabileceğini söyler.(_InnerArray'ın başlatıldığı ctorda aynı işlemi görür.)
        private int _Index=0;
        public int count => _Index;//_InnerArraydaki eleman sayısı
        public int capacity => _InnerArray.Length;//Capacity değeri blok sayısıdır ilk 4 değer için 4, sonrakiler için 8dir.
        public Array()
        {
            _InnerArray=new Object[4];//Block Allocation(önceden yer ayırma gibi)---->Burada verilen []içine verilen değer dizi için ayrılan yerleri temsil eder. 4 blokluk.
        }
        public void Add(Object item) //_InnerArraya ekleme
        {
            if (_Index == _InnerArray.Length)//bu koşul ve koşulun içindeki metod dizinin boyutunu arttırmak için kullanılır. Dizi boyutu ikiye katlanarak artar.
            {
                DoubleArray(_InnerArray);
            }
           
                _InnerArray[_Index] = item;
                _Index++;
            
            
        }

        private void DoubleArray(object[] array)
        {
           var newArray=new Object[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray= newArray;
        }
        public object GetItem(int position)
        {
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            return _InnerArray[position];
        }
        public void SetItem(int position,object item)
        {
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            _InnerArray[position] = item;
        }

        public int Find(object item)//Verilen elemana ait poziyon bilgisini döndürür, eğer yoksa -1 döndürür.
        {
           for(int i = 0; i < _InnerArray.Length; i++)
            {
                if(item.Equals(_InnerArray[i])) 
                    return i;
            }
           return -1;   
        }
        public void Swap(int p1,int p2)//Verilen pozisyondaki elemanları yer değiştirir
        {
            var temp= _InnerArray[p1];
            _InnerArray[p1]=_InnerArray[p2];
            _InnerArray[p2] = temp;
        }
        public object RemoveItem(int position)//Verilen pozisyondaki elemanı kaldırdıktan sonra kaydırma işlemi de yapar.
        {
            var item=_InnerArray[position];
            _InnerArray[position] = null;
            for(int i = 0; i < _InnerArray.Length-1; i++)
            {
                if (_InnerArray[i] == null)
                {
                    Swap(i, i + 1);
                }
            }
            _Index--;
            if (_Index == _InnerArray.Length / 2) //Capacitynin hata vermemesi için gereklidir.
            {
                var newArray = new Object[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArray, newArray.Length);
                _InnerArray = newArray;
            }
            return item;
            /*var item=GetItem(position);------->Verilen pozisyondaki elemanı kaldırır eğer pozsiyonda eleman yoksa IndexOutOfRangeException hatası atar.
            if (item != null) 
            {
                _InnerArray[position] = null;
                return item;
            }
                
            return -1;*/
        }
        public object Remove()
        {
            if (_Index == 0)
                throw new Exception("Out Of Inde!");
            var temp = _InnerArray[_Index-1];
            _InnerArray[_Index-1] = null;
            _Index--;
            return temp;
        }

        public IEnumerator GetEnumerator()//IEnumarator dönüş tipi sayesinde move next kontrolünü kendimiz düzenleyebilriz. Bu da diziyi neye göre sıralayacağımızı seçmemizi sağlar.
        {
            return _InnerArray.GetEnumerator();
        }
    }
}