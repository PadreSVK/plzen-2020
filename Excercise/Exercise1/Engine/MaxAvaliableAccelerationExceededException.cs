using System;

namespace Exercise.Exercise1.Engine
{
    public class MaxAvaliableAccelerationExceededException : Exception
    {
        public MaxAvaliableAccelerationExceededException(string message)
            : base(message)
        {
        }

        public MaxAvaliableAccelerationExceededException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}