using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.ConcreteCommand
{
    public class AirConditionerOff : ICommand
    {
        AirConditioner ac;

        public AirConditionerOff(AirConditioner ac)
        {
            this.ac = ac;
        }
        public void Execute()
        {
            ac.TurnOff();
            ac.DecreaseTemp();
        }
  
    
    }
}
