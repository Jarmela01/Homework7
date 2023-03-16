using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Homework_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gtxovt Shemoiyvanet Pirveli Sityva: ");
            var word1 = Console.ReadLine();
            Console.Write("Gtxovt Shemoiyvanet Meore Sityva: ");
            var word2 = Console.ReadLine();

            WordEnds(word1, word2);


        }

        static void WordEnds(string a, string b)
        {
            char[] chararray1 = a.ToCharArray();
            char[] chararray2 = b.ToCharArray();
            Array.Reverse(chararray1);
            Array.Reverse(chararray2);

            List<char> chars = new List<char>();

            if (chararray1.Length >= chararray2.Length)
            {

                for (int i = 0; i < chararray2.Length; i++)
                {

                    if (chararray1[i] == chararray2[i])
                    {
                        chars.Add(chararray1[i]);
                    }                   
                }

            }

            if (chararray1.Length <= chararray2.Length) 
            {

                for (int i = 0; i < chararray1.Length; i++)
                {
                    if (chararray1[i] == chararray2[i])
                    {

                        chars.Add(chararray1[i]);

                    }
                }

            }

            chars.Reverse();
            Console.WriteLine(String.Join("", chars));






        }


    }
}
