using System;

namespace DesignPatterns.structural.composite
{
    public class Client
    {
        public static void Run()
        {

            SmartLight light1 = new SmartLight("Living Room Lamp");
            SmartLight light2 = new SmartLight("Kitchen Lamp");
            SmartLight light3 = new SmartLight("Bedroom Lamp");

            Zone livingRoom = new Zone("Living Room");
            livingRoom.Add(light1);

            Zone kitchen = new Zone("Kitchen");
            kitchen.Add(light2);

            Zone bedroom = new Zone("Bedroom");
            bedroom.Add(light3);

            Zone floor1 = new Zone("Floor 1");
            floor1.Add(livingRoom);
            floor1.Add(kitchen);

            Zone house = new Zone("House");
            house.Add(floor1);
            house.Add(bedroom);

            house.Execute();

            Console.WriteLine();
        }
    }
}