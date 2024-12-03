using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Bridge
{
    class WriteImplementation
    {
        public void WriteUSAddress(SupportedFileTypes fileType)
        {
            switch (fileType)
            {
                case SupportedFileTypes.XML: XMLFile.WriteUSAddress(); break;
                case SupportedFileTypes.CSV: CSVFile.WriteUSAddress(); break;
                case SupportedFileTypes.FixedLength: FixedLengthFile.WriteUSAddress(); break;
            }
        }

        public void WriteUKAddress(SupportedFileTypes fileType)
        {
            switch (fileType)
            {
                case SupportedFileTypes.XML: XMLFile.WriteUKAddress(); break;
                case SupportedFileTypes.CSV: CSVFile.WriteUKAddress(); break;
                case SupportedFileTypes.FixedLength: FixedLengthFile.WriteUKAddress(); break;
            }
        }

        public void WritePlAddress(SupportedFileTypes fileType)
        {
            switch (fileType)
            {
                case SupportedFileTypes.XML: XMLFile.WritePLAddress(); break;
                case SupportedFileTypes.CSV: CSVFile.WritePLAddress(); break;
                case SupportedFileTypes.FixedLength: FixedLengthFile.WritePLAddress(); break;
            }
        }

    }

    static class XMLFile
    {
        public static void WriteUSAddress() { }
        public static void WriteUKAddress() { }
        public static void WritePLAddress() { }
    }

    static class CSVFile
    {
        public static void WriteUSAddress() { }
        public static void WriteUKAddress() { }
        public static void WritePLAddress() { }
    }

    static class FixedLengthFile
    {
        public static void WriteUSAddress() { }
        public static void WriteUKAddress() { }
        public static void WritePLAddress() { }
    }

}
