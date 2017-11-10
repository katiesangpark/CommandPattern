using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.ConcreteCommand
{
    public class LightOff : ICommand
    {
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.off();
        }
    }
}
