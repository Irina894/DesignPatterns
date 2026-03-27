using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public interface IPostIterator
    {
        bool HasNext();
        Post Next();
    }
}
