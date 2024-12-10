using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Factory_Method
{
    public interface ISquare
    {
        void Draw();
    }
    public interface IRectangle
    {
        void Draw();
    }
    public interface ITriangle
    {
        void Draw();
    }

    class SmallSquare : ISquare
    {
        public void Draw() { Console.WriteLine("Drawing a small square"); }
    }

    class HugeSquare : ISquare
    {
        public void Draw() { Console.WriteLine("Drawing a huge square"); }
    }

    class SmallRectangle : IRectangle
    {
        public void Draw() { Console.WriteLine("Drawing a small rectangle"); }
    }
    class HugeRectangle : IRectangle
    {
        public void Draw() { Console.WriteLine("Drawing a huge rectangle"); }
    }
    class SmallTriangle : ITriangle
    {
        public void Draw() { Console.WriteLine("Drawing a small triangle"); }
    }
    class HugeTriangle : ITriangle
    {
        public void Draw() { Console.WriteLine("Drawing a huge triangle"); }
    }

}
