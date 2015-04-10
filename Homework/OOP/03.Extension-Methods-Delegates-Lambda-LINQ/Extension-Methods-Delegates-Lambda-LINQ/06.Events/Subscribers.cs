namespace _06.Events
    {
    using System;

    /// <summary>
    /// A class for the subscribers to the event
    /// </summary>
    public class Subscribers
        {
        /// <summary>
        /// Field of the class Subscribers
        /// </summary>
        private string id;

        /// <summary>
        /// Initializes a new instances of the <see cref="Subscribers"/> class.
        /// </summary>
        /// <param name="iD">string ID</param>
        /// <param name="publisher">Publisher parameter</param>
        public Subscribers(string iD, Publisher publisher)
            {
            this.id = iD;
            publisher.RaiseCustomEvent += this.HandleCustomEvent;
            }

        // Define what actions to take when the event is raised.
 
        /// <summary>
        /// A method to handle the custom event
        /// </summary>
        /// <param name="sender">some sender</param>
        /// <param name="e">custom event args parameter</param>
        public void HandleCustomEvent(object sender, CustomEventArgs e)
            {
            Console.WriteLine(id + " received this message: {0}", e.Message);
            }
        }
    }
