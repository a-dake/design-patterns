using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyPattern
{
    class Context
    {
        private Strategy _strategy;
        private List<int> _list = new List<int>();

        public void SetOperation(Strategy strategy)
        {
            this._strategy = strategy; 
        }

        public int getListSize()
        {
            return _list.Count;
        }

        public void Add (int num)
        {
            _list.Add(num);
        }

        public void remove()
        {
            _list.Clear();
        }

        public int Calculate()
        {
            return _strategy.Calculate(_list);
        }
    }

    class Subtract : Strategy
    {
        public override int Calculate(List<int> _list)
        {
            return _list[0] - _list[1];
        }
    }

    class Add : Strategy
    {
        public override int Calculate(List <int> _list)
        {
            return _list[0] + _list[1];
        }
    }

    abstract class Strategy {
        public abstract int Calculate(List<int> _list);
    }


}
