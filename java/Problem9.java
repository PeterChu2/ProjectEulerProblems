import java.io.*;

public class Problem9
{
    public static void main(String[] args) throws IOException
    {
        int b;
        int sum = 1000;
        for(int c = 1000; c >= 1; c--)
        {
            // second loop only goes from 1 to c
            // to avoid checking the same pair twice
            for(int a = 1; a <= c; a++)
            {

                // c is always greater than a
                if( (a >= c) || (a + c > 1000) )
                {
                    break;
                }
                b = sum - a - c;
                // Condition for pythagorean triplet
                if ( (c*c - a*a) == b*b )
                {
                    System.out.println( a*b*c );
                    // break out of loop after a set of numbers is found
                    // otherwise, the loop will continue and find the other
                    // value that yields the same numbers in a different order
                    break;
                }
            }
        }

    }
}
