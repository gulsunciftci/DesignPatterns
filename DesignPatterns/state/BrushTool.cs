using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state
{
    public class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("draw a line");
        }
    }
}
