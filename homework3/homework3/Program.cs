using System;
using System.Linq;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Number Number float float two";
            Console.WriteLine(data);
            var result = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key);
            foreach (var item in result) Console.Write(item + " ");
            Console.ReadLine();

            Console.WriteLine(data);
        }
    }
}
