using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compositePattern
{
    abstract class Component
    {
        public List<Component> bandList = new List<Component>();
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component band);

        public abstract void remove(Component band);

        public abstract string getBandName();

        public abstract string getAlbums();

        public abstract string getMembers();

        public abstract string Display(int depth);

        
    }
}
