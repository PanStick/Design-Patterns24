using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Factory_Method
{
    interface ICreator
    {
        static abstract IShape Factory();
    }

    class SquareCreator : ICreator
    {
        public static IShape Factory() { return new Square(); }
    }

    class RectangleCreator : ICreator
    {
        public static IShape Factory() { return new Rectangle(); }
    }

    class TriangleCreator : ICreator
    {
        public static IShape Factory() { return new Triangle(); }
    }

}
