using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
    {
        public class List<T> : IEnumerable<T>
        {
            private T[] _list;//Buradaki listeyi array olarak biz oluşturduk sistemden çekmedik

            private int index = 0;

            public int Capacity => _list.Length;

            public int Count => index;

            public List()
            {
                _list = new T[4];//Listenin boyutu 4 olarak atandı.
            }
            public void Add(T item)//Ekleme işlemi yapabilmek için listenin boyutunu arttırmamız lazım
            {
                if (index == _list.Length)
                {
                    DoubleList(_list);
                }
                
                _list[index++] = item;//ekleme işlemi
            }

            public void DoubleList(T[] list)//Liste için ayrılan alanı ikiye katlar
            {
                var newList = new T[list.Length * 2];
                System.Array.Copy(list, newList, _list.Length);
                _list = newList;
            }

            public void AddRange(IEnumerable<T> collection)//collection data(kolleksiyon verisi) olarak verilen elemanları diziye ekler(birden çok ekleme)
            {
              

                foreach (var item in collection)
                {
                    Add(item);
                }
            }
            public bool Remove(T item)//Verilen elemanlar çıktıkca true döner
            {
               
                for (int i = 0; i < _list.Length; i++)
                {
                    if (_list[i].Equals(item))
                    {
                        _list[i] = default(T);
                        for (int j = i; j < _list.Length - 1; j++)//Swap İşlemi
                        {
                            T temp = _list[j];
                            _list[j] = _list[j + 1];//Burada tempe önce j. elemana ona da j+1. eleman, eksi j+1. eleman da tempe yani boşa atanır.
                            _list[j + 1] = temp;
                        }

                        index--;
                        if (index == _list.Length / 2)
                            HalfList(_list);//Kaldırma işlemi içinde dizi boyutunu azaltmamız lazım
                        return true;
                    }
                }

                return false;
            }

            public void HalfList(T[] list)//Listeden eleman çıkarınca listenin boyutunu azaltmak için kullanılır.(Dynamic Memory Allocation)
            {
                var newList = new T[list.Length / 2];
                System.Array.Copy(list, newList, newList.Length);
                _list = newList;
            }
            public void RemoveAt(int index)//verilen indexteki elemanı çıkarır
            {
               

                _list[index] = default(T);

                for (int i = index; i < _list.Length - 1; i++)
                {
                    T temp = _list[i];
                    _list[i] = _list[i + 1];//Swap İşlemi
                    _list[i + 1] = temp;
                }
            }
            public T[] InterSect(IEnumerable<T> collection)//T[]------->Bir T dizisi
            {
                
                T[] newList = new T[_list.Length];
                int i = 0;
                foreach (T item in _list.Intersect(collection).ToList())
                {
                    if (item != null)
                    {
                        newList[i] = item;
                        i++;
                    }
                }

                return newList;
            }
            public T[] Union(IEnumerable<T> collection)
            {
                
                T[] newList = new T[_list.Length + collection.Count()];
                int i = 0;
                foreach (T item in _list.Union(collection).ToList())
                {
                    if (item != null)
                    {
                        newList[i] = item;
                        i++;
                    }
                }

                return newList;
            }

            public T[] Except(IEnumerable<T> collection)
            {
               
                T[] newList = new T[_list.Length];
                int i = 0;
                foreach (T item in _list.Except(collection).ToList())
                {
                    if (item != null)
                    {
                        newList[i] = item;
                        i++;
                    }
                }

                return newList;
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _list.Take(index).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

    }
    }

