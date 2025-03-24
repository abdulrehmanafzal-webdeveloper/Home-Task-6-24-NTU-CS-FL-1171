using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__1
{
    internal class Canvas
    {
        private int Canvas_ID;
        Shape[] Shape;
        int count;

        public int canvas_ID

        {

            get { return Canvas_ID; }

            set { Canvas_ID = value; }

        }

        public Canvas(Canvas canvas)
        {
            this.Canvas_ID=canvas.Canvas_ID;
            this.count = canvas.count;
            Shape = new Shape[50];
            for (int i = 0; i < count; i++)
            {
                this.Shape[i] = canvas.Shape[i];
            }
        }


        public Canvas(int canvas_ID=0)
        {
            Canvas_ID = canvas_ID;
            Shape=new Shape[50];
            count = 0;
        }

        public void Add_shape(Shape shape)
        {
            Shape[count] = shape;
            count++;
        }

        public void Display_shapes()
        {
            Console.WriteLine("Shape_ID  |    Shape_type  |    Shape_Color");
            Console.WriteLine("________________________________________________");
            for (int i = 0; i < count; i++)
            {
                Shape[i].Draw();
            }
        }
    }
}
