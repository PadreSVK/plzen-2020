using System;

namespace Exercise.Exercise2
{
    public class Manager: Person
    {
        public override void Scream(string words)
        {
            Console.WriteLine("scream from Manager");

        }

        protected override void SecretScream(string words)
        {
            Console.WriteLine("secret Scream from ");
        }

        public override void SayHello()
        {
            Console.WriteLine("hello from manager");
            base.SayHello();
        }
    }
}