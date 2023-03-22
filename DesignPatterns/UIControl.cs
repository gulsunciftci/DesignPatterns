using System;

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