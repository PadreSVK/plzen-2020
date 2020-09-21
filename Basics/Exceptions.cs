using System;

namespace Basics
{
    public class Exceptions : ISample
    {
        public void Run()
        {
            //try catch finally
            try
            {

            }
            catch (MySecretException e) when (e.Message.Contains("haha"))
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {

            }
        }

        public class MySecretException : Exception
        {
            public MySecretException(string message) : base(message)
            {
            }

            public MySecretException(string message, Exception innerException) : base(message, innerException)
            {
            }

            public static MySecretException Create()
            {
                return new MySecretException("My secret exception is here");
            }
        }
    }
}