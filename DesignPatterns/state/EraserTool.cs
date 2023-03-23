using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state
{
    public class EraserTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("eraser icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("eraser something");
        }
    }
}
