using System;
using Exercise.Engine;

namespace Exercise.Car
{
    public class Mustang : ICar<V8Engine>
    {
        // without generics
        public V8Engine Engine { get; set; }
        //public IEngine Engine { get; }


        public string Color { get; }
        public string Name { get; }
        public int ActualSpeed { get; }
        public int MaxSpeed { get; }

        public void Accelerate(int speed)
        {
            var speedAfterAcceleration = ActualSpeed + speed;

            if (speedAfterAcceleration > MaxSpeed)
            {
                throw new MaxSpeedExceededException("Max speed was exceeed");
            }
            try
            {
                Engine.Accelerate(speed);
            }
            catch (Exception ex)
            {
                throw new EngineFailureException("Engine exception", ex);
            }
        }

        public void Break()
        {
            //todo
            throw new System.NotImplementedException();
        }
    }

}
