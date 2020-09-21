namespace Basics
{
    public class Deconstruct : ISample
    {
        public void Run()
        {
            var rectangle = new Rectangle(5.5f, 4.5f);
            var (a, b) = rectangle;

        }

        public readonly struct Rectangle
        {
            public readonly float Width, Height;

            public Rectangle(float width, float height)
            {
                Width = width;
                Height = height;
            }

            public void Deconstruct(out float width, out float height)
            {
                width = Width;
                height = Height;
            }
        }
    }
}