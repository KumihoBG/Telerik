// Using delegates write a class Timer that can execute certain method at each t seconds

namespace _05.Timer
    {
    using System;

    /// <summary>
    /// Class for testing the timer
    /// </summary>
    public class DelegatesTimer
        {
        /// <summary>
        /// The main method
        /// </summary>
        public static void Main()
            {
            Timer timer = new Timer(5);
            
            timer.TestingMethods += FirstTestMethod;
            timer.TestingMethods += SecondTestMethod;
            timer.ExecuteMethods();
            }

        /// <summary>
        /// The first method to be tested
        /// </summary>
        public static void FirstTestMethod()
            {
            Console.WriteLine("The first method executes now.");
            }

        /// <summary>
        /// The second method to be tested
        /// </summary>
        public static void SecondTestMethod()
            {
            Console.WriteLine("The second method executes now.");
            }
        }
    }
