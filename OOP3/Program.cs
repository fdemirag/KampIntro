using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        //ihtiyacKrediManager.Hesapla();

        //TasitKrediManager tasitKrediManager = new TasitKrediManager();
        //tasitKrediManager.Hesapla();

        //KonutKrediManager konutKrediManager = new KonutKrediManager();
        //konutKrediManager.Hesapla();

        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

        IKrediManager tasitKrediManager = new TasitKrediManager();
         
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        //BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
        BasvuruManager basvuruManager = new BasvuruManager();


        List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager };

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}