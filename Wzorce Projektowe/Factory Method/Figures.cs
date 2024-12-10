using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Factory_Method
{
    public interface IShape
    {
        void Draw();
    }

    class Square : IShape {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
    class Rectangle : IShape {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Triangle : IShape {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }
}
