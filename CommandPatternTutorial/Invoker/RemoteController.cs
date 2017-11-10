using CommandPatternTutorial.AbstractCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.Invoker
{
    //Set up Controller
    public class RemoteController
    {
        private IList<ICommand> turnOnCommands = new List<ICommand>();//AC ON, LIGHT ON
        private IList<ICommand> turnOffCommands = new List<ICommand>();//AC OFF, LIGHT OFF

        public void InsertNewOnCommand(ICommand command)
        {
            turnOnCommands.Add(command);

        }
        public void InsertNewOffCommand(ICommand command)
        {
            turnOffCommands.Add(command);
        }
        public void PressButtonOn(int buttonNumber)
        {
            turnOnCommands[buttonNumber].Execute();
        }
        public void PressButtonOff(int buttonNumber)
        {
            turnOffCommands[buttonNumber].Execute();
        }
    }

    
}
