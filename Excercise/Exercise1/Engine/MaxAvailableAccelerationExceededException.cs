using System;

namespace Exercise.Exercise1.Engine
{
    public class MaxAvailableAccelerationExceededException : Exception
    {
        public MaxAvailableAccelerationExceededException(string message)
            : base(message)
        {
        }

        public MaxAvailableAccelerationExceededException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}