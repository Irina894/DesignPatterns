using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class SmartHomeFacade
    {
        private Light light;
        private AirConditioning airConditioning;
        private TV tv;
        private SecuritySystem security;
        private SmartBlinds blinds;

        public SmartHomeFacade()
        {
            light = new Light();
            airConditioning = new AirConditioning();
            tv = new TV();
            security = new SecuritySystem();
            blinds = new SmartBlinds();
        }

        public void LeaveHome()
        {
            Console.WriteLine("Activating 'Leave Home' mode...");

            light.Off();
            airConditioning.SetEcoMode();
            tv.Off();
            blinds.Close();
            security.Activate();
        }
    }
}