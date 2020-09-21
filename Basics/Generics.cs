namespace Basics
{
    public class Generics : ISample
    {
        public void Run()
        {
            var myFirstGenericClass = new MyFirstGenericClass<string>();

            var myFirstGenericMethod = MyFirstGenericMethod("aaa");
        }

        public class MyFirstGenericClass<T>
        {
            public T SomeType { get; set; }
        }

        public T MyFirstGenericMethod<T>(T item) where T : class
        {
            return item;
        }

        //where T :
        //Base class / interface 
        //    Class
        //    Struct
        //    New()
        //    unmanaged

    }
}