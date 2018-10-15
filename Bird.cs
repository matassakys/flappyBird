namespace flappyBird
{
    public class Bird
    {
        public int birdX;
        public int birdY;

        public Bird (int birdY, int birdX)
        {
            this.birdX = birdX;
            this.birdY = birdY;
        }
        public void setBirdX(int birdX)
        {
            this.birdX = birdX;
        }
        public void setBirdY(int birdY)
        {
            this.birdY = birdY;
        }
    }
}
