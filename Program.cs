using System;
using System.Collections.Generic;
using System.Linq;
using IdGen;
using shortid;

namespace IdGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ids1 = CreateFromIdGen();
            var ids2 = CreateFromShortId();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Id: {ids1[i]}, {ids2[i]}");
            }

        }

        static List<long> CreateFromIdGen()
        {
            var gen = new IdGenerator(0);
            var ids = from i in Enumerable.Range(1, 100)
                      select gen.CreateId();
            return ids.ToList();
        }

        static List<string> CreateFromShortId()
        {
            var ids = from i in Enumerable.Range(1, 100)
                      select ShortId.Generate(true, false, 18);
            return ids.ToList();
        }
    }
}
