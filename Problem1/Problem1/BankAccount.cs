using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class BankAccount
    {
        int money;
        public BankAccount(int money)
        {
            this.money = money;
        }

        public void Withdraw(int amount)
        {
            if ( amount < money)
            {
                money -= amount;
            }
        }
        public void Deposit(int amount)
        {
            money += amount;
        }
        public int Balance()
        {

            return money;
        }

    }
}
