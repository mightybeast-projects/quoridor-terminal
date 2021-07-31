using System;
using System.Collections.Generic;

namespace Terminal.Drawable
{
    public class PlayerDrawable : IDrawable
    {
        private static List<ConsoleColor> _colorsList = new List<ConsoleColor>()
        {
            ConsoleColor.DarkRed,
            ConsoleColor.DarkBlue,
            ConsoleColor.DarkYellow,
            ConsoleColor.DarkMagenta
        };
        
        private ConsoleColor _playerColor;

        public PlayerDrawable(int playerIndex)
        {
            _playerColor = _colorsList[playerIndex];
        }

        public void Draw()
        {
            Console.BackgroundColor = _playerColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" P ");
        }
    }
}