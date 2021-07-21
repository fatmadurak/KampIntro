using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{

    public delegate void StockKontrol();
   public class Product
    {
        public int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }


        public event StockKontrol StockKontrolEvent;
        public string ProductName { get; set; }
        public int Stock { get 
            {
                return _stock;
            }
            set 
            {
                _stock = value;

                if (value<=15 && StockKontrolEvent!=null)
                {
                    StockKontrolEvent();
                }
            }
        }


        public void Sell(int amount) 
        
        {

            Stock -= amount;
            Console.WriteLine("{1} Stock amount : {0}",Stock,ProductName);
        
        }



    }
}
