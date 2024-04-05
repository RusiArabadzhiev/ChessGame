using JustChess.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Figures.Contracts
{
    public interface IFigure
    {
        bool MovingStrategy(Position positionOne, Position positionTwo);

        ChessColor Color { get; }

        public bool[,] GetPatternArray();
    }
}
