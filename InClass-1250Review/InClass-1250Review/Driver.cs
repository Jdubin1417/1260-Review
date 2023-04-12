using System;

namespace InClass_1250Review
{
    public class Driver
    {
        public static void Main() //main method: entry point for the program
        {
            //Using the Tools class
            Console.WriteLine("my message");
            Tools.PressAnyKey("Press any key to continue");
            Tools.ClearConsole();
            Console.WriteLine("more information");
            Tools.PressAnyKey("Press any key to continue");

            //////

            //Instantiating Person objects using constructors
            Person defaultPerson = new Person();
            Person bob = new Person("Bob", 43);
            Person steve = new Person(bob);
            Person billy = new Person("Billy", bob.Age);

            steve.Name = "Steve"; //Modifying using property set

            Console.WriteLine(defaultPerson.ToString()); //don't need to call ToString, it is automatically called when printing an object, but you can if it helps with readability
            Console.WriteLine(bob);
            Console.WriteLine(steve);
            Console.WriteLine(billy);

            bob.Age = 42;

            Console.WriteLine("Bob after changing his age:");
            Console.WriteLine(bob);

            Console.WriteLine("It's Bob's birthday!!!!!!!!");
            bob.HaveBirthday();
            Console.WriteLine(bob);

            Person.Announcement();

            ///////////////
            
            //if
            if(bob.Age > 100)
            {
                Console.WriteLine("You're getting kind of old...");
            }
            else if(bob.Age >= 18)
            {
                Console.WriteLine("You're an adult now");
            }
            else
            {
                Console.WriteLine("You're a kid");
            }

            //switch
            switch(bob.Age)
            {
                case 100:
                    Console.WriteLine("You're getting old");
                    break;
                case 18:
                    Console.WriteLine("You're officially an adult");
                    break;
                default:
                    Console.WriteLine("You aren't at an important milestone");
                    break;
            }

            //for
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //while
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //do while
            string userInput;
            do
            {
                Console.WriteLine("Please enter the letter 'A':");
                userInput = Console.ReadLine();
            }
            while (userInput != "A");

            //integer division
            int num1 = 11;
            int num2 = 2;
            Console.WriteLine(11 / 2);
            Console.WriteLine(11 / 2.0);
            Console.WriteLine(11.0 / 2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine((double)num1 / num2);
        }
    }
}
