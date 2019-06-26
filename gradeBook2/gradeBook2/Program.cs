using System;
using System.Collections.Generic;

namespace gradeBook2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "one"}, {2, "2"}, {3, "three"}
            };

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
