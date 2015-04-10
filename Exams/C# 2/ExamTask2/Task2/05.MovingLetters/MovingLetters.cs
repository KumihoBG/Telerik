using System;
using System.Text;

namespace _17.MovingLetters
    {
    class MovingLetters
        {
        static void Main()
            {

            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);

            // викаме методите от долу
            StringBuilder strangeLetters = ExtractLetter(words);
            string finalResult = MoveLetters(strangeLetters);
            Console.WriteLine(finalResult);
            }

        // метод за премахване на последния елемент на всяка дума в масива и долепяне в стрингбилдер
        static StringBuilder ExtractLetter(string[] words)
            {
            StringBuilder result = new StringBuilder();
            // finding the longest word in the array
            int maxWordLenght = 0;
            for (int i = 0; i < words.Length; i++)
                {
                string currentWord = words[i]; // associating the current word with the index i
                if (maxWordLenght < currentWord.Length)
                    {
                    maxWordLenght = currentWord.Length; // намерихме на-дългата дума
                    }
                }
            // finding the max lenght of the longest word
            for (int i = 0; i < maxWordLenght; i++)
                {
                for (int j = 0; j < words.Length; j++)
                    {
                    string currentWord = words[j];
                    if (i < currentWord.Length)
                        {
                        int lastLetter = currentWord.Length - 1 - i; //последната буква
                        result.Append(currentWord[lastLetter]); //добавяме в стрингбилдера
                        }
                    }
                }
            return result;
            }
        // метод за преместване на буквите
        static string MoveLetters(StringBuilder strangeLetters)
            {
            for (int i = 0; i < strangeLetters.Length; i++) //for цикъл по дължината на странните букви
                {
                char currentSymbol = strangeLetters[i]; // първият чар от поредицата
                int transition = char.ToLower(currentSymbol) - 'a' + 1; // взимаме с колко пъти ще го местим
                int nextPosition = (i + transition) % (strangeLetters.Length); //намерена следваща позиция
                strangeLetters.Remove(i, 1); //махаме от стрингбилдера първият елемент, който ще си смени мястото
                strangeLetters.Insert(nextPosition, currentSymbol);//вмъкваме го на желаната позиция
                }
            return strangeLetters.ToString();
            }
        }
    }
