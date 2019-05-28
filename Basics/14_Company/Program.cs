using System;

namespace _14_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            //14. A given company has name, address, phone number, fax number, web site and manager.
            //The manager has name, surname and phone number.
            //Write a program that reads information about the company and its manager and
            //then prints it on the console.

            Console.Write("Company's name: ");
            string cName = Console.ReadLine();
            Console.Write("Company's address: ");
            string cAddress = Console.ReadLine();
            Console.Write("Company's phone number: ");
            string cPhone = Console.ReadLine();
            Console.Write("Company's fax number: ");
            string cFax = Console.ReadLine();
            Console.Write("Company's website: ");
            string cWebsite = Console.ReadLine();

            Console.Write("Manager's name: ");
            string mName = Console.ReadLine();
            Console.Write("Manager's surname: ");
            string mSurname = Console.ReadLine();
            Console.Write("Manager's phone: ");
            string mPhone = Console.ReadLine();

            string cManager = mName + " " + mSurname;

            Console.WriteLine($"Information about the company: \n Name: {cName} \n Address: {cAddress} \n Phone: {cPhone} \n Fax: {cFax} \n Web site: {cWebsite} \n Manager: {cManager}");

            Console.WriteLine($"Information about the manager: \n Name: {mName} \n Surname: {mSurname} \n Phone: {mPhone}");



        }
    }
}
