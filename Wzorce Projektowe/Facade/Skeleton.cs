using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Facade
{
    public class Patron
    {
        string details;
        string patronId;
        public void Search() { Console.WriteLine("This is Patron's search method"); }
        void Request() { }
        void payFine() { }
    }
    public class PatronRecord
    {
        string patronId;
        string type;
        DateOnly dateOfMembership;
        int noBooksIssued;
        int maxBooksLimit;
        string name;
        string address;
        string phoneNo;
        int finesOwed;
        public void RetrieveMember() { Console.WriteLine("This is Patron Record's retrieve member method"); }
        void IncreaseBooksIssued() { }
        void DecreaseBooksIssued() { }
        void PayFine() { }
    }
}
