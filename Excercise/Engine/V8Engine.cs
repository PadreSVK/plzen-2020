namespace Exercise.Engine
{
    public class V8Engine : IEngine
    {
        private const int maxAvaliableAcceleration = 40;

        public Transmission Transmission { get; }

        public void Accelerate(int acceleration)
        {
            if (acceleration > maxAvaliableAcceleration)
            {
                throw new MaxAvaliableAccelerationExceededException($"Max avaliable acceleration {maxAvaliableAcceleration} was exceeded by accceration {acceleration}. ");
            }
        }

        public void Deccelerate(int acceleration)
        {
            throw new System.NotImplementedException();
        }
    }
}
