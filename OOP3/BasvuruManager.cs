using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection- Hangi kredi türü, hangi loglama olacağı enjekte edilir.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //Yukarıda girdi olarak hangi kredi gönderilirse onun hesaplası çalışacaktır.

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla krediyi aynı anda hesaplamak için List seçeneğini ve türünü kullanabiliriz.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
