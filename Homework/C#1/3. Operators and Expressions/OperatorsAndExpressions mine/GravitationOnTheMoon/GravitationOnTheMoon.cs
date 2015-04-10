namespace GravitationOnTheMoon
{
    using System;
    class GravitationOnTheMoon
    {
        static void Main()
        {
            // Knowing the fact that the gravitational field of the Moon is approximately 17% of that on the Earth;
            // Write a program that calculates the weight of a man on the moon by a given weight on the Earth;

            Console.WriteLine("Please, enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = weight * 0.17;
            Console.WriteLine();
            Console.WriteLine(new string('*', 81));
            Console.WriteLine("Knowing the fact that the gravitational field of the Moon is approximately 17% of\nthat on the Earth, your weight on the Moon will be {0} kg", weightOnMoon);
        }
    }
}
