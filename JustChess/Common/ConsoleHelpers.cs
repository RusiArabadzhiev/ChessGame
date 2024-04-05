using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JustChess.Common
{
    public static class ConsoleHelpers
    {

        public static void SetCursorAtCenter(int lengthOfMessage)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - lengthOfMessage / 2, Console.WindowHeight / 2);

        }

    }
}
