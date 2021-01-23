using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }

    //interfaceleri birbirinin alternatifi olan ancak kod içerikleri farklı olan yapılar için kullanırız.
    //Yapılan örnekte kredi türleri farklı buna göre hesaplama türleri farklı olacağından Hesapla fonksiyonunu interface içerisinde yaptık.
}
