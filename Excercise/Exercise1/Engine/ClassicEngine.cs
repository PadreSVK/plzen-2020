using System;

namespace Exercise.Exercise1.Engine
{
    public class ClassicEngine : IEngine
    {
        public ClassicEngine(string vin)
        {
            VIN = vin;
        }

        public string VIN { get; }
        public Transmission Transmission { get; }

        public void Accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public void Deccelerate(int speed)
        {
            throw new NotImplementedException();
        }
    }
}