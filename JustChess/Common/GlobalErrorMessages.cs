using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChess.Common
{
    public class GlobalErrorMessages
    {
        public const string EmptyString = "";
        public const string NullFigureErrorMessage = "figure cannot be null";
        public const string OutsideOfTheArray = "must be withing the array";
        public static string HasThatFigureAlready = "this player already owns this figure";
    }
}
