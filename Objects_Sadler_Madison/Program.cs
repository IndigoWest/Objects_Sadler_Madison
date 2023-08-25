// See https://aka.ms/new-console-template for more information
// My collection of classes for this project needed to use Console class
using Objects_Sadler_Madison;

// Creates a new Computer object called myComputer and assigns isOn to true, brand to HP, and type to Envy
Computer myComputer = new Computer(true, "HP", "Envy");
// Creates an IBootUp object called myBootUp and assigns to myComputer
IBootUp myBootUp = myComputer;
// Prints to the console the results of the comparison between myComputer and myBootUp
Console.WriteLine(myComputer.Equals(myBootUp));

// Creates another new Computer object called myOtherComputer and assigns isOn to true, brand to Hp, and type to Envy
Computer myOtherComputer = new Computer(true, "HP", "Envy");
// Prints to console the results of the comparison between myComputer and myOtherComputer
Console.WriteLine(myComputer.Equals(myOtherComputer));

// Creates a new string variable called myString and gives it the value of myComputer's ToString method
string myString = myComputer.ToString();
// Creates another new string variable called myOtherString and gives it the value of myString
string myOtherString = myString;

// Sets myString to "Hi!"
myString = "Hi!";

// Prints to console what the value(s) of myString are
Console.WriteLine(myString);
// Prints to console what the value(s) of myOtherString are
Console.WriteLine(myOtherString);

// Prints to the console the results of the comparison between myString and myComputer.ToString()
Console.WriteLine(myString == myComputer.ToString());
// Prints to the console the results of the comparison between myString and myOtherComputer.ToString()
Console.WriteLine(myString == myOtherComputer.ToString());

// Prints to the console the results of calling the GetType method on myComputer
Console.WriteLine(myComputer.GetType());
// Prints to the console the results of calling the GetType method on myBootUp
Console.WriteLine(myBootUp.GetType());

// Calls the PowerOnOff method on myOtherComputer
myOtherComputer.PowerOnOff();

// Prints to the console the results of the comparison between myString and myOtherComputer.ToString()
Console.WriteLine(myString == myOtherComputer.ToString());
// Prints to the console what the value(s) of myString are
Console.WriteLine(myString);
// Prints to the console what the value(s) of myOtherComputer.ToString() are
Console.WriteLine(myOtherComputer.ToString());

// Prints to the console the results of myString.Contains('i')
Console.WriteLine(myString.Contains('i'));
// Prints to the console the results of calling myString ToUpper
Console.WriteLine(myString.ToUpper());
