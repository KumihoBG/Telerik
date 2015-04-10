using System;
using System.Globalization;
using System.Threading;

namespace Defining_Classes
    {
    class Program
        {
        static void Main()
            {
            const decimal callPricePerMinute = 0.37m;

            Gsm myPhone = new Gsm("A390", "Lenovo", 75, "Mirela");

            myPhone.AddCall(DateTime.Now.AddDays(-130), "+359 (88) 222 4445", 100);
            myPhone.AddCall(DateTime.Now, "+359 (88) 853 5280", 60);
            myPhone.AddCall(DateTime.Now.AddDays(56), "+359 (87) 345 6784", 60);
            myPhone.AddCall(DateTime.Now.AddDays(34), "+359 (2) 654 2221", 34);

            PrintCallHistory(myPhone);

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal callsPrice = myPhone.CalculateTotalPrice(callPricePerMinute);
            Console.WriteLine();
            Console.WriteLine("Total calls price {0:C2}\n", callsPrice);

            RemoveLongestCall(myPhone);
            Console.WriteLine("Longest call removed.");
            callsPrice = myPhone.CalculateTotalPrice(callPricePerMinute);
            Console.WriteLine("Total calls price now is {0:C2}\n", callsPrice);
            Console.WriteLine("History will be cleaned... No history found.");
            myPhone.ClearCallHistory();

            PrintCallHistory(myPhone);
            }

        private static void PrintCallHistory(Gsm myPhone)
            {
            Console.WriteLine("Calls list for {0}\n", myPhone.Owner);
            Console.WriteLine("{0,-12}{1,-10}{2,-20}{3}", "Date:", "Time:", "Called number:", "Duration [s]:");
            foreach (var call in myPhone.CallHistory)
                {
                DateTime callDate = call.DateOfCall;
                string calledNumber = call.DialedNumber;
                int callDuration = (int)call.Duration;

                Console.WriteLine("{0,-12:dd.MM.yyyy}{0,-10:HH:mm:ss}{1,-20}{2,13:D0}", callDate, calledNumber, callDuration);
                }
            }

        private static void RemoveLongestCall(Gsm myPhone)
            {
            int longestDuration = int.MinValue;
            Call longestCall = null;

            foreach (Call call in myPhone.CallHistory)
                {
                if (call.Duration > longestDuration)
                    {
                    longestDuration = (int)call.Duration;
                    longestCall = call;
                    }
                }

            myPhone.RemoveCall(longestCall);
            }
        }
    }
