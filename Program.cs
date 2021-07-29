using Quoridor.Core.GameLogic;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.AddNewPlayerPair();
            game.Start();
            ConsoleApp app = new ConsoleApp(game);
            app.Start();
        }
    }
}
