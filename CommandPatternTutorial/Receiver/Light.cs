using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.Receiver
{
    //turn on and off
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights are on!");
        }
        public void off()
        {
            Console.WriteLine("Lights are off!");
        }
    }
}
