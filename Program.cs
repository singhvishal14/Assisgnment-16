using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Vishal",123);
            Console.WriteLine($"AccountHolder Name  is: {account.accountHolderName} Account Number is: {account.accountNumber}");
            
            Console.WriteLine($"Balance is: {account.balance}");
            Console.WriteLine("Please Enter Deposit Money");
            account.Deposit(decimal.Parse(Console.ReadLine()));
            Console.WriteLine($"Money After Deposit: {account.balance}");
            Console.WriteLine("Please Show Withdrawn Money");
            account.Withdraw(decimal.Parse(Console.ReadLine()));
            Console.WriteLine($"Money After Withdraw: {account.balance}");
            Console.ReadKey();
        }
    }
}
