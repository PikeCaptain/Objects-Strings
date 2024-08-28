using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects___Strings
{
    internal interface IBootUp
    {
        //Adds a boolean property to the IsOn with automatic getter and setter
        public bool IsOn { get; set; }

        //Declares the method called PowerOnOff in the interface
        public void PowerOnOff();
    }
}
