using Exercise.Exercise1.Engine;

namespace Exercise.Exercise1.Car
{
    public interface ICar<out T>
        where T : IEngine
    {
        T Engine { get; }

        // without generics
        //IEngine Engine { get; }
        string Color { get; }
        string Name { get; }
        int ActualSpeed { get; }
        int MaxSpeed { get; }
        void Accelerate(int speed);
        void Break();
    }
}