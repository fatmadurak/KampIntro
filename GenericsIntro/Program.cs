using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
          

         

            MyList<string> isimler = new MyList<string>();

            isimler.Add("Fatma");
            Console.WriteLine(isimler.Length);

            isimler.Add("Usame");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
     

        }
    }
}
