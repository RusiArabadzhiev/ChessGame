using JustChess.Table;
using JustChess.Renderers;
using System;
using System.Net.Http.Headers;
using JustChess.Engine.Initialization;
using JustChess.InputProvider;
using JustChess.Common;
using JustChess.Models;
using JustChess.Models.Contracts;
using JustChess.Engine;
using System.Reflection.Metadata;

namespace JustChess
{
    public class EntryPoint
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu("Loading...");


            IInputProvider input = new ConsoleInputProvider();

            IChessEngine engine = new StandardTwoPlayerEngine(input);


            IGameInitializationStrategy initialization = new StartGameInitializationStrategy();

            engine.Initialize(initialization);

            engine.Start(renderer);


        }
    }
}