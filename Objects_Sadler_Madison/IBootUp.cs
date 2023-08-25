// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Linq namespace needed to use Console class
using System.Linq;
// System.Text namespace needed to use Console class
using System.Text;
// System.Threading.Tasks namespace needed to use Console class
using System.Threading.Tasks;

// My collection of classes for this project
namespace Objects_Sadler_Madison
{
    // Creates an interface called IBootUp
    internal interface IBootUp
    {
        // Declares a public bool called IsOn with an automatic getter and setter
        public bool IsOn { get; set; }
        // Declares a public void method called PowerOnOff()
        public void PowerOnOff();
    }
}
