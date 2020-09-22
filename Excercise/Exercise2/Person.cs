using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercise2
{
    public abstract class Person
    {
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
    }
}
