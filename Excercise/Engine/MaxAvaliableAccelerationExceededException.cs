using System;

namespace Exercise.Engine
{
    public class MaxAvaliableAccelerationExceededException : Exception
    {
        public MaxAvaliableAccelerationExceededException(string message) : base(message)
        {
        }

        public MaxAvaliableAccelerationExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
