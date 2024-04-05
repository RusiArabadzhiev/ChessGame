using JustChess.Common;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using JustChess.Figures.Contracts;

namespace JustChess.Figures
{
    public abstract class BaseFigure : IFigure
    {

        public ChessColor Color { get; }

        protected BaseFigure(ChessColor color)
        {
            this.Color = color;
        }

        public abstract bool MovingStrategy(Position one, Position Two);

    }
}
