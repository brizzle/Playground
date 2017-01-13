using System;

namespace ConsoleApplication
{
    public class Yorkie : IDog
    {
        public Yorkie()
        {

        }

        public void Bark(string message)
        {
            Console.WriteLine($"Yorkie: {message}");
        }
    }
}