using JustChess.Table;
using JustChess.Figures.Contracts;
using JustChess.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Common
{
    public class ObjectValidator
    {
        public static void ValidateFigure(object Object, 
            string ErrorMessage = GlobalErrorMessages.EmptyString)
        {
            if (Object == null)
                throw new Exception(ErrorMessage);

        }

        public static void ValidatePosition(Position position)
        {
            if (position.row < 0 || position.row > GlobalConstants.RowsAndColdStandard)
                throw new IndexOutOfRangeException(GlobalErrorMessages.OutsideOfTheArray);
            if(position.col < 0 || position.col> GlobalConstants.RowsAndColdStandard)
                throw new IndexOutOfRangeException(GlobalErrorMessages.OutsideOfTheArray);
        }
        public static void ValidateStrategy(ICollection<IPlayer> player, IBoard board)
        {
            if (player.Count != 2) throw new InvalidOperationException("players must be two");

            if (board.totalCols != 8 || board.totalRows != 8)
            {
                throw new InvalidOperationException("8x8 board");
            }
        }
    }
}
