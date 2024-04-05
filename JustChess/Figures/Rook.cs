﻿using JustChess.Common;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Figures
{
    public class Rook : BaseFigure, IFigure
    {
        public Rook(ChessColor color) 
            : base(color)
        {
        }

        public override bool MovingStrategy(Position positionOne, Position positionTwo)
        {
            // custom moving logic
        }
        
    }
}
