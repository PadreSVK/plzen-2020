using System;

namespace Exercise.Car
{
    public class EngineFailureException : CarFailureExceptionBase
    {
        public EngineFailureException(string message) : base(message)
        {
        }

        public EngineFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
