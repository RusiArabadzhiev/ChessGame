using JustChess.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Renderers
{
    public interface IRenderer
    {
        void RenderMainMenu(string text);

        void RenderGame(IBoard board);


    }
}
