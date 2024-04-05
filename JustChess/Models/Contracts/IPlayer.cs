using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.Common;
using JustChess.Figures.Contracts;
using JustChess.Figures;

namespace JustChess.Models.Contracts
{
    public interface IPlayer
    {
        ICollection<IFigure> figures { get; }
        ChessColor color { get; }
        public string name { get; }
        void AddFigure(IFigure figure);
        void RemoveFigure(IFigure figure);
        bool CheckIfFigureExists(IFigure figure);




    }
}
