using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    class Account
    {
        public static void main(string[] args) {
            var account = new BankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
