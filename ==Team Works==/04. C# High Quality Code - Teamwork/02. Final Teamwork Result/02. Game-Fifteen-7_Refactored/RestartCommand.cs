﻿namespace GameFifteenVersionSeven
{
    /// <summary>
    /// This is class for restarting the game.
    /// </summary>
    public class RestartCommand : ICommand // Command design pattern.
    {
        /// <summary>
        /// This method make new instance of game engine.
        /// </summary>
        /// <param name="gameEngine"></param>
        public RestartCommand(GameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        /// <summary>
        /// Gets or sets GameEngine.
        /// </summary>
        public GameEngine GameEngine { get; set; }

        /// <summary>
        /// This method execute the restart command. 
        /// </summary>
        public void Execute()
        {
            this.GameEngine.IsGameRestart = true;
            this.GameEngine.StartNewGame();
        }
    }
}
