using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state
{
    public class SelectionTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("selection icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("draw a dashed rectangle");
        }
    }
}
