import java.io.*;
import java.lang.Math;
public class Problem6
{
    public static void main(String[] args) throws IOException
    {
        int sumOfSquares = 0;
        int sumSquared = 0;
        for(int i = 1; i <= 100; i++)
        {
            sumOfSquares += i*i;
            sumSquared += i;
        }
        // Square after summing individual terms
        sumSquared = sumSquared * sumSquared;
        System.out.println("The difference between the sum of squares"
            + " and the square of the sum is " + Math.abs(
                sumOfSquares - sumSquared) );
    }
}
