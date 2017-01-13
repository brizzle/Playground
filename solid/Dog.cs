using System;

namespace ConsoleApplication
{
    public abstract class Dog : IDog
    {
        public Dog()
        {

        }

        public virtual void Bark(string message)
        {
            Console.WriteLine(message);
        }
    }
}