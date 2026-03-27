using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class Client
    {
        public static void Run()
        {

            Light light = new Light();
            Thermostat thermostat = new Thermostat();

            ICommand lightCommand = new LightOnCommand(light);
            ICommand thermostatCommand = new ThermostatSetCommand(thermostat, 22);
           

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(lightCommand);
            remote.PressButton();

            remote.SetCommand(thermostatCommand);
            remote.PressButton();
            remote.PressButton();

            Console.WriteLine();
        }
    }
}
