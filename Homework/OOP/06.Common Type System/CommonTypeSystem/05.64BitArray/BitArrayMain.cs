/*
    Define a class BitArray64 to hold 64 bit values inside an ulong value.
    Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
namespace _05._64BitArray
    {
    using System;

    public class BitArrayMain
        {
        public static void Main()
            {
            var firstTestNumber = new BitArray64(254);

            // number as array of bits:
            Console.WriteLine("The number as array of bits: ");
            Console.WriteLine(new string('*', 28));
            Console.WriteLine(string.Join("", firstTestNumber.BitArray));
            Console.WriteLine();

            // check indexer
            Console.WriteLine("Checking values at a specified index: ");
            Console.WriteLine(new string('*', 37));
            Console.WriteLine(firstTestNumber[62]);
            Console.WriteLine(firstTestNumber[3]);
            Console.WriteLine();

            // check enumerator
            Console.WriteLine("Checking enumerator: ");
            Console.WriteLine(new string('*', 20));
            foreach (var bit in firstTestNumber)
                {
                Console.Write(bit);
                }
            Console.WriteLine();
            Console.WriteLine();

            //check equals and ==
            Console.WriteLine("Checking overrided operators and methods: ");
            Console.WriteLine(new string('*', 41));
            var secondTestNumber = new BitArray64(254);
            var thirdTestNumber = new BitArray64(122);

            Console.WriteLine(firstTestNumber.Equals(secondTestNumber));
            Console.WriteLine(firstTestNumber.Equals("11111110"));
            Console.WriteLine(firstTestNumber.Equals(thirdTestNumber));
            Console.WriteLine(firstTestNumber == secondTestNumber);
            Console.WriteLine(firstTestNumber != thirdTestNumber);
            Console.WriteLine();
            }
        }
    }
