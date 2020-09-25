namespace ConsoleApp1
{
    public interface ISuperInterface
    {
        string GetName();
    }

    class NewImplementation : ISuperInterface
    {
        public string GetName() => "asdasdasdasdas";
    }
}