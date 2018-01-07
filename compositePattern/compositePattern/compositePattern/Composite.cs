using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compositePattern
{
    class Composite : Component
    {
       //public List<Component> bandList = new List<Component>();
       // string band;

        public Composite(String name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            bandList.Add(c);
        }

        public override string Display(int depth)
        {
            Console.WriteLine(new String('-', depth) +
       "+ " + name);
            foreach (Component c in bandList)
            {
                c.Display(depth + 2);
               // return new String('-', depth) +
      // "+ " + name;

            }
            return new String('-', depth) +
       "+ " + name;
            
            
        }

        public override string getAlbums()
        {
            throw new NotImplementedException();
        }

        public override string getBandName()
        {
            return "";
        }

        public override string getMembers()
        {
            throw new NotImplementedException();
        }

        public override void remove(Component c)
        {
            bandList.Remove(c);
        }
    }
}
