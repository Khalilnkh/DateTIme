using System;

namespace DateTime2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(30, 6, 17,0);
            string input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "dd/MM/yyyy", null).Add(t1);
            Console.WriteLine(date);
            
            
        }
    }
}
