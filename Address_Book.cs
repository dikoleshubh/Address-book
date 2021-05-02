using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adress_Book
{
    class Address_Book
    {
        public static List<Person> People = new List<Person>();//List declarartion to enlsit details
        string fname;
        public class Person// person profile
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Addresses { get; set; }
            public string Email_Addresses { get; set; }
        }
        public static void AddPerson() /// Taking person details
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address : ");
           
            person.Addresses = Console.ReadLine();

            Console.Write("Enter  Email Address : ");
            person.Email_Addresses = Console.ReadLine();
            

            People.Add(person);
        }

    }
    
}
