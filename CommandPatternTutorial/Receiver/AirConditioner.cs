using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial.Receiver
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("Air Conditioner is off!");
        }
       
        public void TurnOff()
        {
            Console.WriteLine("Air Conditioner is off!");
        }
        
        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing Temperature");
        }
       
        public void DecreaseTemp()
        {
            Console.WriteLine("Decreasing Temperature");
        }
    }
}
