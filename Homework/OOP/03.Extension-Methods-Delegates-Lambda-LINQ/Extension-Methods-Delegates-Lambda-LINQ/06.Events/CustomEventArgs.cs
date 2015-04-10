namespace _06.Events
    {
    using System;

    // Define a class to hold custom event info 

    /// <summary>
    /// A class holding the custom event info
    /// </summary>
    public class CustomEventArgs : EventArgs
        {
        /// <summary>
        /// A field of the CustomEventArgs class
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventArgs"/> class.
        /// </summary>
        /// <param name="s">string message</param>
        public CustomEventArgs(string s)
            {
            this.message = s;
            }

        /// <summary>
        /// Gets or sets a property for the CustomEventArgs class
        /// </summary>
        public string Message
            {
            get
                {
                return this.message;
                }

            set
                {
                this.message = value;
                }
            }
        }
    }
