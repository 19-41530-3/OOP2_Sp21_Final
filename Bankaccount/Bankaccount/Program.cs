using System;

namespace Bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Account a1 = new Account("Hasan", "4143", 5000);
            Account a2 = new Account("Mim", "5246", 4000);
            a1.Withdraw(1000);
            a1.Deposit(3000);
            a1.Transfer(2000, a2);
            a1.showAllTransactions();
            a2.showAllTransactions();
        }
    }
}
