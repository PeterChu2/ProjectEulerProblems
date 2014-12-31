using System;
using System.IO;

class Problem11
{
    static void Main()
    {

        string[] lines = System.IO.File.ReadAllLines(@"inputProblem11.txt");
        int[,] numbers = new int[20, 20];
        string[] line;
        int max = int.MinValue;
        int currentProduct;

        // Populate int array with contents of file
        for (int i = 0; i < lines.Length; i++)
        {
            line = lines[i].Split(' ');
            for (int j = 0; j < line.Length; j++)
            {
                numbers[i, j] = Convert.ToInt32(line[j]);
            }
        }

        // Go through populated array of numbers
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for(int j = 0; j < numbers.GetLength(1); j++)
            {
                if( j + 3 < numbers.GetLength(1))
                {
                    currentProduct = numbers[i, j] * numbers[i, j + 1]
                        * numbers[i, j + 2] * numbers[i, j + 3];
                    if(max < currentProduct)
                    {
                        max = currentProduct;
                    }
                }
                if( i + 3 < numbers.GetLength(0))
                {
                    currentProduct = numbers[i, j] * numbers[i + 1, j]
                        * numbers[i + 2, j] * numbers[i + 3, j];
                    if(max < currentProduct)
                    {
                        max = currentProduct;
                    }
                }
                if( ( j + 3 < numbers.GetLength(1)) && ( i + 3 < numbers.GetLength(0))  )
                {
                    currentProduct = numbers[i, j] * numbers[i + 1, j + 1]
                        * numbers[i + 2, j + 2] * numbers[i + 3, j + 3];
                    if(max < currentProduct)
                    {
                        max = currentProduct;
                    }
                }

                if( ( j - 3 >= 0) && ( i + 3 < numbers.GetLength(0))  )
                {
                    currentProduct = numbers[i, j] * numbers[i + 1, j - 1]
                        * numbers[i + 2, j - 2] * numbers[i + 3, j - 3];
                    if(max < currentProduct)
                    {
                        max = currentProduct;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}
