namespace flappyBird
{
    public class Bird
    {
        int birdX;
        int birdY;

        public Bird (int birdY, int birdX)
        {
            this.birdX = birdX;
            this.birdY = birdY;
        }

        public int BirdX { get => birdX; set => birdX = value; }
        public int BirdY { get => birdY; set => birdY = value; }
    }
}
