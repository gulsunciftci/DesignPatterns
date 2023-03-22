using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.mementoo
{
    public class Editor
    {
        private String content;
        
        public String getContent()
        {
            return content;
        }
        public void setContent(String content)
        {
            this.content = content;
        }
    }
}
