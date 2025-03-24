using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__1
{
    internal class Store
    {
        private string Store_name;
        private string Location;
        Product[] Product;
        private int count;
        public Store(string Store_name="", string Location="")
        {
            this.Store_name = Store_name;
            this.Location = Location;
           Product=new Product[50];
            count = 0;
        }

        public void addproduct(Product product)
        {
            if (count<Product.Length)
            {
                Product[count] = product;
                count++;
            }
            else
            {
                Console.WriteLine("can't add more products");
            }
        }

        public void displaypoductinfo()
        {
            Console.WriteLine("Product_Id |  Name  | Price  |  Quantity_in_stock");
            Console.WriteLine("___________________________________________");
            for (int i = 0; i < count; i++)
            {
                Product[i].displayinfo();
            }
        }
        
        ~Store()
        {
            Console.WriteLine("Store is killed");
        }
    }
}
