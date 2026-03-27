using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public interface IObserver
    {
        void Update(string parcelId, string status);
    }
}
