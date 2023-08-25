using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                var date = DateTime.ParseExact(input, "dd | MM | yyyy", null);
                Console.WriteLine(date);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            

        }
    }
}
