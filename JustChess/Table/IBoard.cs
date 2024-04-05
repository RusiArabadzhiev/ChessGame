using JustChess.Common;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.Figures;

namespace JustChess.Table
{
    public interface IBoard
    {
        IFigure GetFigure(Position position);
        IFigure[,] board { get; }
        int totalRows { get; }

        int totalCols { get; }

        int GetArrayRow(int row);
        int GetArrayCol(char col);

        void RemoveFigure(IFigure figure, Position position);

        void AddFigure(IFigure figure, Position position);
    }
}
