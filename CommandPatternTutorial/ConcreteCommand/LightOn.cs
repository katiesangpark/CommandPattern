using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.ConcreteCommand
{
    public class LightOn : ICommand
    {
        Light light;
        //constructor
        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
