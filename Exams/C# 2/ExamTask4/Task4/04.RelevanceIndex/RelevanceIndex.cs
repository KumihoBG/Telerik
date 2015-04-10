using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RelevanceIndex
    {
    class RelevanceIndex
        {
        static void Main()
            {
            string[] separators = { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

            // first input
            string searchWord = Console.ReadLine().ToLower();

            // second input
            int lines = int.Parse(Console.ReadLine());

            // On each of the next L lines there will be a single string – the text in the respective paragraph.
            string[] paragraphs = new string[lines];
            for (int i = 0; i < lines; i++)
                {
                paragraphs[i] = Console.ReadLine(); 
                }

            int[] relevances = new int[lines];
            string[] editedParagraphs = new string[lines];

            for (int paragraphInd = 0; paragraphInd < lines; paragraphInd++)
                {
                string[] paragraphWords = paragraphs[paragraphInd].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int currentRelevance = 0;
                for (int wordInd = 0; wordInd < paragraphWords.Length; wordInd++)
                    {
                    if (paragraphWords[wordInd].ToLower() == searchWord)
                        {
                        currentRelevance++;
                        // words matching the search word converted to uppercase.
                        paragraphWords[wordInd] = paragraphWords[wordInd].ToUpper();
                        }
                    }
                // each two words separated by a single space 
                relevances[paragraphInd] = currentRelevance;
                editedParagraphs[paragraphInd] = String.Join(" ", paragraphWords);
                }

            List<string> paragraphsByRelevance = new List<string>();

            while (paragraphsByRelevance.Count < editedParagraphs.Length)
                {
                int maxRelevance = 0;
                int maxRelevanceIndex = 0;
                for (int i = 0; i < relevances.Length; i++)
                    {
                    int currentRelevance = relevances[i];
                    if (maxRelevance < currentRelevance)
                        {
                        maxRelevanceIndex = i;
                        maxRelevance = currentRelevance;
                        }
                    }

                paragraphsByRelevance.Add(editedParagraphs[maxRelevanceIndex]);
                relevances[maxRelevanceIndex] = 0;
                }

            Console.WriteLine(String.Join(Environment.NewLine, paragraphsByRelevance));
            }
        }
    }

