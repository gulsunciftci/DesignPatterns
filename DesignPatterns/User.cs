using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class User
    {

        //field
        public String Name;
        //Constructur
        public User(String Name, int age)
        {
            this.Name = Name;
        }
        //Methods
        public void sayHello()
        {
            Console.WriteLine("Hello my name is " + this.Name);
        }
    }
}
