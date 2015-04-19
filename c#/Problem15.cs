using System;
using System.IO;
class Problem15
{
    static void Main()
    {
      // 20 x 20 grid
      const int size = 20;

      Console.WriteLine( "Dynamic Programming Solution: ");
      ExecutionTimer.start();
      Console.WriteLine(numRoutesDynamicSolution(size, size));
      ExecutionTimer.stop();

      Console.WriteLine( "combinatorics solution: ");
      ExecutionTimer.start();
      Console.WriteLine(numRoutesCombinatoricsSolution(size));
      ExecutionTimer.stop();
    }

    /*
      Solution via dynamic programming. Each entry, numberOfRoutes[i,j] will
      represent the number of total routes at a grid size i by j
    */
    private static long numRoutesDynamicSolution(int x, int y) {
      long[,] numberOfRoutes = new long[x+1, y+1];
      // set initial conditions
      for(int i = 0; i <= y; i++) {
        numberOfRoutes[0,i] = 1;
      }
      for(int i = 0; i <= x; i++) {
        numberOfRoutes[i,0] = 1;
      }

      for(int i = 1; i <= x; i++) {
        for(int j = 1; j <= y; j++) {
          numberOfRoutes[i,j] = 0;
          if( i > 0 ) {
            numberOfRoutes[i,j] += numberOfRoutes[i-1,j];
          }
          if( j > 0 ) {
            numberOfRoutes[i,j] += numberOfRoutes[i,j-1];
          }
        }
      }
      return numberOfRoutes[x,y];
    }

    /*
      This solution is based on choosing N right arrows from 2N total arrows
      The formula was found on wikipedia
    */
    private static long numRoutesCombinatoricsSolution(int gridSize) {
      long paths = 1;
      for (int i = 0; i < gridSize; i++) {
          paths *= (2 * gridSize) - i;
          paths /= i + 1;
      }
      return paths;
    }
}
