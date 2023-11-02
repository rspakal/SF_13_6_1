using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;


namespace SF_13_6_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const string filePath = @"SF_13_6_1.txt";
            var listWords = new List<string>();
            var linkedListWords = new LinkedList<string>();
            if (File.Exists(filePath))
            {
                var stopWatch = Stopwatch.StartNew();
                using (StreamReader sr = File.OpenText(filePath))
                {
                    var str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        listWords.Insert(0, str);
                    }
                }
                Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
                stopWatch = Stopwatch.StartNew();
                using (StreamReader sr = File.OpenText(filePath))
                {
                    var str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        linkedListWords.AddFirst(str);
                    }
                }
                Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            }
            else
            {
                Console.WriteLine("File doesnt exist");
            }
            Console.ReadKey();
        }
    }
}
