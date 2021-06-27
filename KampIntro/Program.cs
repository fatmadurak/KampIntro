using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler ";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu ");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
       
        }
    }
}
