﻿namespace GameFifteenVersionSeven
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This Class contain the Main() method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This method call StartTheGame() method of GameEngine class.
        /// </summary>
        public static void Main()
        {
            Player currentPlayer = new Player();
            GameEngine gameEngine = new GameEngine(currentPlayer);
            gameEngine.StartTheGame();
        }
    }
}
