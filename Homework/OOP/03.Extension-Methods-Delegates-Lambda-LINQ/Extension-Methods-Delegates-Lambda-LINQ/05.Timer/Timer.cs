namespace _05.Timer
    {
    using System;
    using System.Threading;

    /// <summary>
    /// Public class Timer
    /// </summary>
    public class Timer
        {
        /// <summary>
        /// Field of the Timer class
        /// </summary>
        private int timeInterval;

        /// <summary>
        /// Initializes a new instance of the <see cref="Timer"/> class.
        /// </summary>
        /// <param name="seconds">integer type seconds</param>
        public Timer(int seconds)
            {
            this.TimeInterval = seconds;
            }

        /// <summary>
        /// Timer delegate
        /// </summary>
        public delegate void TimerDelegates();

        /// <summary>
        /// Gets a property for the Timer class
        /// </summary>
        public int TimeInterval
            {
            get
                {
                return this.timeInterval;
                }

            private set
                {
                if (value < 1)
                    {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                    }

                this.timeInterval = value;
                }
            }

        /// <summary>
        /// Gets or sets a property for the Timer class
        /// </summary>
        public TimerDelegates TestingMethods { get; set; }

        /// <summary>
        /// Method for executing the testing methods
        /// </summary>
        public void ExecuteMethods()
            {
            int count = 0;
            while (true)
                {
                this.TestingMethods();
                Thread.Sleep(this.timeInterval * 500);
                }
            }
        }
    }
