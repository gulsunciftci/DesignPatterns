using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class UIControl
    {
        public void enable()
        {
            Console.WriteLine("enabled");
        }
        public abstract void draw();
    }
}
