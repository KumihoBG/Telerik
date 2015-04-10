using System;

namespace _06.JoroTheRabbit
    {
    class JoroTheRabbit
        {
        static void Main()
            {
            // the input
            int[] numbers;
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            numbers = new int[inputNumbers.Length];
            for (int i = 0; i < inputNumbers.Length; i++)
                {
                numbers[i] = int.Parse(inputNumbers[i]);
                }

            // the logic
            int bestPath = 0;

            // обхождаме с вложени цикли
            for (int startIndex = 0; startIndex < numbers.Length; startIndex++) //начална позиция до края на
                {                                                               //масива
                for (int step = 1; step < numbers.Length; step++) //начална стъпка до края на масива
                    {
                    int index = startIndex;
                    int currentPath = 1;
                    int next = index + step;
                    if (next >= numbers.Length)
                        {
                        next = next - numbers.Length; // може да се използва (индекс + next) % дължината, отново същият метод за намиране на следваща позиция! За да няма OutOfRangeException. Но тук го пропускаме, за да направим програмата по-бърза
                        }


                    while (numbers[index] < numbers[next]) //докато индексът е по-малък от следващата стъпка
                        {
                        currentPath++; //увеличаваме пътя на заека
                        index = next; // индексът става следваща стъпка
                        next = (index + step) % numbers.Length; //използваме алгоритъма отново
                        }
                    if (bestPath < currentPath) //ако по-дългия път е по-малък от настоящия
                        {
                        bestPath = currentPath; //по-дългия става настоящия
                        }
                    }
                }
            Console.WriteLine(bestPath);
            }
        }
    }


