using System;
using System.Text;

/*Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first*/

namespace _07.EncodeDecode
    {
    class EncodeDecode
        {
        static void Main()
            {
            // the input
            Console.Write("Enter some string: ");
            string str = Console.ReadLine();

            // the key
            Console.Write("Enter the key sequence of random characters to encrypt the string: ");
            string key = Console.ReadLine();

            // calling our methods from below and printing
            Console.WriteLine("Encrypted string: {0}", Encrypt(str, key));
            Console.WriteLine("Decrypted string: {0}", Decrypt(Encrypt(str, key), key));
            }

        // declaring the Encrypting method
        static string Encrypt(string str, string key)
            {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                cipher.Append((char)(str[i] ^ key[i % key.Length]));  // using XOR operator
            }  
            return cipher.ToString();
            }

        // declaring the Decrypting method
        static string Decrypt(string word, string key)
            {
            return Encrypt(word, key);
            }
        }
    }

