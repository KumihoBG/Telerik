using System;

namespace Defining_Classes
    {
    class Call
        {
        /// <summary>
        /// Create a class Call - Problem 8
        /// Fields of the class Call
        /// </summary>
        #region Fields

        private DateTime dateAndTime;
        public string dialedPhoneNumber;
        private long duration;

        #endregion

        /// <summary>
        /// Constructs a phone call
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="dateAndTime"></param>
        /// <param name="dialedPhoneNumber"></param>
        /// <param name="duration"></param>

        #region Constructor
        public Call(DateTime dateAndTime, string dialedPhoneNumber, decimal duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = (long) duration;
        }

        #endregion

        /// <summary>
        /// Properties of the class Call
        /// </summary>
        #region Properties

        public DateTime DateOfCall
        {
            get { return this.dateAndTime; }
        }

        public DateTime TimeOfCall
        {
            get { return this.dateAndTime; }
        }

        public string DialedNumber
        {
            get { return this.dialedPhoneNumber; }
        }

        public long Duration
        {
            get { return this.duration; }
        }
        }

        #endregion

    }
