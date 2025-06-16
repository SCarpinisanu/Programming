using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Encapsulation
{
    public class Wallet
    {
        public int balance { get; private set; }
        public Wallet(int initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            this.balance = initialBalance;
        }
        public void AddMoney(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to add cannot be negative.");
            }
            this.balance += amount;
        }
        public void RemoveMoney(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to remove cannot be negative.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            this.balance -= amount;
        }
        //public int Balance
        //{
        //    get { return this.balance; }
        //}
        //public int GetBalance()
        //{
        //    return this.balance;
        //}
    }
}
