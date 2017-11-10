using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandPatternTutorial.ConcreteCommand
{
    public class AirConditionerOn: ICommand
    {
        AirConditioner ac;

        public AirConditionerOn(AirConditioner ac)
        {
            this.ac = ac;
        }
        public void Execute()
        {
            ac.TurnOn();
            ac.IncreaseTemp();
        }
    }
}
