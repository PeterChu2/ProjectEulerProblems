import java.io.*;

public class Problem10
{
    public static void main(String[] args) throws IOException
    {
        final int primesBelowValue = 2000000;
        long total;
        // initialize boolean for whether number is prime to true
        boolean isPrime = true;

        // initialize total to 2 because of first prime number, 2
        total = 2;

        // increase by 2 each time because all primes other than 2
        // are odd
        for(int i = 3; i < primesBelowValue; i = i + 2)
        {
            // see for each number i, if there exists a factor j that divides i
            // go up to sqrt(i)
            for(int j = 2; j*j <= i; j++)
            {
                if( i % j == 0 )
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                total += i;
            }
            // reset isPrime to true
            isPrime = true;
        }

        // print the final sum of prime numbers
        System.out.println(total);

    }
}
