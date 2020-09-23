namespace Exercise.Exercise1.Engine
{
    public interface IEngine
    {
        string VIN { get; }
        Transmission Transmission { get; }
        void Accelerate(int speed);
        void Deccelerate(int speed);
    }
}