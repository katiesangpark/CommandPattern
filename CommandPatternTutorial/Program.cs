using CommandPatternTutorial.ConcreteCommand;
using CommandPatternTutorial.Invoker;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial
{
    class Program

    {
        static void Main(string[] args)
        {
            Light bedRoomLights = new Light();
            AirConditioner acForEntireHouse = new AirConditioner();

            LightOn turnBedRoomLightsOn = new LightOn(bedRoomLights);
            AirConditionerOn turnOnAC = new AirConditionerOn(acForEntireHouse);

            LightOff turnBedRoomLightsOff = new LightOff(bedRoomLights);
            AirConditionerOff turnOffAC = new AirConditionerOff(acForEntireHouse);

            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnBedRoomLightsOn);
            remote.InsertNewOnCommand(turnOnAC);

            remote.InsertNewOffCommand(turnBedRoomLightsOff);
            remote.InsertNewOffCommand(turnOffAC);

            remote.PressButtonOn(0);
            remote.PressButtonOn(1);

            remote.PressButtonOff(0);
            remote.PressButtonOff(1);
        }
    }
}
