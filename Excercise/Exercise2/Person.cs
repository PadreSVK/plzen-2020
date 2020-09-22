using System;

namespace Exercise.Exercise2
{
    public abstract class Person
    {
        private void PrivateMethod()
        {
            Console.WriteLine("private method");
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello from Person");
        }

        public abstract void Scream(string words);

        protected virtual void SayProtectedHello()
        {
            Console.WriteLine("protected Hello from Person");
        }

        protected abstract void SecretScream(string words);
    }
}