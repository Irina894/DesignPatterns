using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public class Engine : IPart
    {
        public string Model = "V8 Turbo";
        public bool IsBroken = true;
        public void Accept(IVisitor visitor) => visitor.VisitEngine(this);
    }

    public class Brakes : IPart
    {
        public int WearLevel = 80;
        public void Accept(IVisitor visitor) => visitor.VisitBrakes(this);
    }

    public class Electronics : IPart
    {
        public int ErrorCount = 5;
        public void Accept(IVisitor visitor) => visitor.VisitElectronics(this);
    }
}
