using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Product hardDisk = new Product(50);
            hardDisk.ProductName = "HardDisk";


            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockKontrolEvent += Gsm_StockKontrolEvent;

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);

                Console.ReadLine();
            }

            Console.ReadLine();

        }

        private static void Gsm_StockKontrolEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }
}
