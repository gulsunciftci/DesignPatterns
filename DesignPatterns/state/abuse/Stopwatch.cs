using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state.abuse
{
    public class Stopwatch
    {

        private State currentState;

        public void click()
        {
            this.currentState.click();
        }
        public State getCurrentState()
        {
            return currentState;
        }
        public void setCurrentState(State currentState)
        {
            this.currentState = currentState;
        }
        
        
    }
}
