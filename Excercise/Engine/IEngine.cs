namespace Exercise.Engine
{
    public interface IEngine
    {
        Transmission Transmission { get; }
        void Accelerate(int speed);
        void Deccelerate(int speed);
    }
}