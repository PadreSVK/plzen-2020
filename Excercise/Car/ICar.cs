namespace Exercise.Car
{
    public interface ICar<T> where T : IEngine
    {
        T Engine { get; }
        string Color { get; }
        string Name { get; }
        int ActualSpeed { get; }
        int MaxSpeed { get; }
        void Accelerate(int speed);
        void Break();
    }

}
