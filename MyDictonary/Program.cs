

using GenericMyDictonary;
using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictonary = new MyDictionary<int, string>();

            myDictonary.Add(1, "Fatma");
            myDictonary.Add(2, "Usame");
            myDictonary.Add(3, "Merve");

            Console.WriteLine(myDictonary.Count);

            for (int i = 0; i < myDictonary.Count; i++)
            {
                Console.WriteLine("Key: " + myDictonary.Key[i] + " Value:  " + myDictonary.Value[i]);

            }




        }
    }
}
