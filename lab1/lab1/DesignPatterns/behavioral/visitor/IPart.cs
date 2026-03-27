using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public interface IPart
    {
        void Accept(IVisitor visitor);
    }
}
