using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.object_pool
{
    public class EquipmentPool
    {
        private Queue<Equipment> available = new Queue<Equipment>();

        public EquipmentPool()
        {
            available.Enqueue(new Equipment("Drill #1"));
            available.Enqueue(new Equipment("Drill #2"));
            available.Enqueue(new Equipment("Concrete Mixer #1"));
        }

        public Equipment Acquire()
        {
            if (available.Count == 0)
            {
                Console.WriteLine("No equipment available. Please wait.");
                return null;
            }

            Equipment equipment = available.Dequeue();
            Console.WriteLine($"Equipment acquired: {equipment.Name}");
            return equipment;
        }

        public void Release(Equipment equipment)
        {
            Console.WriteLine($"Equipment returned: {equipment.Name}");
            available.Enqueue(equipment);
        }
    }
}
