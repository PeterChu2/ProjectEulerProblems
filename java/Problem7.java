import java.io.*;
import java.lang.Math;
public class Problem7
{
    public static void main(String[] args) throws IOException
    {
        // start the count at 1 to count for the prime number 2
        int count = 1;
        // Next integer to test after 2 is 3
        // This is done because odd numbers should only be tested
        // after  the number 2
        int num = 3;
        boolean nextFlag = false;

        while(true)
        {
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    // this number is not a prime
                    nextFlag = true;
                    break;
                }
            }

            // not prime
            if(nextFlag)
            {
                num += 2;
                nextFlag = false;
                // go check next number immediately
                continue;
            }

            // Add to the count of prime numbers
            count++;
            if (count == 10001)
            {
                System.out.println("The " + count + "st "
                    + "number is " + num);
                return;
            }
            // Only test odd numbers - all even numbers are not prime
            num += 2;
        }
    }
}
