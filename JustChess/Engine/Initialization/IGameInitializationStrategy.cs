using JustChess.Table;
using JustChess.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Engine.Initialization
{
    public interface IGameInitializationStrategy
    {
        void Initialize(IList<IPlayer> player, IBoard board);


    }
}
