using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compositePattern
{
    class Leaf : Component
    {
        String albumName;
       // String memberName;
        public List<String> memberList = new List<String>();

        public Leaf(string name)
            : base(name)
        {
        }

        
    public override void Add(Component c)
    {
            throw new NotImplementedException();
        }

    public override void remove(Component band)
    {
        throw new NotImplementedException();
    }

    public override string getBandName()
    {
        throw new NotImplementedException();
    }

    public override string getAlbums()
    {
           return albumName;
    }

    public override string getMembers()
    {
            throw new NotImplementedException();
        }

        public override string Display(int depth)
        {
           //Console.WriteLine(
        //new String('-', depth) + " " + name);
            //foreach (Component c in bandList)
            //{
            //    c.Display(depth + 2);
            //    // return new String('-', depth) +
            //    // "+ " + name;

            //}
            return new String('-', depth) + " " + name);

        }
        
    }
}


