using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            //IKrediMaager interface olduğu için diğer kredimanager lere bağlı bundan yararlanarak ana ekrana hangi kredi türü verilirse onu hesaplayacaktır.
            //Yukarıdaki basvuruyap komutunda görüldüğü gibi ister taşıt ister konut girilsin hepsinin kendine özel olan hesaplaması çalışacak.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //Yukarıda Listeye kaçtane kredi türü girilirse o kadar hesaplamayı aynı anda ekrana taşır.

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
