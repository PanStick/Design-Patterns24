using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Prototype
{
    abstract class Multimedia
    {
        protected string _name = "default";
        public abstract Multimedia Clone();
        public abstract override string ToString();
    }


    class Picture : Multimedia
    {
        public Picture() { }
        public Picture(string name) { _name = name; }

        public override Picture Clone()
        {
            return new(_name);
        }
        public override string ToString()
        {
            return _name + " is a Picture";
        }

    }
    class Music : Multimedia
    {
        public Music() { }
        public Music(string name) { _name = name; }

        public override Music Clone()
        {
            return new(_name);
        }
        public override string ToString()
        {
            return _name + " is Music";
        }
    }
    class Movie : Multimedia
    {
        public Movie() { }
        public Movie(string name) { _name = name; }
        public override Movie Clone()
        {
            return new(_name);
        }
        public override string ToString()
        {
            return _name + " is a Movie";
        }
    }
}
