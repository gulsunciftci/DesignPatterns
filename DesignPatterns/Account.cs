using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Account
    {
        private float balance;

        //public void setBalance(float balance)
        //{
        //    if(balance>0)
        //          this.balance = balance;
        //}
        public float getBalance()
        {
            return this.balance;
        }
        public void deposit(float amount)
        {
            if(amount>0)
                  this.balance += amount;
        }
        public void Withdraw(float amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
        }
    }
}
