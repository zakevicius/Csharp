using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/*
* The goal of Artificial Intelligence is to create a rational agent (Artificial Intelligence 1.1.4). 
* An agent gets input from the environment through sensors and acts on the environment with actuators. 
* In this challenge, you will program a simple bot to perform the correct actions based on environmental input.
* 
* Meet the bot MarkZoid. 
* It's a cleaning bot whose sensor is a head mounted camera and whose actuators are the wheels beneath it. It's used to clean the floor.
* 
* The bot here is positioned at the top left corner of a 5*5 grid. Your task is to move the bot to clean all the dirty cells.
* 
* Input Format* 
* The first line contains two space separated integers which indicate the current position of the bot.
* The board is indexed using Matrix Convention
* 5 lines follow representing the grid. Each cell in the grid is represented by any of the following 3 characters: 
* 'b' (ascii value 98) indicates the bot's current position, 
* 'd' (ascii value 100) indicates a dirty cell and 
* '-' (ascii value 45) indicates a clean cell in the grid.* 
* Note If the bot is on a dirty cell, the cell will still have 'd' on it.
* 
* Output Format* 
* The output is the action that is taken by the bot in the current step, and it can be either one of the movements 
* in 4 directions or cleaning up the cell in which it is currently located. 
* The valid output strings are LEFT, RIGHT, UP and DOWN or CLEAN. 
* If the bot ever reaches a dirty cell, output CLEAN to clean the dirty cell. 
* Repeat this process until all the cells on the grid are cleaned.
* 
* Sample Input 
* 0 0
* b---d
* -d--d
* --dd-
* --d--
* ----d
* 
*/

namespace AI
{
    class BotDirtCleaner
    {
        static List<Dirt> dirtList = new List<Dirt>();

        struct Dirt
        {
            public int posR { get; }
            public int posC { get; }
            public bool isCleaned { get; set; }

            public Dirt(int r, int c, bool clean = false)
            {
                posR = r;
                posC = c;
                isCleaned = clean;
            }
        }

        static class BotAction
        {
            static public readonly string UP = "UP";
            static public readonly string RIGHT = "RIGHT";
            static public readonly string DOWN = "DOWN";
            static public readonly string LEFT = "LEFT";
            static public readonly string CLEAN = "CLEAN";
        }
        
        public static void Init()
        {
            int[] pos = new int[2] { 0, 0 };
            string[] board = new string[5] {
                                            "b---d",
                                            "-d--d",
                                            "--dd-",
                                            "--d--",
                                            "----d"
                                            };

            next_move(pos[0], pos[1], board);
        }

        private static void next_move(int posR, int posC, string[] board)
        {
            if (dirtList.Count == 0) dirtList = FindDirt(board);

            if (!AreThereDirtySpots())
            {
                Console.WriteLine("Floor is clean my master.");
                return;
            }

            Dirt nearest = FindNearestDirt(posR, posC, dirtList);

            ShouldBotCleanOrShouldHeMove(posR, posC, nearest);

            foreach (string row in board)
            {
                Console.WriteLine(row);
            }

            Console.WriteLine(ShouldBotCleanOrShouldHeMove(posR, posC, nearest));      // next_move(newPosR, newPosC, newBoard);
        }

        private static string ShouldBotCleanOrShouldHeMove(int botPosR, int botPosC, Dirt dirt)
        {
            if (botPosR == dirt.posR && botPosC == dirt.posC)
            {
                dirt.isCleaned = true;
                return BotAction.CLEAN;
            }
            if (botPosR > dirt.posR) return BotAction.UP;
            if (botPosR < dirt.posR) return BotAction.DOWN;
            if (botPosC > dirt.posC) return BotAction.LEFT;
            if (botPosC < dirt.posC) return BotAction.RIGHT;
            return null;
        }

        static private List<Dirt> FindDirt(string[] board)
        {
            List<Dirt> dirtList = new List<Dirt>();

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[r].Length; c++)
                {
                    if (board[r][c] == 'd')
                    {
                        Dirt d = new Dirt(r, c);
                        dirtList.Add(d);
                    }
                }
            }

            return dirtList;
        }

        static private Dirt FindNearestDirt(int botPosR, int botPosC, List<Dirt> dirtList)
        {
            int dist = int.MaxValue;
            Dirt nearest = dirtList[0];

            foreach (Dirt dirt in dirtList)
            {
                int temp = Math.Abs(botPosR - dirt.posR) + Math.Abs(botPosC - dirt.posC);
                if (temp < dist && !dirt.isCleaned)
                {
                    dist = temp;
                    nearest = dirt;
                }
            }
            return nearest;
        }

        static private bool AreThereDirtySpots()
        {
            bool anyLeft = false;
            foreach (Dirt d in dirtList)
            {
                if (!d.isCleaned) anyLeft = true;
                break;
            }
            return anyLeft;
        }
    }
}
