namespace flappyBird
{
    public class Bird
    {
        int birdX;
        int birdY;

        public Bird (int birdY, int birdX)
        {
            this.BirdX = birdX;
            this.BirdY = birdY;
        }

        public int BirdX { get => birdX; set => birdX = value; }
        public int BirdY { get => birdY; set => birdY = value; }
    }
}
