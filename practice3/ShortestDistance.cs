using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * You want to build a house on an empty land
 * which reaches all buildings in the shortest amount of distance.
 * You can only move up, down, left and right. 
 * You are given a 2D grid of values 0, 1 or 2, where:
 * Each 0 marks an empty land which you can pass by freely.
 * Each 1 marks a building which you cannot pass through.
 * Each 2 marks an obstacle which you cannot pass through.
 */


namespace practice3
{
    class ShortestDistance
    {
        public int shortestDistance(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) return -1;
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] dis = new int[m][];
            int[][] reach = new int[m][];
            int NumHouse = 0;
            int[,] directions = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { -1, 0 } };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        NumHouse++;
                        int DisLevel = 0;
                        Boolean[][] visit = new Boolean[m][];
                        LinkedList<int> queue = new LinkedList<int>();
                        queue.AddLast(i * n + j);
                        visit[i][j] = true;
                        while (queue.Count == 0)
                        {
                            int size = queue.Count;
                            for (int t = 0; t < size; t++)
                            {
                                int EmptyPlace = queue.First();
                                int x = EmptyPlace / n;
                                int y = EmptyPlace % n;

                                for (int z = 0; z <= directions.GetUpperBound(0); i++)
                                {
                                    int xnew = directions[i, 0];
                                    int ynew = directions[i, 1];
                                    if(xnew >= 0 && xnew < m && ynew >= 0 && ynew < n &&
                                        !visit[xnew][ynew] && grid[xnew][ynew] == 0)
                                    {
                                        queue.AddLast(xnew * n + ynew);
                                        visit[xnew][ynew] = true;
                                        dis[xnew][ynew] += DisLevel + 1;
                                        reach[xnew][ynew]++;
                                    }
                                }
                            }
                            DisLevel++;
                        }
                    }
                }
            }
            int MinDist = int.MaxValue;
            for (int i =0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0 && reach[i][j] == NumHouse)
                    {
                        MinDist = Math.Min(MinDist, dis[i][j]);
                    }
                }
            }
            return MinDist == int.MaxValue ? -1 : MinDist;
        }
    }
}
