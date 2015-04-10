namespace _06.Events
    {
    using System;
    using System.Globalization;

    // Class that publishes an event 

    /// <summary>
    /// A class Publisher
    /// </summary>
    public class Publisher
        {
        // Declare the event using EventHandler<T> 

        /// <summary>
        /// Event Handler
        /// </summary>
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        /// <summary>
        /// Method to raise an event
        /// </summary>
        public void RaiseEvent()
            {
            Console.WriteLine("Need to learn how to raise events!");
            Console.WriteLine();
            this.OnRaiseCustomEvent(new CustomEventArgs("Event raised"));
            }

        /// <summary>
        /// Protected method
        /// </summary>
        /// <param name="e">a parameter from the CustomEventArgs class</param>
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
            {
            // Make a temporary copy of the event to avoid possibility of 
            // a race condition if the last subscriber unsubscribes 
            // immediately after the null check and before the event is raised.
            EventHandler<CustomEventArgs> handler = this.RaiseCustomEvent;

            // Event will be null if there are no subscribers 
            if (handler != null)
                {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += string.Format(" at {0}\n", DateTime.Now.ToString(CultureInfo.InvariantCulture));

                // Use the () operator to raise the event.
                handler(this, e);
                }
            }
        }
    }
