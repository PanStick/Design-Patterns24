using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Bridge
{
    enum SupportedFileTypes
    {
        XML,
        CSV,
        FixedLength
    }

    abstract class AddressSystem(WriteImplementation imp)
    {
        protected WriteImplementation imp = imp;

        public abstract void Write(SupportedFileTypes fileType);
    }

    class USAddress(WriteImplementation imp) : AddressSystem(imp)
    {
        public override void Write(SupportedFileTypes fileType)
        {
            imp.WriteUSAddress(fileType);
        }
    }

    class UKAddress(WriteImplementation imp) : AddressSystem(imp)
    {
        public override void Write(SupportedFileTypes fileType)
        {
            imp.WriteUKAddress(fileType);
        }
    }

    class PLAddress(WriteImplementation imp) : AddressSystem(imp)
    {
        public override void Write(SupportedFileTypes fileType)
        {
            imp.WritePlAddress(fileType);
        }
    }
}
