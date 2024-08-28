using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects___Strings
{
    class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        public void PowerOnOff()
        {
            IsOn = IsOn;

            if (IsOn == true)
            {
                //Prints this line when the IsOn is equal to true
                Console.WriteLine("The computer is booting up!");
            }
            else 
            {
                //Shows this line when the IsOn is equal to false
                Console.WriteLine("The computer is shutting down!");
            }
        }
        public override string ToString() 
        {
            //Returns the statement and tells if the computer is on and tells the brand and type
            return $"The computer is made by {Brand} and is a {Type} computer, it is on: {IsOn}!";
        }

    }
}
