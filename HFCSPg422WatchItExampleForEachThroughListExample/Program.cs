using System;
using System.Collections.Generic;

namespace HFCSPg422WatchItExampleForEachThroughListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            values.Add("a value");
            foreach (string s in values)
            {
                values.Add("another value");
            }
        }
    }
}
