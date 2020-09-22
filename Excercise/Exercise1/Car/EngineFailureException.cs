using System;

namespace Exercise.Exercise1.Car
{
    public class EngineFailureException : CarFailureExceptionBase
    {
        public EngineFailureException(string message) : base(message)
        {
        }

        public EngineFailureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}