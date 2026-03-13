using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.object_pool
{
    public class Client
    {
        public static void Run()
        {

            EquipmentPool pool = new EquipmentPool();

            Equipment tool1 = pool.Acquire();
            tool1?.Use();

            Equipment tool2 = pool.Acquire();
            tool2?.Use();

            Equipment tool3 = pool.Acquire();
            tool3?.Use();

            Equipment tool4 = pool.Acquire();

            pool.Release(tool1);

            Equipment tool5 = pool.Acquire();
            tool5?.Use();

            Console.WriteLine();
        }
    }
}