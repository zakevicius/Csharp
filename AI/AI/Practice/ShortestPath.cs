using System;
using System.Collections.Generic;

/*
* Princess Peach is trapped in one of the four corners of a square grid. 
* You are in the center of the grid and can move one step at a time in any of the four directions. 
* Can you rescue the princess?
* 
* Input format
* The first line contains an odd integer N (3 <= N < 100) denoting the size of the grid. 
* This is followed by an NxN grid. Each cell is denoted by '-' (ascii value: 45). 
* The bot position is denoted by 'm' and the princess position is denoted by 'p'.
* 
* Sample imput:
* 3
* ---
* -m-
* p--
* 
* Sample output:
* DOWN
* LEFT
*/

namespace AI
{
    class ShortestPath
    {
        static void displayPathtoPrincess(int n, string[] grid)
        {
            List<string> dir = new List<string>();
            List<string> path = new List<string>();

            List<int> botPos = new List<int>();
            List<int> princessPos = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'p') princessPos.AddRange(new int[]{i, j});
                    if (grid[i][j] == 'm') botPos.AddRange(new int[]{i, j});
                }
            }

            int xDif = botPos[1] - princessPos[1];
            int yDif = botPos[0] - princessPos[0];

            if (xDif > 0) dir.Add("LEFT");
            if (xDif < 0) dir.Add("RIGHT");
            if (yDif > 0) dir.Add("UP");
            if (yDif < 0) dir.Add("DOWN");

            int h = Math.Abs(xDif);
            int v = Math.Abs(yDif);

            while (dir.Count > 0) 
            {
                string step = dir[new Random().Next(0, dir.Count)];
                switch (step)
                {
                    case "UP":
                    case "DOWN":
                        path.Add(step);
                        v--;
                        if (v == 0) dir.Remove(step);
                        break;
                    case "LEFT":
                    case "RIGHT":
                        path.Add(step);
                        h--;
                        if (h == 0) dir.Remove(step);
                        break;
                }
            }

            foreach (string el in path)
            {
                Console.WriteLine(el);
            }
        }

        public static void Init()
        {
            int m;

            m = int.Parse(Console.ReadLine());

            string[] grid = new string[m];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            displayPathtoPrincess(m, grid);
        }
    }
}

