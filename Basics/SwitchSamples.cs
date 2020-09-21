using System;

namespace Basics
{
    public class SwitchSamples : ISample
    {
        public enum Color
        {
            Red,
            Green,
            Blue,
            Black
        }

        public void Run()
        {
            ClassicSwitch(Color.Blue);
            ClassicSwitch(Color.Black);
            ClassicSwitchInIfElse(Color.Black);
        }

        public void ClassicSwitch(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        public void ClassicSwitchInIfElse(Color color)
        {
            if (color == Color.Red)
                Console.WriteLine("The color is red");
            else if (color == Color.Green)
                Console.WriteLine("The color is green");
            else if (color == Color.Blue)
                Console.WriteLine("The color is blue");
            else
                Console.WriteLine("The color is unknown.");
        }
    }
}