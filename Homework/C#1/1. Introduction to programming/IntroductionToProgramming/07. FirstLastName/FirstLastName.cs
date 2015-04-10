namespace FirstLastName
{
    using System;
    class FirstLastName
    {
        static void Main()
        {
            // This is simple application that prints your first and last name, using placeholders;
            string firstName = "Karolina";
            string lastName = "Dimitrova";
            Console.WriteLine("Your fisrt name is:" + " " + "{0}",firstName);
            Console.WriteLine("Your last name is:" + " " + "{0}",lastName);
        }
    }
}
