using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items;
        // constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        { // burda yukarıda oluşturduğun array'e eleman eklemk istiyorsun ama arrayin önce newlenme zorunluluğu var o yüzden constructor içine yazdık. çünkü constructor zaten her türlü çalışacak.
     
            T[] tempArray= items;// newlediğinde referans tip olduğu için yeni referans numarası alacak ve önceki elemanlar kaybolacak o yüzden geçici diziye attık.
             items = new T[items.Length+1];// dizinin eleman sayısını bir arttır.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length -1] = item;
        }
    }
}
