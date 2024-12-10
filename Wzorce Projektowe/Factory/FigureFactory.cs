using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Wzorce_Projektowe.Factory_Method;

namespace Wzorce_Projektowe.Factory
{
    interface IFigureAbstractFactory
    {
        static abstract ISquare CreateSquare();
        static abstract IRectangle CreateRectangle();
        static abstract ITriangle CreateTriangle();
    }

    class SmallFigureFactory : IFigureAbstractFactory
    {
        public static ISquare CreateSquare() { return new SmallSquare(); }
        public static IRectangle CreateRectangle() { return new SmallRectangle(); }
        public static ITriangle CreateTriangle() { return new SmallTriangle(); }
    }

    class HugeFigureFactory : IFigureAbstractFactory
    {
        public static ISquare CreateSquare() { return new HugeSquare(); }
        public static IRectangle CreateRectangle() { return new HugeRectangle(); }
        public static ITriangle CreateTriangle() { return new HugeTriangle(); }
    }
}
