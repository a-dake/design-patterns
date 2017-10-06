using System;
using System.Collections.Generic;

namespace iteratorPattern
{
    class ConcreteIterator : Iterator
    {
        int current = 1;
        private ConcreteAggregate concreteAggregate;
        Book b = new Book();
    
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            this.concreteAggregate = concreteAggregate;
        }

        public ConcreteIterator()
        {
        }

        public override object First()
        {

            return current;  
        }
        public override object Next()
        {
            if (isDone())
                return null;
            else
            return current;
        }

        public override object CurrentItem()
        {
            return current;
        }
        public override bool isDone()
        {
       
            current++;
            if (current >= 4)
                return true;
            else return false;
        }
    }
}

