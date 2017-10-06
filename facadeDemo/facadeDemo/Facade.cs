using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeDemo
{
    class Facade : Open
    {
        bool open;

        public void Open()
        {
            open = true;
            getLights(open);
            getChairs(open);
            doorsLocked(open);
            getDoorsOpen(open);
            sierraOn(open);
            computersOn(open);

        }

        public void Close()
        {
            open = false;
            getLights(open);
            getChairs(open);
            doorsLocked(open);
            getDoorsOpen(open);
            sierraOn(open);
            computersOn(open);

        }
    }
}
