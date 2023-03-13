using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Emre Ozturk
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Emre";
        musteri1.Soyad = "Ozturk";
        musteri1.TcNo = "12345678";

        //Ozturk Ticaret
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 1;
        musteri2.MusteriNo = "21314";
        musteri2.SirketAdi= "Ozturk Ticaret";
        musteri2.VergiNo = "2345AQFV2";

        Musteri musteri3= new GercekMusteri(); //new= bellekteki refernas no demek...
        Musteri musteri4 = new TuzelMusteri();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(musteri1);
        customerManager.Add(musteri2);








        // kurumsallikta verim icin gercek musteri ve tuzel musteri ayrimi yapilmalidir.
        // Gercek Nesne-Tuzel Nesne
    }
}