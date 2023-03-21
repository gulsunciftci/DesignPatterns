using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User(Name: "Gulsun",age: 24);
            Console.WriteLine(user.Name);
            user.sayHello();

            TaxCalculator calculator = getCalculator();
            calculator.calculateTax();

           var account = new Account();
            account.deposit(10);
            account.Withdraw(5);
            Console.WriteLine(account.getBalance());
        
        }
        public static TaxCalculator getCalculator()
        {
            return new TaxCalculator2019();
        }
    }
}
