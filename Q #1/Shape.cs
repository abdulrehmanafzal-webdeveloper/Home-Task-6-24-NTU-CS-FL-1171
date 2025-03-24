using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Q__1
{
    internal class Shape
    {
        private int Shape_ID;
        private string Shape_Type;
        private string Shape_Color;

        public int shape_id

        {

            get { return Shape_ID; }

            set { Shape_ID = value; }

        }

        public string shape_Type

        {

            get { return Shape_Type; }

            set { Shape_Type = value; }

        }

        public string shape_Color

        {

            get { return Shape_Color; }

            set { Shape_Color = value; }

        }




        public Shape(int shape_ID=0, string shape_Type=" ", string shape_Color = " ")
        {
            Shape_ID = shape_ID;
            Shape_Type = shape_Type;
            Shape_Color = shape_Color;
        }

        public void Draw()
        {
            Console.WriteLine($"{Shape_ID}      {Shape_Type}                  {Shape_Color}");
        }
    }
}
