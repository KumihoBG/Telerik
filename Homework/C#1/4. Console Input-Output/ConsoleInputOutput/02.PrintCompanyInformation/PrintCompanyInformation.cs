using System.Security.Claims;

namespace PrintCompanyInformation
{
    using System;
    class PrintCompanyInformation
    {
        static void Main()
        {
            // A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number;
            // Write a program that reads the information about a company and its manager and prints it back on the console;
            Console.Write("Please, enter company name: ");
            string company = Console.ReadLine();
            Console.Write("Please, enter company's address: ");
            string address = Console.ReadLine();
            Console.Write("Now, enter company's phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter company's fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter company's website: ");
            string website = Console.ReadLine();
            Console.Write("Enter the first name of the company's manager: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name of the company's manager: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the age of the Manager: ");
            string age = Console.ReadLine();
            Console.Write("Enter the mobile number of the Manager: ");
            string mobile = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(new string('*', 49));
            Console.WriteLine("{0}", company);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", phone);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", website);
            Console.WriteLine("Manager {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, mobile);
        }
    }
}
