using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeDemo
{
    class Open
    {

        public string getLights(bool open)
        {
            if (open == true)
            {
                return "On";
            }
            else return "Off";
        }

        public string getChairs(bool open)
        {
            if (open == true)
            {
                return "Pushed in";
            }
            else return "Pushed in";
        }

        public string doorsLocked(bool open)
        {
            if (open == true)
            {
                return "Unlocked";
            }
            else return "Locked";
        }

        public string getDoorsOpen(bool open)
        {
            if (open == true)
            {
                return "Open";
            }
            else return "Open";
        }

        public string sierraOn(bool open)
        {
            if (open == true)
            {
                return "Logged in";
            }
            else return "Logged off";
        }
        public string computersOn(bool open)
        {
            if (open == true)
            {
                return "On";
            }
            else return "Off";
        }
    }
}
