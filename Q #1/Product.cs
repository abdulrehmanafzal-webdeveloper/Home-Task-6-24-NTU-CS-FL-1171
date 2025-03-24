using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__1
{
    internal class Product
    {
        private int Product_id;
        private string Name;
        private double Price;
        private int Quantity_in_stock;


        public Product(
        int Product_id=0,
        string Name="",
        double Price=0,
        int Quantity_in_stock = 0)
        {
            this.Product_id = Product_id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity_in_stock = Quantity_in_stock;
        }

        public void displayinfo()
        {
            Console.Write($"{Product_id}        {Name}         {Price}            {Quantity_in_stock} \n");
        }
        
        ~Product()
        {
            Console.WriteLine("Product is killed");
        }
    }
}
