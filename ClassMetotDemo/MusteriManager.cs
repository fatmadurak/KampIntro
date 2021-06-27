using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
  public class MusteriManager
    {

        public void Ekleme(Musteri musteri) {


            Console.WriteLine(musteri.Ad+"   "+musteri.Soyad+ "  Eklendi.");
        
        }


        public void Silme(Musteri musteri) 
        {

            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad + "  Silindi.");
        }


        public void Listeleme(Musteri[] musteriler) 
        {

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+"  "+musteri.Soyad+"   "+musteri.TcNo);

            }

            Console.WriteLine(" Listelendi..");
          
        }

    }
}
