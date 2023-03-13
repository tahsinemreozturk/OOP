using OOP3;

internal class Program
{    // INTERFACE ~REFERANS TUTUCU~
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DataBaseLoggerService();
        ILoggerService fileLogerService = new FileBaseLoggerService();
         
        
        BasvuruManager basvuruManager= new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);





    }
}