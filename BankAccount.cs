using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_16
{
    public class BankAccount
    {
      public BankAccount(string Name,int num)
        {
            this.AccountNumber = num;
            this.AccountHolderName = Name;
            this.Balance = 0;
        }
        private decimal Balance;
        public decimal balance
        {
            get { return Balance; } 
        }
        private readonly int AccountNumber;
        public int accountNumber
        {
            get { return AccountNumber; } }

        private string AccountHolderName;
        public string accountHolderName
        {
            get { return AccountHolderName; }
            set { AccountHolderName = value; }
        }
        
        public void Deposit(decimal amount)
        {
            if (amount >0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit {amount} \n New Balance: {balance}");
            }
            else
            {
                Console.WriteLine($"Please Put Amount Which is greater than Zero");
            }
           

        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <=balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw Money {amount} \n New Balance: {balance}");
            }
            else {
                Console.WriteLine($"Please Put Amount Which is greater than Zero");
            }
            
        }
        
    }
}
