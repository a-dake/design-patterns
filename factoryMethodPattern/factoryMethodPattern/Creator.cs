using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethodPattern
{
    abstract class Creator
   
    {
        private List<Product> shapes = new List<Product>();

        
        public Creator()
        {
            this.CreateShapes();
        }

        public List<Product> Shapes
        {
            get { return shapes; }
        }

    
        public abstract void CreateShapes();
    }
}
