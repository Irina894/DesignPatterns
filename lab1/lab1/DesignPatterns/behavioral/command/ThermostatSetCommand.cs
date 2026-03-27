using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class ThermostatSetCommand : ICommand
    {
        private Thermostat thermostat;
        private int temperature;

        public ThermostatSetCommand(Thermostat thermostat, int temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            thermostat.SetTemperature(temperature);
        }
    }
}