using System;

namespace Exercise.Car
{
    public abstract class CarFailureExceptionBase : Exception
    {
        protected CarFailureExceptionBase(string message) : base(message)
        {
        }

        protected CarFailureExceptionBase(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}