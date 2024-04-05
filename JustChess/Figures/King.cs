using JustChess.Common;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Figures
{
    public class King : BaseFigure, IFigure
    {
        public King(ChessColor color)
            : base(color)
        {
            Pattern = new bool[,]{

            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, false, false, false, false, false},
            { false, false, true, false, false, false, true, false, false},
            { false, true, true, true, false, true, true, true, false},
            { false, true, true, true, false, true, true, true, false},
            { false, true, true, true, false, true, true, true, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false}
            };
        }
        public override bool MovingStrategy(Position positionOne, Position positionTwo)
        {
            // custom moving logic
            return true;
        }

        public bool [,] GetPatternArray()
        {
            return Pattern;
        }

        public bool[,] Pattern { get; set; }

    }
}
