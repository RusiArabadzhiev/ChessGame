using JustChess.Common;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.Figures;
using JustChess.Models.Contracts;

namespace JustChess.Models
{
    public class Player : IPlayer
    {
        public ICollection<IFigure> figures
        {
            get { return new List<IFigure>(figures); }
            private set { figures = value; }
        }
        public string name { get;}
        public ChessColor color { get;}

        public Player(ChessColor color, string name)
        {
            this.figures = new List<IFigure>();
            this.name = name;
            this.color = color;
        }

        public void AddFigure(IFigure figure)
        {
            ObjectValidator.ValidateFigure(figure);
            
            this.figures.Add(figure);
        }
        public void RemoveFigure(IFigure figure)
        {
            if (CheckIfFigureExists(figure))
            {
                this.figures.Remove(figure);
                return;
            }
            throw new InvalidOperationException("doesn't own that figure");
        }

        public bool CheckIfFigureExists(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                return true;
            }
            return false;
        }
    }
}
