using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state.abuse
{
    public class RunningState : State
    {
        private Stopwatch stopwatch;
        public RunningState (Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
        public void click()
        {
            stopwatch.setCurrentState(new StoppedState(stopwatch));
            Console.WriteLine("Stopped");
        }
    }
}
