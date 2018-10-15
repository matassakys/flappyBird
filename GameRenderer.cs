using System;

namespace flappyBird
{
    public class GameRenderer
    {
        Map map;
        Bird bird;
        public GameRenderer (Map map, Bird bird)
        {
            this.map = map;
            this.bird = bird;
        }

        public void render()
        {
            Console.Clear();
            for (int x = 0; x < map.Height; x++)
            {
                for (int y = 0; y < map.Width; y++)
                {
                    if (map.isWall(x, y))
                    {
                        Console.Write("#");
                    }
                    else if (x == bird.birdX && y == bird.birdY)
                    {
                        Console.Write("C");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
