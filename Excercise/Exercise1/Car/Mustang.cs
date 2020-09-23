using System;
using Exercise.Exercise1.Engine;

namespace Exercise.Exercise1.Car
{
    public class Mustang : ICar<V8Engine>
    {
        public Mustang(V8Engine engine)
        {
            Engine = engine;
        }

        // without generics
        //public IEngine Engine { get; }

        public V8Engine Engine { get; }
        public string Color { get; }
        public string Name { get; set; }
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
            throw new NotImplementedException();
        }
    }
}