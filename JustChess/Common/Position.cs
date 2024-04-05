using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Common
{
    public class Position
    {
        public Position(int row, char col)
        {
            this.row = row; 
            this.col = col;
        }
        public int row { get; set; }
        public char col { get; set; }

    }
}
