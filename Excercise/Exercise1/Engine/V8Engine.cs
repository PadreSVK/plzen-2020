using System;

namespace Exercise.Exercise1.Engine
{
    public class V8Engine : IEngine
    {
        private const int MaxAvailableAcceleration = 40;

        public V8Engine(string vin)
        {
            Transmission = Transmission.Manual;
            VIN = vin;
        }

        public string InternalName => "Honey";
        public string VIN { get; }
        public Transmission Transmission { get; }

        public void Accelerate(int acceleration)
        {
            if (acceleration > MaxAvailableAcceleration)
            {
                throw new MaxAvailableAccelerationExceededException(
                    $"Max available acceleration {MaxAvailableAcceleration} was exceeded by acceleration {acceleration}. ");
            }
        }

        public void Deccelerate(int acceleration)
        {
            throw new NotImplementedException();
        }
    }
}