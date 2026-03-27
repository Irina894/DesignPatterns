using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public interface IVisitor
    {
        void VisitEngine(Engine engine);
        void VisitBrakes(Brakes brakes);
        void VisitElectronics(Electronics electronics);
    }
}
