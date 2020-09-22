using System;

namespace Exercise.Car
{
    public abstract class CarFailureExceptionBase : Exception
    {
        public CarFailureExceptionBase(string message) : base(message)
        {
        }

        public CarFailureExceptionBase(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
