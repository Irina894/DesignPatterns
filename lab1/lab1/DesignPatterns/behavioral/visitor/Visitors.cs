using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
 
    public class StatusCheckVisitor : IVisitor
    {
        public void VisitEngine(Engine e) => Console.WriteLine($"[Status] Engine: {(e.IsBroken ? "Needs Repair" : "OK")}");
        public void VisitBrakes(Brakes b) => Console.WriteLine($"[Status] Brakes: Wear {b.WearLevel}%");
        public void VisitElectronics(Electronics el) => Console.WriteLine($"[Status] Electronics: {el.ErrorCount} errors");
    }

    public class PriceEstimateVisitor : IVisitor
    {
        public double Total = 0;
        public void VisitEngine(Engine e) => Total += 500;
        public void VisitBrakes(Brakes b) => Total += 200;
        public void VisitElectronics(Electronics el) => Total += 150;
    }

    public class RepairVisitor : IVisitor
    {
        public void VisitEngine(Engine e) { e.IsBroken = false; Console.WriteLine("[Repair] Fixed Engine"); }
        public void VisitBrakes(Brakes b) { b.WearLevel = 0; Console.WriteLine("[Repair] Replaced Brakes"); }
        public void VisitElectronics(Electronics el) { el.ErrorCount = 0; Console.WriteLine("[Repair] Reset Electronics"); }
    }
}
