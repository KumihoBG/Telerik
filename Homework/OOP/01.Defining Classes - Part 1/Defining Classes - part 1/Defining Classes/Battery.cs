using System;

namespace Defining_Classes
    {
    public class Battery
        {
        /// <summary>
        /// A class for the battery - Problem 1
        /// Fields of the Battery class
        /// </summary>

        #region Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        #endregion
        
        /// <summary>
        /// Properties of the Battery class
        /// </summary>
        #region Properties

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (hoursIdle < 0)
                {
                    throw new ArgumentException("Idle hours cannot be less than 0.");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (hoursTalk < 0)
                {
                    throw new ArgumentException("Talk hours cannot be less than 0.");
                }
                this.hoursTalk = value;
            }
        }

        #endregion

        }
    }
