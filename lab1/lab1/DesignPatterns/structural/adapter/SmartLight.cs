using System;

namespace DesignPatterns.structural.adapter
{
    public class SmartLight
    {
        public void Illuminate(int brightnessLevel)
        {
            Console.WriteLine($"Smart light shining with brightness {brightnessLevel}%");
        }
    }
}