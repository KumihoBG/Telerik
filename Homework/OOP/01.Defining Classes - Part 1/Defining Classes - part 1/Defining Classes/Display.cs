using System;

namespace Defining_Classes
    {
    public class Display
        {
        /// <summary>
        /// A class for the display characteristics - Problem 1
        /// Fields of the Display class
        /// </summary>
        private double size;
        private int numberOfColors;

        /// <summary>
        /// Properties of the Display class
        /// </summary>
        #region Properties

        public double Size
        {
            get { return size; }
            set
            {
                if (size < 0)
                {
                    throw new IndexOutOfRangeException("The size cannot be less than 0.");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (numberOfColors < 0)
                {
                    throw new IndexOutOfRangeException("The number of colors cannot be less than 0.");
                }
                this.numberOfColors = value;
            }
        }

        #endregion

        }
    }
