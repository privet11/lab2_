using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard("123456789");
            Console.WriteLine(creditCard.info());

            Console.Read();
        }
    }
}
