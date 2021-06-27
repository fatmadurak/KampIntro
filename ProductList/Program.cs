using System;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Dress";
            product1.ProductPrice = 250;
            product1.DiscountedPrice = 100;


            Product product2 = new Product();
            product2.ProductName = "Thsirt";
            product2.ProductPrice = 50;
            product2.DiscountedPrice = 25;


            Product product3 = new Product();
            product3.ProductName = "Pants";
            product3.ProductPrice = 80;
            product3.DiscountedPrice = 55;

            Product product4 = new Product();
            product4.ProductName = "Skirt";
            product4.ProductPrice = 60;
            product4.DiscountedPrice = 40;



            Product[] products=new Product[]{product1,product2,product3,product4 };


            Console.WriteLine("foreach");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName+"  "+product.ProductPrice+"  "+product.DiscountedPrice);

            }


            Console.WriteLine("for");


            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine(products[j].ProductName+"  "+products[j].ProductPrice+"  "+products[j].DiscountedPrice);
            }
        

          



            Console.WriteLine("While");

            int i = 0;
            while (i<products.Length)
            {
                Console.WriteLine(products[i].ProductName + " " + products[i].ProductPrice + " " + products[i].DiscountedPrice);
                i++;
            }

        }
    }


    class Product {


        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public int DiscountedPrice { get; set; }


    }




}
