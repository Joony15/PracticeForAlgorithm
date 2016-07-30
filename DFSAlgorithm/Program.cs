using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSAlgorithm
{
   public class Solution
   {
      public int numIslands(char[][] grid)
       {
            
            //grid.Length <<  행 , grid[0].Length << 열
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            
            int rows = grid.Length;
            int cols = grid[0].Length;

            Boolean[][] visited = new Boolean[rows][];
            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ( grid[i][j] == '1' && !visited[i][j])
                    {
                        result++;
                        numIslansChecker(grid, visited, i, j, rows, cols);
                    } 
                }
            }

            return result;
       }
       private void numIslansChecker(char[][] grid, Boolean[][] visited, int i, int j, int numRows, int numCols)
       {
           if (i < 0 || i >= numRows)
               return;
           if (j < 0 || j >= numCols)
               return;
           if (visited[i][j])
               return;
           if (grid[i][j] == 0)
               return;

           //방문 확인!! 이제 이걸 기준으로 DFS을 시도한다.
           visited[i][j] = true;

           //위, 아래 , 좌우 탐색
           numIslansChecker(grid, visited, i - 1, j, numRows, numCols);
           numIslansChecker(grid, visited, i + 1, j, numRows, numCols);
           numIslansChecker(grid, visited, i, j - 1, numRows, numCols);
           numIslansChecker(grid, visited, i, j + 1, numRows, numCols);
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
