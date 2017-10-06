using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteratorPattern
{
    class ConcreteAggregate : Aggregate
    {
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
