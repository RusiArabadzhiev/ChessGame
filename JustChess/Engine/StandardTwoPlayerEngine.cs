using JustChess.Table;
using JustChess.Engine.Initialization;
using JustChess.Models.Contracts;
using JustChess.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.InputProvider;
using JustChess.Common;
using JustChess.Figures.Contracts;

namespace JustChess.Engine
{
    public class StandardTwoPlayerEngine : IChessEngine
    {

        private IBoard board;
        private IInputProvider inputprovider;

        public IList<IPlayer> players
        {
            get { return new List<IPlayer>(players); }
            set { players = value; }
        }

        public StandardTwoPlayerEngine(IInputProvider input)
        {
            this.board = new Board();
            this.inputprovider = input;
        }
        
        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {

            players = inputprovider.GetPlayers(GlobalConstants.StandardGameNumberOfPlayers);
            gameInitializationStrategy.Initialize(players,board);

        }

        public void Start(IRenderer ConsoleRenderer)
        {
            var currentPlayer = players[1];


            while (true)
            {

                currentPlayer = GetNextPlayer(currentPlayer);

                ConsoleRenderer.RenderGame(board);

                List<string> NextMove = inputprovider.GetMove(currentPlayer).ToList();

                var one = NextMove[0];
                var two = NextMove[1];

                Position positionOne = new Position((int)one[0], one[1]);
                Position positionTwo = new Position((int)two[0], two[1]);

                IFigure figure = board.GetFigure(positionOne);

                Type first = figure.GetType();

                var strategy = first.GetMethod("MovingStrategy");

                if ((bool)strategy.Invoke(first, null))
                {

                    IFigure fig = board.GetFigure(positionOne);
                    board.RemoveFigure(fig, positionOne);
                    board.AddFigure(fig, positionTwo);

                }
                else
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, 0);
                    Console.Write("Invalid Move");
                }



            }

        }
        private IPlayer GetNextPlayer(IPlayer player)
        {
            if (player.color == ChessColor.White)
                return players.Where(x => x.color == ChessColor.Black).First();
            return players.Where(x => x.color == ChessColor.White).First();
        }

        public void WinningCondition()
        {
        }
    }
}
