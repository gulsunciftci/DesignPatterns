using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.mementoo
{
    public class EditorState
    {
        public String content;

        public EditorState (String content)
        {
            this.content = content;
        }

    }
}
