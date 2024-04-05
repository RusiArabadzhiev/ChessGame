using JustChess.Table;
using JustChess.Common;
using JustChess.Figures;
using JustChess.Figures.Contracts;
using System.Linq.Expressions;


namespace JustChess.Renderers
{
    public class ConsoleRenderer : IRenderer
    {

        private ConsoleColor[] BlackWhite = { ConsoleColor.Gray, ConsoleColor.DarkGray };

        private ConsoleColor figureWhite = ConsoleColor.White;
        private ConsoleColor figureBlack = ConsoleColor.Black;

        private Dictionary<string, bool[,]> Patterns = Board.Patterns;

        public void RenderGame(IBoard board)
        {
            int currentcolour = 1;

            ConsoleColor colour = ConsoleColor.Red;
            
            for (int Row = 0; Row < board.totalRows; Row++)
            {

                for (int Col = 0; Col < board.totalCols; Col++)
                {

                    if(currentcolour%2 ==0)
                    {
                         colour = BlackWhite[1];
                    }
                    else
                    {
                         colour = BlackWhite[0];
                    }



                    var row = Row * 9;
                    var col = Col * 9;

                    var element = board.board[row, col];

                    DrawSquares(row,col, element, colour);
                    
                    
                }
            }



        }
        private void DrawSquares(int top, int left, IFigure figure, ConsoleColor colour)
        {
            bool[,] pattern = new bool[9,9];
            ConsoleColor figurecolour;
            bool flag=false;



            if (figure is null) {
                flag = true; }
            else {
                pattern = figure.GetPatternArray();
                pattern = Board.Patterns.Where(x => x.Key == figure.GetType().ToString()).Select(x=>x.Value).First();
            }

            if (figure?.Color.Equals(ConsoleColor.White) is true)
            {
                figurecolour = ConsoleColor.White;
            }
            else
            {
                figurecolour = ConsoleColor.Black;
            }

            Console.BackgroundColor = colour;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(top + j, left + i);

                    if (flag)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    else
                    {
                        if (pattern[i, j])
                        {
                            Console.BackgroundColor = figurecolour;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = 
                        }
                    }
                }
            }

        }


        public void RenderMainMenu(string Text)
        {

            ConsoleHelpers.SetCursorAtCenter(Text.Length);
            Console.WriteLine(Text);
            Thread.Sleep(1000);

        }
    }
}
