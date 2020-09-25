using System;

namespace ClassLibrary
{
    public class TestClass{
        public static string SayHello(string name) => $"Hello {name} from classlib";
        public int MyProperty { get; set; }
    }
}
