﻿using System;

namespace flappyBird
{
    public class Map
    {
        int[,] map = new int[,]
        {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
        };
        public int Height;
        public int Width;
        public Map()
        {
            Height = map.GetLength(0);
            Width = map.GetLength(1);
            Console.SetWindowSize(Width+20, Height+2);
        }
        public bool isWall(int x, int y)
        {
            return map[x, y] == 1;
        }
        public void swapColumns(int leftOne, int rightOne)
        {
            for (int i = 0; i < Height; i++)
            {
                map[i, leftOne] = map[i, rightOne];
            }
        }
        int gapBetweenObstacles = 0;
        Random random = new Random();
        public void generateObstacle()
        {
            int[] nextObstacle = new int[Height];
            gapBetweenObstacles++;
            if (gapBetweenObstacles == 5)
            {
                int caseSwitch = random.Next(4);
                switch (caseSwitch)
                {
                    case 0:
                        nextObstacle = new int[] { 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };  
                        break;
                    case 1:
                        nextObstacle = new int[] { 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1 };
                        break;
                    case 2:
                        nextObstacle = new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1 };
                        break;
                    case 3:
                        nextObstacle = new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1 };
                        break;
                }
                gapBetweenObstacles = 0;
            }
            else
            {
                nextObstacle = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            }
            for (int i = 0; i < Height; i++)
            {
                map[i, Width-1] = nextObstacle[i];
            }
        }
    };

}

