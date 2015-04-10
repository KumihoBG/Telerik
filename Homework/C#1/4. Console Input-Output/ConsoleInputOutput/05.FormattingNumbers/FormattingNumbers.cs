namespace FormattingNumbers
{
    using System;
    using System.Threading;
    using System.Globalization;
    class FormattingNumbers
    {
        static void Main()
        {
            // With this program we are going to format and print 3 numbers (int, float, float) and also create 4 virtual columns on the console with specific wide of 10 chars.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter an integer number (0 <= a <= 500): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Now, enter the first floating-point number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the second floating-point number: ");
            double c = double.Parse(Console.ReadLine());
            if (0 <= a && a <= 500)
            {
                Console.WriteLine("{0,-10:X}" + "|" + "{1}" + "|" + "{2,10:N2}" + "|" + "{3,-10:F3}" + "|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c); 
            }
            else
            {
                Console.WriteLine("This number is not correct!");
            }      
        }
    }
}
