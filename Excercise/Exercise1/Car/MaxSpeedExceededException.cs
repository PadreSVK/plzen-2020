using System;

namespace Exercise.Exercise1.Car
{
    public class MaxSpeedExceededException : CarFailureExceptionBase
    {
        public MaxSpeedExceededException(string message) : base(message)
        {
        }

        public MaxSpeedExceededException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}