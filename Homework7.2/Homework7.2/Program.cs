using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shemoiyvanet Windebi: ");
            string sock = Console.ReadLine();

            Socks(sock);
        }

        static void Socks(String a)
        {
            var duplicates = a.GroupBy(x => x)
                .Where(g  => (g.Count() % 2) == 0)
                .Select(y  => y.Key)
                .ToList();

            List<Char> joinedSocks = new List<char>();

            foreach (var item in duplicates)
            {

                joinedSocks.Add(item);

            }

            Console.WriteLine($"Wyvili Windebis Raodenobaa: {joinedSocks.Count}");


        }
    }
}
