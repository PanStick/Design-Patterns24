using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Decorator
{
    interface IBikeComponent
    {
        public void Create();
    }
    class Bike : IBikeComponent
    {
        public void Create() { Console.WriteLine("Creating bike"); }
    }

    abstract class Decorator(IBikeComponent wrappee) : IBikeComponent
    {
        protected IBikeComponent wrappee = wrappee;

        public virtual void Create() { wrappee.Create(); }
    }

    class Bell(IBikeComponent wrappee) : Decorator(wrappee)
    {
        public override void Create()
        {
            base.Create();
            Console.WriteLine("Adding Bell");
        }
    }

    class Speedometer(IBikeComponent wrappee) : Decorator(wrappee)
    {
        public override void Create()
        {
            base.Create();
            Console.WriteLine("Adding Speedometer");
        }
    }

    class BottleHolder(IBikeComponent wrappee) : Decorator(wrappee)
    {
        public override void Create()
        {
            base.Create();
            Console.WriteLine("Adding Bottle Holder");
        }
    }
}
