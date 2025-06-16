using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Encapsulation
{
    public class BankTest
    {
        private Wallet wallet = null!;

        [SetUp]
        public void Setup()
        {
            wallet = new Wallet(1000);
        }

        [Test]
        public void BankTestMethod()
        {
            Console.WriteLine("Initial balance: " + wallet.balance);
            wallet.AddMoney(100);
            //Console.WriteLine("Balance after adding money (200): " + wallet.GetBalance());
            Console.WriteLine("Balance after adding money (100): " + wallet.balance);

            wallet.RemoveMoney(300);
            Console.WriteLine("Balance after removing money (300): " + wallet.balance);
        }
    }
}
