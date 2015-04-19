using System;
using System.IO;

/*
  Will use dynamic programming approach - Same solution at Problem 18
*/
class Problem67
{
  static void Main()
  {
    ExecutionTimer.start();

    string[] lines = System.IO.File.ReadAllLines(@"p067_triangle.txt");

    // jagged array to store all the numbers in the file
    int[][] numbers = new int[lines.Length][];

    // jagged array representing the maximum sum starting at the number
    // in the array at point [i,j] to the bottom of triangle
    int[][] maxSums = new int[lines.Length][];

    string[] line;
    // Populate int array with contents of file
    for (int i = 0; i < lines.Length; i++)
    {
      line = lines[i].Split(' ');
      numbers[i] = convertToIntArray(line);
      maxSums[i] = new int[numbers[i].Length];
    }

    // Set initial conditions (bottom row numbers will have max sum equal to
    // itself)
    for(int i = 0; i < numbers[numbers.Length - 1].Length; i++) {
      maxSums[numbers.Length - 1][i] = numbers[numbers.Length - 1][i];
    }

    // calculate the rest of the maxSum array using initial conditions
    for( int i = numbers.Length - 2; i >= 0; i-- ) {
      for(int j = 0; j < numbers[i].Length; j++) {
        maxSums[i][j] = numbers[i][j] + Math.Max(maxSums[i+1][j],maxSums[i+1][j+1]);
      }
    }
    Console.WriteLine(maxSums[0][0]);
    ExecutionTimer.stop();
  }


  private static int[] convertToIntArray(string[] stringArray) {
    int[] intArray = new int[stringArray.Length];
    for (int i = 0; i < intArray.Length; i++) {
      intArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return intArray;
  }
}
