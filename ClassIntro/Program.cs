using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Fatma DURAK";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Usame DURAK";
            kurs2.IzlenmeOrani = 70;


            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Merve Cekin";
            kurs3.IzlenmeOrani = 80;


            Kurs kurs4 = new Kurs();

            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Zeliha BADILLI";
            kurs4.IzlenmeOrani = 50;

            // Console.WriteLine(kurs1.KursAdi+" :"+kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
            }





        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}
