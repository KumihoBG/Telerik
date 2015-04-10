using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes
{
    internal class Gsm
    {
        /// <summary>
        /// A class for the mobile phone device - Problem 1
        /// </summary>

        #region Fields
        private string model;

        private string manufacturer;
        private decimal price;
        private string owner;
        // Adding a static field - Problem 6
        public static Gsm IPhone = new Gsm("IPhone4S", "Apple");

        // using List - Problem 9
        private List<Call> callHistory = new List<Call>();

        #endregion

        /// <summary>
        /// Properties
        /// </summary>

        #region Properties
        public Battery Battery { get; set; }

        public Display Display { get; set; }

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

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty.");
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be null or empty.");
                }

                this.owner = value;
            }
        }

        public Gsm IPhone4S
        {
            get { return IPhone; }
        }

        //  Create list of call history - Problem 9
        public List<Call> CallHistory
            {
            get { return callHistory; }
            set { this.callHistory = value; }
            }

        #endregion

        /// <summary>
        /// Constructs a mobile phone device with the given characteristics - Problem 2
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>

        #region Constructors

        // mandatory constructor
        public Gsm(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        // optional constructors
        public Gsm(string model, string manufacturer, decimal price)
            : this(manufacturer, model)
        {
            this.price = price;
        }

        public Gsm(string model, string manufacturer, int i, string owner)
            : this(manufacturer, model)
        {
            this.owner = owner;
        }

        public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.price = price;
            this.owner = owner;
            Battery = battery;
            Display = display;
        }

        #endregion

        /// <summary>
        /// Display method - Problem 4
        /// </summary>

        #region Display method

        // overriding
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("GSM Charasteristics:");
            result.AppendFormat("Model: {0}", model);
            result.AppendFormat("Manufacturer: {0}", manufacturer);
            result.AppendFormat("Price: {0}", price);
            result.AppendFormat("Owner: {0}", owner);
            return result.ToString();
        }

        #endregion

        /// <summary>
        /// Public methods - Problem 10 and 11
        /// </summary>

        #region Public methods - Problem 10 and 11

        // method to add calls in history - Problem 10
        public void AddCall(DateTime callDate, string calledNumber, int callDuration)
            {
            this.callHistory.Add(new Call(callDate, calledNumber, callDuration));
            }

        public void DeleteCalls(Call dialedNumber)
        {
            callHistory.Remove(callHistory.Find(x => x.dialedPhoneNumber.Contains(dialedNumber.dialedPhoneNumber)));
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void RemoveCall(Call callToRemove)
            {
            if (!this.callHistory.Contains(callToRemove))
                {
                throw new ArgumentException("Invalid call input.");
                }

            this.CallHistory.Remove(callToRemove);
            }

        // Problem 11
        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
        double spentMoney = 0.0;
        double entireDuration = 0.0;
        for (int i = 0; i < CallHistory.Count; i++)
            {
            entireDuration += CallHistory[i].Duration;
            }
        spentMoney += (entireDuration * (double) pricePerMinute);
        return (decimal) spentMoney;
        }

        #endregion

    }
}
