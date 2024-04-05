using JustChess.Common;
using JustChess.Models;
using JustChess.Models.Contracts;

namespace JustChess.InputProvider
{
    public class ConsoleInputProvider : IInputProvider
    {

        public List<string> GetMove(IPlayer player)
        {
            Console.SetCursorPosition(Console.WindowWidth/2 - player.name.Length ,0);
            Console.Write($"Player {player.name}");
            string NextMove = Console.ReadLine();

            var items = NextMove.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToString()).ToList();

            return items.ToList();

        }

        public IList<IPlayer> GetPlayers(int numberOfPlayers = GlobalConstants.StandardGameNumberOfPlayers)
        {

            IList<IPlayer> players = new List<IPlayer>();

            for(int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();

                ConsoleHelpers.SetCursorAtCenter(0);

                Console.Write(string.Format("Enter Player {0}", i));

                string name = Console.ReadLine();
                ChessColor color = ChessColor.White;
                if(i == 1)
                {
                    color = ChessColor.Black;
                }

                players.Add(new Player(color, name));

            }


            return players;


        }

    }
}
