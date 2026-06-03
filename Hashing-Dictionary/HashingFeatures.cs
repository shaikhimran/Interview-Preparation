using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Hashing_Dictionary
{
    public class HashingFeatures
    {
        HashSet<string> hashset = new HashSet<string>();
        List<string> list = new List<string>();
        public HashingFeatures()
        {
           
            
        }
        public HashingFeatures(bool LoadFaskLoopData)
        {

            for (int i = 0; i < 10000000; i++)
            {

                hashset.Add("test" + i);
                list.Add("test" + i);
            }
        }

        public void DuplicateIgnored()
        {
          HashSet<string> ignored = new HashSet<string>();
            ignored.Add("apple");
            ignored.Add("banana");
            ignored.Add("orange");
            ignored.Add("apple"); // Duplicate, will be ignored
            Console.WriteLine("Ignored items:");
            foreach (var item in ignored)
            {
                Console.WriteLine(item);
            }
        }

        public void Fastlookup(string key) {


            //;
            var stopwatch = Stopwatch.StartNew();
            Console.WriteLine(list.Contains(key));
            stopwatch.Stop();

            Console.WriteLine($"List Elapsed: {stopwatch.ElapsedMilliseconds} ms");

            var stopwatch1 = Stopwatch.StartNew();
            Console.WriteLine(hashset.Contains(key));
            stopwatch1.Stop();

            Console.WriteLine($"Hash Elapsed: {stopwatch1.ElapsedMilliseconds} ms");



        }
    }
}
