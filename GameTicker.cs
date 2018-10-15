using System;
using System.Timers;

namespace flappyBird
{
    public class GameTicker
    {
        GameRules gameRules;
        GameRenderer gameRenderer;
        System.Timers.Timer timer;
        bool keyPressed = false;
        public GameTicker(GameRules gameRules, GameRenderer gameRenderer, System.Timers.Timer timer)
        {
            this.gameRenderer = gameRenderer;
            this.gameRules = gameRules;
            this.timer = timer;
            timer.Elapsed += onGameTick;
            timer.AutoReset = true;
            timer.Enabled = true;
            keyLoop();            
        }

        private void onGameTick(object sender, ElapsedEventArgs e)
        {
            if (keyPressed)
            {
                gameRules.flyUp();
                keyPressed = false;
            }
            else
            {
                gameRules.fallingDown();
            }
            gameRules.moveObstacles();
            gameRenderer.render();
        }

        private void keyLoop()
        {
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { }
            keyPressed = true;
            keyLoop();
        }
    }
}
