using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.ConsoleJustification
    {
    internal class ConsoleJustification
        {

        private static void Main()
            {
            // the input
            int lines = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            var result = new List<string>();
            var text = new StringBuilder(); // създаваме стринг билдър
            for (int i = 0; i < lines; i++) //вкарваме текста ред по ред с итерация до броя на редовете
                {
                text.AppendFormat("{0} ", Console.ReadLine());
                }

            //после разделяме получения общ текст на отделни думи, които пазим в нов масив
            string[] words = text.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            AddWordsToList(width, ref result, ref words);

            AddSpacesBetweenWords(width, ref result);

            Console.WriteLine(string.Join(Environment.NewLine, result));
            }

        //метод за добавяне на пространство между думите
        private static void AddSpacesBetweenWords(int width, ref List<string> result)
            {
            for (int i = 0; i < result.Count; i++) //нова итерация до броя на редовете
                {
                int space = 1, index = 0;
                while (result[i].Length < width && index != -1)
                    {
                    index = result[i].IndexOf(new string(' ', space), StringComparison.Ordinal);
                    while (index != -1 && result[i].Length < width && index != result[i].Length - 1)
                        {
                        result[i] = result[i].Insert(index, " "); //вмъкваме спейс
                        index = result[i].IndexOf(new string(' ', space), index + space + 1, StringComparison.Ordinal);
                        }
                    space++;
                    index = result[i].IndexOf(new string(' ', space), StringComparison.Ordinal);
                    }
                }
            }

        // метод за форматиране на текста
        private static void AddWordsToList(int letterLimit, ref List<string> result, ref string[] words)
            {
            var text = new StringBuilder(); //създаваме нов стрингбилдер
            for (int i = 0; i < words.Length; i++) // итерация до броя на намерените думи
                {
                text.Append(words[i]); // добавяме ги в билдера
                if (text.Length + (i + 1 < words.Length ? words[i + 1].Length : 0) >= letterLimit)
                    { //ако новата дължина е по-голяма или равна на общата дължина (тоест я достигне)
                    result.Add(text.ToString());//добавяме текущите думи в реда
                    text = text.Clear();// и изчистваме реда, за да започнем новия ред
                    }
                else
                    {
                    text.Append(" "); // иначе, ги добавяме на всяка итерация заедно със спейс
                    }
                }

            result.Add(text.ToString().Trim()); //зачистваме крайния резултат
            }
        }
    }
