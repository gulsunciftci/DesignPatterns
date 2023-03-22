using System;

namespace DesignPatterns
{
    public class TextBox:UIControl
    {
       
        public override void draw()
        {
            Console.WriteLine("drawing a textbox");
        }
    }
}