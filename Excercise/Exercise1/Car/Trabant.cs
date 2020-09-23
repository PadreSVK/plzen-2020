using Exercise.Exercise1.Engine;

namespace Exercise.Exercise1.Car
{
    public class Trabant : ICar<ClassicEngine>
    {
        public Trabant(ClassicEngine engine)
        {
            Engine = engine;
        }

        public ClassicEngine Engine { get; }
        public string Color { get; }
        public string Name { get; set; }
        public int ActualSpeed { get; }
        public int MaxSpeed { get; }
        public void Accelerate(int speed)
        {
            throw new System.NotImplementedException();
        }

        public void Break()
        {
            throw new System.NotImplementedException();
        }
    }
}