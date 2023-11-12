using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Musteri musteri1 = new Musteri();

        //musteri1.Adi = "Engin";
        //musteri1.Soyadi = "Demiroğ";
        //musteri1.Id = 1;
        //musteri1.TcNo = "123456789";
        //musteri1.MusteriNo = "12345";

        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Adi = "Engin";
        musteri1.Soyadi = "Demiroğ";
        musteri1.TcNo = "12345678901";
        musteri1.MusteriNo = "12345";
        musteri1.Id = 1;


        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "12344";
        musteri2.SirketAdi="kodlama.io";
        musteri2.VergiNo = "12312";

        Musteri musteri3 = new TuzelMusteri();
        Musteri musteri4 = new GercekMusteri();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(musteri3);
        customerManager.Add(musteri4);
    }
}