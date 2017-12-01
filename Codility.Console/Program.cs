using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 6;

            for (int i = 0; i <= n; i++)
            {
                var line = "";
                for (int j = n; j >= 0; j--)
                {
                    line += j > i ? " " : "#";
                }
                System.Console.WriteLine(line);
            }

            System.Console.ReadKey(true);

            //var lines = new[]
            //{
            //    new[] { "john", "xavier", "austin", "annie" },
            //    new[] { "333", "11", "578", "314", "561" },
            //    new[] { "new york", "boston", "sf", "la", "tc" },
            //};

            //var structured = new List<string[]>();
            //var maxLength = lines.Max(l => l.Length);
            //for (var i = 0; i < maxLength; i++)
            //    structured.Add(new string[lines.Length]);

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    for (int l = 0; l < lines[i].Length; l++)
            //    {
            //        structured[l][i] = lines[i][l];
            //    }
            //}

            //var sorted = structured.OrderBy(s => s[0]);
        }
    }
}
