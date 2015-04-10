// Read in MSDN about the keyword event in C# and how to publish events.
// Re-implement the above using .NET events and following the best practices.

namespace _06.Events
    {
    using System;

    /// <summary>
    /// A sample event test
    /// </summary>
    public class EventsTest
        {
        /// <summary>
        /// The main method
        /// </summary>
        public static void Main()
            {
            Publisher publisher = new Publisher();
            Subscribers sub1 = new Subscribers("First subscriber", publisher);
            Subscribers sub2 = new Subscribers("Second subscriber", publisher);

            // Call the method that raises the event.
            publisher.RaiseEvent();
            Console.WriteLine();
            }
        }
    }
