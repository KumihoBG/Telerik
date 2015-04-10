namespace DivideBySevenAndFive
{
    using System;
    class DivideBySevenAndFive
    {
        static void Main()
        {
            // Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time;
            Console.WriteLine("Write a number to check whether it can be devided by 5 and by 7 at the same time:");
            double number = double.Parse(Console.ReadLine());
            bool isDevided = number%5 == 0 && number%7 == 0;
            Console.WriteLine(isDevided);
        }
    }
}
