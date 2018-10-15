using System;

namespace flappyBird
{
    public class GameRules
    {
        Map map;
        Bird bird;
        System.Timers.Timer timer;
        int flaps;

        public GameRules (Map map, Bird bird, System.Timers.Timer timer)
        {
            this.map = map;
            this.bird = bird;
            this.timer = timer;
        }
        public bool isGameOver()
        {
            return (map.isWall(bird.BirdX, bird.BirdY));
        }
        public void endGame()
        {
            Console.WriteLine("GAME OVER. you flapped " + flaps + " flaps");
            timer.Enabled = false;
            Console.Read();            
        }
        public void flyUp()
        {
            bird.BirdX = bird.BirdX - 3;
            flaps++;
            if (isGameOver()) endGame();
        }
        public void fallingDown()
        {
            bird.BirdX = bird.BirdX + 1;
            if (isGameOver()) endGame();
        }
        public void moveObstacles()
        {
            for (int i = 0; i < map.Width - 1; i++)
            {
                map.swapColumns(i, i + 1);
            }
            map.generateObstacle();
        }
    }
}
