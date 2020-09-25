namespace ClassLibrary
{
    public interface IMyServiceGeneric<out T>
    {
        T TestMethod();
    }
}
