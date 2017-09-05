using System;

namespace APlusB
{
    public class Program
    {
        public void Main1(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = int.Parse(tokens[0]);
            var b = int.Parse(tokens[1]);
            Console.WriteLine(a + b);
        }
    }
}