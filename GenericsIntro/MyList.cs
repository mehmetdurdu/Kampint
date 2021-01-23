using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Referans numaraını tutuması için oluşturduk.Dizi elemanları kaybolmaması için.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //Geçici diziden değerleri tekrar diziye alıyoruz.Bu sayede değerler kaybolmamış oldu.
            }

            items[items.Length - 1] = item; //Dizinin son elemanına fonksiyondan gelen item ı atıyoruz.
        }
    }
}
