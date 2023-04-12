using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_1250Review
{
    public class Person
    {
        //3 main components of an object class: attributes, constructors, methods

        //Attributes - data that belongs to and describes an object of the class
        public string Name { get; set; } //property - shortcut: prop <tab> <tab>

        //expanded property - used if you need more than the default get/set - shortcut: propfull <tab> <tab>
        private int _age;
        public int Age 
        { 
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0 || value >= 125)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        /*
        
        //Old way with private attribute and get and set methods; properties achieve this in a more concise way

        private string Name;

        public int GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        private int Age;

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            if(age <= 0 || age >= 125)
            {
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }
        */

        //Constructors - set up the starting values for a new object's attribtutes
        public Person() //default constructor: sets attributes to default values
        {
            Name = "";
            Age = 0;
        }

        public Person(string name, int age) //parameterized constructor: sets attributes to passed in values
        {
            Name = name;
            Age = age;
        }

        public Person(Person other) //copy constructor: sets attributes to values of another, existing object of the class that is passed in
        {
            Name = other.Name;
            Age = other.Age;
        }

        //Methods
        public void HaveBirthday() //instance (normal) method: operates on a specific object of the class, e.g., person1.HaveBirthday();
        {
            Age++;
            //Age += 1;
            //Age = Age + 1;
        }

        public static void Announcement() //static method: only one copy for the entire class, operates for the class in general rather than one specific object, e.g., Person.Announcement();
        {
            Console.WriteLine("Have a good day!");
        }

        public override string ToString() //ToString: formats the object in an easy-to-read manner; called automatically when printing to the console
        {
            string info = "";

            info += $"\n------------------------------";
            info += $"\nName: {Name}";
            info += $"\nAge:  {Age}";
            info += $"\n------------------------------";

            return info;
        }
    }
}
