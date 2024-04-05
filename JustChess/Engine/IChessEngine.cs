using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.Engine.Initialization;
using JustChess.Models.Contracts;
using JustChess.Renderers;

namespace JustChess.Engine
{
    public interface IChessEngine
    {
        IList<IPlayer> players { get; }
        void Initialize(IGameInitializationStrategy gameInitialization);
        void Start(IRenderer ConsoleRenderer);
        void WinningCondition();

    }
}
