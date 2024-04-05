using JustChess.Models.Contracts;
using JustChess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChess.Common;

namespace JustChess.InputProvider
{
    public interface IInputProvider
    {
        List<string> GetMove(IPlayer player);
        IList<IPlayer> GetPlayers(int numberOfPlayers = GlobalConstants.StandardGameNumberOfPlayers);
        
    }
}
