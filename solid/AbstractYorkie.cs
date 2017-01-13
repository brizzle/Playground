using System;

namespace ConsoleApplication
{
    public class AbstractYorkie : Dog
    {
        public AbstractYorkie()
        {

        }

        public override void Bark(string message)
        {
            Console.WriteLine($"Abstract Yorkie: {message}");
        }
    }
}