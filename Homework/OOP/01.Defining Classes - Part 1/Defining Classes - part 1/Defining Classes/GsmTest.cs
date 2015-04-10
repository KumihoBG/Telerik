using System;

namespace Defining_Classes
    {
    class GsmTest
        {
        /// <summary>
        /// Writing a class GSMTest to test the GSM class - Problem 7
        /// </summary>
        /// <param name="numberOfTest"></param>
        public static void TestClassGsm(int numberOfTest)
            {
            Gsm[] mobilePhones = new Gsm[numberOfTest];

            for (int i = 0; i < numberOfTest; i++)
                {
                mobilePhones[i] = new Gsm("Model " + (i + 1), "Manufacturer " + (i + 1), (i + 1) * 100, "Owner " + (i + 1));
                Console.WriteLine(mobilePhones[i]);
                }
            Console.WriteLine(Gsm.IPhone);
            }
        }
    }
