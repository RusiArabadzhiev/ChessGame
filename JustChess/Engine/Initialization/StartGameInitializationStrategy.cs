using JustChess.Table;
using JustChess.Common;
using JustChess.Figures;
using JustChess.Figures.Contracts;
using JustChess.Models.Contracts;


namespace JustChess.Engine.Initialization
{
    public class StartGameInitializationStrategy : IGameInitializationStrategy
    {
        private IList<Type> typesOfFigures = new List<Type>{
        typeof(Rook),
        typeof(Knight),
        typeof(Bishop),
        typeof(Queen),
        typeof(King),
        typeof(Bishop),
        typeof(Knight),
        typeof(Rook),
        };


        public void Initialize(IList<IPlayer> player, IBoard board)
        {
            ObjectValidator.ValidateStrategy(player, board);

            var firstPlayer = player[0];
            var secondPlayer = player[1];

            AddPawns(firstPlayer,board,7);
            AddOtherFigures(firstPlayer,board,8);
            AddPawns(secondPlayer, board, 2);
            AddOtherFigures(secondPlayer, board, 1);

            

        }
        
        private void AddOtherFigures(IPlayer player, IBoard board, int row)
        {
            for(int i=0;i<typesOfFigures.Count; i++)
            {
                var type = typesOfFigures[i];
                var figure = (IFigure)Activator.CreateInstance(type,player.color);
                player.AddFigure(figure);
                var position = new Position(row, (char)(i + 'a'));
                board.AddFigure(figure, position);

            }
        }
        private void AddPawns(IPlayer player,IBoard board, int row)
        {
            for (int i = 0; i < GlobalConstants.RowsAndColdStandard; i++)
            {
                var Pawn = new Pawn(player.color);
                player.AddFigure(Pawn);
                var position = new Position(row, (char)(i + 'a'));
                board.AddFigure(Pawn, position);
            }
        }
    }
}
