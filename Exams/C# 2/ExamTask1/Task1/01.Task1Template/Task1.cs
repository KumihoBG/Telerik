using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task1Template
    {
    class Task1
        {
        static void Main()
            {
            // the input
            string input = Console.ReadLine();
            string[] text = input.Split(' ');

            // finding the decimal
            int decNumber = 0;
            int j = 0;

            for (int i = text.Length; i >= 0; i--)
                {
                int index = 0;
                switch (input[i])
                    {
                    case 'a': index = 0;
                        break;
                    case 'b': index = 1;
                        break;
                    case 'c': index = 2;
                        break;
                    case 'd': index = 3;
                        break;
                    case 'e': index = 4;
                        break;
                    case 'f': index = 5;
                        break;
                    case 'g': index = 6;
                        break;
                    case 'h': index = 7;
                        break;
                    case 'i': index = 8;
                        break;
                    case 'j': index = 9;
                        break;
                    case 'k': index = 10;
                        break;
                    case 'l': index = 11;
                        break;
                    case 'm': index = 12;
                        break;
                    case 'n': index = 13;
                        break;
                    case 'o': index = 14;
                        break;
                    case 'p': index = 15;
                        break;
                    case 'q': index = 16;
                        break;
                    case 'r': index = 17;
                        break;
                    case 's': index = 18;
                        break;
                    case 't': index = 19;
                        break;
                    case 'u': index = 20;
                        break;
                    //default: index = int.Parse(input[i].ToString());
                    //    break;
                    }
                int newNumber = index * (int)Math.Pow(17, j);
                decNumber += newNumber;
                j++;
                }

            // finding 26 based from decimal
            StringBuilder list = new StringBuilder();
            for (int i = 0; i < text.Length - 1; i++)
                {
                do
                    {
                    if (decNumber % 26 < 9)
                        {
                        switch (decNumber % 26)
                            {
                            case 0:
                                list.Append("a");
                                break;
                            case 1:
                                list.Append("b");
                                break;
                            case 2:
                                list.Append("c");
                                break;
                            case 3:
                                list.Append("d");
                                break;
                            case 4:
                                list.Append("e");
                                break;
                            case 5:
                                list.Append("f");
                                break;
                            case 6:
                                list.Append("g");
                                break;
                            case 7:
                                list.Append("h");
                                break;
                            case 8:
                                list.Append("i");
                                break;
                            case 9:
                                list.Append("j");
                                break;
                            case 10:
                                list.Append("k");
                                break;
                            case 11:
                                list.Append("l");
                                break;
                            case 12:
                                list.Append("m");
                                break;
                            case 13:
                                list.Append("n");
                                break;
                            case 14:
                                list.Append("o");
                                break;
                            case 15:
                                list.Append("p");
                                break;
                            case 16:
                                list.Append("q");
                                break;
                            case 17:
                                list.Append("r");
                                break;
                            case 18:
                                list.Append("s");
                                break;
                            case 19:
                                list.Append("t");
                                break;
                            case 20:
                                list.Append("u");
                                break;
                            }
                        }

                    else if (decNumber % 26 > 9)
                        {
                        switch (decNumber % 26)
                            {
                            case 0:
                                list.Append("a");
                                break;
                            case 1:
                                list.Append("b");
                                break;
                            case 2:
                                list.Append("c");
                                break;
                            case 3:
                                list.Append("d");
                                break;
                            case 4:
                                list.Append("e");
                                break;
                            case 5:
                                list.Append("f");
                                break;
                            case 6:
                                list.Append("g");
                                break;
                            case 7:
                                list.Append("h");
                                break;
                            case 8:
                                list.Append("i");
                                break;
                            case 9:
                                list.Append("j");
                                break;
                            case 10:
                                list.Append("k");
                                break;
                            case 11:
                                list.Append("l");
                                break;
                            case 12:
                                list.Append("m");
                                break;
                            case 13:
                                list.Append("n");
                                break;
                            case 14:
                                list.Append("o");
                                break;
                            case 15:
                                list.Append("p");
                                break;
                            case 16:
                                list.Append("q");
                                break;
                            case 17:
                                list.Append("r");
                                break;
                            case 18:
                                list.Append("s");
                                break;
                            case 19:
                                list.Append("t");
                                break;
                            case 20:
                                list.Append("u");
                                break;
                            }
                        }
                    else
                        {
                        list.Append((decNumber % 26).ToString());
                        }
                    decNumber /= 26;
                    } while (decNumber != 0);
                }

            var result = list.ToString();
            var reversed = result.Reverse();
            string output = string.Join("", reversed);
            Console.WriteLine(output);

            }
        }
    }


