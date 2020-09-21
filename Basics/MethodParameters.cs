using System;

namespace Basics
{
    public class MethodParameters : ISample
    {
        public void Run()
        {
            //params
            Console.WriteLine("Params");
            UseParams(1, 2, 3, 4);

            // in parameter
            var readonlyArgument = 44;
            InArgExample(readonlyArgument);
            Console.WriteLine(readonlyArgument); // value is still 44

            // in parameters
            var number = 1;
            RefArgExample(ref number);
            Console.WriteLine(number); // value is 45

            //out parameters
            Console.WriteLine("out parameter");
            int initializeInMethod;
            OutArgExample(out initializeInMethod);
            Console.WriteLine(initializeInMethod); // value is now 44

            // named parameters
            NamedParameters(name: "Jožo", age: 25, sex: "male");
        }

        private void InArgExample(in int number)
        {
            // Uncomment the following line to see error CS8331
            //number = 19;
        }

        private void RefArgExample(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }

        private void OutArgExample(out int number)
        {
            number = 44;
        }

        private void UseParams(params int[] list)
        {
            foreach (var item in list) Console.Write(item + " ");
            Console.WriteLine();
        }

        private void NamedParameters(int age, string name, string sex)
        {
            Console.WriteLine($"{name}, {age}, {nameof(sex)}:{sex}");
        }
    }
}