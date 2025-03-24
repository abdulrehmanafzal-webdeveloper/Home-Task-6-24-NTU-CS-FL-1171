using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "potato", 45, 40);
            Product product2 = new Product(2, "apple", 78, 30);
            Product product3 = new Product(2, "apple", 78, 30);

            Store store = new Store("Imtiaz", "Sheikhpura road");

            store.addproduct(product1);
            store.addproduct(product2);
            store.addproduct(product3);

            store.displaypoductinfo();


            Shape shape1 = new Shape(1,"Circle","Red");
            Shape shape2 = new Shape();
            shape2.shape_id = 2;
            shape2.shape_Type = "Triangle";
            shape2.shape_Color = "Blue";

            Shape shape3 = new Shape();
            shape3.shape_id = 3;
            shape3.shape_Type = "Rectangle";
            shape3.shape_Color = "Yellow";


            Shape shape4 = new Shape(4,"Parallelogram","Green");


            Canvas canvas1 = new Canvas(1);
            canvas1.Add_shape(shape1);
            canvas1.Add_shape(shape2);
            canvas1.Add_shape(shape3);
            canvas1.Add_shape(shape4);

            Console.WriteLine("Canvas before changes");
            Canvas Shallow_copy_Canvas= canvas1;
            Canvas Deep_copy_Canvas = new Canvas(canvas1);
            Console.WriteLine("shallow copy of  canvas\n");
            Shallow_copy_Canvas.Display_shapes();
            Console.WriteLine("original  canvas\n");
            canvas1.Display_shapes();
            Console.WriteLine("Deep copy of  canvas\n");
            Deep_copy_Canvas.Display_shapes();

            Console.ReadLine();
            Console.Clear();


            Shape shape5 = new Shape(1, "ytr", "Red");
            Console.WriteLine("Canvas After changes");
            Shallow_copy_Canvas.Add_shape(shape5);
            Console.WriteLine("shallow copy of  canvas\n");
            Shallow_copy_Canvas.Display_shapes();
            Console.WriteLine("original  canvas\n");
            canvas1.Display_shapes();
            Console.WriteLine("Deep copy of  canvas\n");
            Deep_copy_Canvas.Display_shapes();
        }
    }
}
