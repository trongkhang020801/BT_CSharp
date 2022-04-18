using System;
using System.Collections;
using System.Collections.Generic;

namespace Human_Resource_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagarOfficer managarOfficer = new ManagarOfficer();
            int a = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("Application Manager Officers");
                Console.WriteLine("Enter 1: To insert to offices");
                Console.WriteLine("Enter 2: To search officers by name");
                Console.WriteLine("Enter 3: To show information officers");
                Console.WriteLine("Enter 4: To Exit.")
            }    
        }
    }

    class Officer
    {
        private string name;
        private int age;    
        private string gender;
        private string address;

        protected string Name { get => name; set => name = value; }
        protected int Age { get => age; set => age = value; }
        protected string Gender { get => gender; set => gender = value; }
        protected string Address { get => address; set => address = value; }

        public Officer (string name, int age, string gender, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }
    }

    class ManagarOfficer: ArrayList
    {
        private ArrayList officers;

        public ManagarOfficer()
        {
            this.officers = new ArrayList();
        }

        public void addOfficer(Officer officer)
        {
            this.officers.Add(officer);
        }
        

        
    }
}
