using System;

namespace Terminal.Drawable
{
    public class WallDrawable : IDrawable
    {
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" W ");
        }
    }
}