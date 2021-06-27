using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Fatma";
            musteri1.Soyad = "DURAK";
            musteri1.TcNo = "3246586";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Ad = "Usame";
            musteri2.Soyad = "DURAK";
            musteri2.TcNo = "15646486";

            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.Ad = "Zeliha";
            musteri3.Soyad = "YILANCI";
            musteri3.TcNo = "648651";


            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            musteriManager.Ekleme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriler);

        }
    }
}
