using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.state.abuse
{
    public class StoppedState : State
    {
        private Stopwatch stopwatch;

        public StoppedState(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
        public void click()
        {
            stopwatch.setCurrentState(new RunningState(stopwatch));
            Console.WriteLine("Running");
        }
    }
}
