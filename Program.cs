namespace flappyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Bird bird = new Bird(5, 3);
            GameRenderer gameRenderer = new GameRenderer(map, bird);
            System.Timers.Timer timer = new System.Timers.Timer(200); // Timeris 200ms
            GameRules gameRules = new GameRules(map, bird, timer);
            GameTicker game = new GameTicker(gameRules, gameRenderer, timer);
        }
    }
}
