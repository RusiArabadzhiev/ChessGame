using JustChess.Common;
using JustChess.Figures;
using JustChess.Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Table
{
    public class Board : IBoard
    {
        public IFigure[,] board { get; set; }
        public Board(
            int rows = GlobalConstants.RowsAndColdStandard,
            int cols = GlobalConstants.RowsAndColdStandard)
        {
            this.totalCols = cols;
            this.totalRows = rows;
            board = new IFigure[rows, cols];

        }

        public int totalRows { get; private set; }
        public int totalCols { get; private set; }

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.ValidateFigure(figure,
                GlobalErrorMessages.NullFigureErrorMessage);

            ObjectValidator.ValidatePosition(position);

            this.board[GetArrayRow(position.row), GetArrayCol(position.col)] = figure;


        }


        public bool ContainsFigure(Position position)
        {
            if (board[position.row, position.col] != null)
                return true;
            return false;
        }
        public IFigure GetFigure(Position position)
        {
            int top = GetArrayRow(position.row);
            int left = GetArrayCol(position.col);

            return board[top, left];

        }
        public void RemoveFigure(IFigure figure, Position position)
        {
            ObjectValidator.ValidateFigure(figure,
                GlobalErrorMessages.NullFigureErrorMessage);

            ObjectValidator.ValidatePosition(position);

            this.board[GetArrayRow(position.row), GetArrayCol(position.col)] = null;

        }

        public int GetArrayRow(int row)
        {
            return (totalRows - row);
        }
        public int GetArrayCol(char col)
        {
            return (col - 'a');
        }



        public static Dictionary<string, bool[,]> Patterns = new Dictionary<string, bool[,]>
        {


            {
                "Pawn", new bool[,]{
            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, true, false, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, false, true, false, false, false, false},
            { false, false, false, false, true, false, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false} }

            },

            { "Rook", new bool[,]{

            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, false, false, false, false, false},
            { false, false, true, false, true, false, true, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false},
            }
            },

            { "Queen", new bool[,] {

            { false, false, false, false, false, false, false, false, false},
            { false, true, false, true, false, true, false, true, false},
            { false, true, false, true, false, true, false, true, false},
            { false, true, false, true, false, true, false, true, false},
            { false, true, false, true, false, true, false, true, false},
            { false, false, true, false, true, false, true, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false},
            }
            },

            { "Knight", new bool[,]{

            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, true, true, false, false, false},
            { false, false, false, true, true, true, true, false, false},
            { false, false, true, true, false, true, true, false, false},
            { false, false, false, false, false, true, false, false, false},
            { false, false, false, false, true, true, false, false, false},
            { false, false, false, true, true, false, false, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false},

            } },
            { "King" , new bool[,]{

            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, false, false, false, false, false},
            { false, false, true, false, false, false, true, false, false},
            { false, true, true, true, false, true, true, true, false},
            { false, true, true, true, false, true, true, true, false},
            { false, true, true, true, false, true, true, true, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false},

            } },
            { "Bishop" , new bool[,] {

            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, false, false, false, false, false},
            { false, false, false, false, true, false, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, false, true, true, true, false, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, true, true, true, true, true, false, false},
            { false, false, false, false, false, false, false, false, false},

            }},

            

        };

    
    }
}
