import java.io.*;
public class Problem3
{
    public static void main(String[] args) throws IOException
    {
        System.out.println(getLargestPrime(600851475143l));
    }

    private static long getLargestPrime(long factor)
    {
        int divisor = 2;
        while(factor > 1)
        {
            // remove divisor factors from factor variable
            while( (factor % divisor) == 0 )
            {
                factor = factor/divisor;
            }
            divisor += 1;

            // end condition - largest factor occurs when
            // divisor squared is greater than the factor
            if( divisor*divisor > factor )
            {
                return factor;
            }
        }
        return factor;
    }
}
