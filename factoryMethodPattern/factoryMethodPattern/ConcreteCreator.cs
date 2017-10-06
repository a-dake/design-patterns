using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethodPattern
{
    class ConcreteCreatorOctopus : Creator
    {
        public override void CreateShapes()
        {
            Shapes.Add(new Circle());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
        }
    }
    class ConcreteCreatorPerson : Creator
    {
        public override void CreateShapes()
        {
            Shapes.Add(new Circle());
            Shapes.Add(new Triangle());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
            Shapes.Add(new Line());
        }
    }
    class ConcreteCreatorHouse : Creator
    {
        public override void CreateShapes()
        {
            Shapes.Add(new Square());
            Shapes.Add(new Square());
            Shapes.Add(new Square());
            Shapes.Add(new Rectangle());
            Shapes.Add(new Circle());
        }
    }

}
