import java.io.*;
public class Problem1
{
    public static void main(String[] args) throws IOException
    {
        int sum = 0;
        for( int i = 3; i < 1000; i = i + 3)
        {
            // Only count the values divisible by both 3 and 5 once
            // Count these values in the loop for multiples of 5
            if( i % 5 != 0 )
            {
                sum += i;
            }
        }

        for( int i = 5; i < 1000; i = i + 5)
        {
            sum +=i;
        }

        System.out.println(sum);
    }
}
