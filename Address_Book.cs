﻿using System;
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

        public  static void EditRecord(String fname)
        {
            //For loop for Value  present or not
            for (int k = 0; k < People.Count; k++)
            {
                if (People[k].FirstName.Equals(fname))
                {
                    //Calling List
                    Person person = People[k];
                    //Print person
                    Console.WriteLine(person);
                    // k==0 to editRecord contact
                    while (k == 0)
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. Addresss"
                                + "2. Phone"
                                + "3. Email"
                                + "4. Save And Exit");
                        //convert string and store choice
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)  //case 
                        {
                            case 1:
                                //Take input user
                                Console.Write("Enter new City:- ");
                                
                                String Address = Console.ReadLine();
                                //store class of person Address data
                                person.Addresses = Address;
                                break;
                            case 2:
                                Console.Write("Enter new Phone:- ");
                                //storing city variable
                                String phone = Console.ReadLine();
                                //store class of person phone data
                                person.PhoneNumber = phone;
                                break;
                            case 3:
                                
                                Console.Write("Enter new Email:- ");
                                //store email variable
                                String email = Console.ReadLine();
                                //store class of person Email data
                                person.Email_Addresses = email;
                                break;
                            case 4:
                                k = 1;
                                break;
                           
                                
                            
                                
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        //For person Details
                        foreach (person t in People)
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                } //end of edit() method
            }
        }
        static public void displayPerson()
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in People)
            {
                Console.WriteLine("FirstName: {0}\t LastName: {1}\t city: {2}\t state: {3}\t email: {4}\t phoneNumber: {5}", person.FirstName, person.LastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }
        public static void remove()
        {// Enter the name of person to remove
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null) //Checking for it's existence
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                PrintPeople(person);//Confirmation

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    People.Remove(person);
                    Console.WriteLine("Person removed. Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
    
}
