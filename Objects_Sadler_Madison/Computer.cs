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
    // Creates a class called Computer and implements interface IBootUp
    internal class Computer : IBootUp
    {
        // Declares a public bool called IsOn with an automatic getter and setter
        public bool IsOn { get; set; }
        // Declares a public string called Brand with an automatic getter and setter
        public string Brand { get; set; }
        // Declares a public string called Type with an automatic getter and setter
        public string Type { get; set; }

        // Creates a public constructor that takes parameters: bool isOn, string brand, and string type
        // Sets IsOn to isOn, Brand to brand, and Type to type
        public Computer(bool isOn, string brand, string type)
        {
            IsOn = isOn;
            Brand = brand;
            Type = type;
        }

        // Defines a public void method called PowerOnOff()
        // Sets IsOn to its current opposite value
        // Creates an if else statement that states if IsOn is true then the phrase "The computer is booting up!" will be printed to the console, otherwise it would print to the console "The computer is shutting down!"
        public void PowerOnOff()
        {
            IsOn = !IsOn;
            if (IsOn == true) 
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            { 
                Console.WriteLine("The computer is shutting down!"); 
            }
        }

        // Creates a public override string function called ToString()
        // Returns "This computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}."
        public override string ToString()
        {
            return $"This computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}.";
        }
    }
}
