using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a 'Bank Account'  //
            // 10digit number, name of owners, account balance, accept deposit and withdrawl
            //initial balance should be positive(+)          //able  to show negative balance

            var account = new BankAccount("Billy Bob", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
    }
}
