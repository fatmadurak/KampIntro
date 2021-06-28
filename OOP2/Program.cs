using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();

            //Fatma Durak

            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Fatma";
            musteri1.Soyadi = "Durak";
            musteri1.TcNo = "234845454";

            //Kodlama.io
            
            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "120";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1574863";


            Musteri musteri3 = new GercekMusteri();  
            Musteri musteri4 = new TuzelMusteri();



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
