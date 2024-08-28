namespace Objects___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-one", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-one", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";

            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);


            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            //Calls the getType method on the computer object and prints to console
            Console.WriteLine(myComputer.GetType());
            //Calls the getType for the myBootUp method and prints to console
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);


            Console.WriteLine(myString.Contains('i'));

            //Calls ToUpper on the string variable 
            Console.WriteLine(myString.ToUpper());
        }
    }
}
