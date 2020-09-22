namespace Basics
{
    public class Operators : ISample
    {
        public class MyClass1
        {
            public string Test { get; set; }
            public MyClass2 MyClass2 { get; set; }
        }
        public class MyClass2
        {
            public string Test { get; set; }
        }

        public int? MyAge { get; set; }

        public void Run()
        {
            var test1 = 0;
            if (MyAge.HasValue)
            {
                test1 = MyAge.Value;
            }

            var test = MyAge.HasValue
                ? MyAge.Value
                : 0;

            var test3 = MyAge ?? 0;

            MyAge ??= 55;

            var myClass1 = new MyClass1();

            string myclass2test = null;
            if (myClass1.MyClass2 != null)
            {
                myclass2test = myClass1.MyClass2.Test;
            }

            string myclass2test2 = myClass1.MyClass2?.Test;
        }
    }
}