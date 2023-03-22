using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TextBox : UIControl
    {
        public override void draw()
        {
            Console.WriteLine("drawing a textbox");
        }
    }
}
