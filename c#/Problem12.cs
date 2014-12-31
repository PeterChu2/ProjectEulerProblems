using System;
using System.IO;
using System.Collections;

class Problem12
{
    static void Main()
    {
        // // set static number of desired number of divisors
        // int desiredNumDivisors = 500;


        // // Note: sum( 1 + 2 ... n ) = ( n* ( n + 1 )) / 2
        // // use this fact to determine triangle numbers

        // // use variable at end to produce triangle number
        // int number;
        // // use variable to store current number of divisors - set to 1 initially
        // int numDivisors = 0;

        // // create variable i to store the n in the sum formula and set it to 1
        // int i = 1;

        // // Use Prime factorization - the product of the exponents of the number
        // // in prime factorization is equal to the number of divisors


        // while( numDivisors < desiredNumDivisors )
        // {
        //     // the number of divisors is the product of the number of divisors
        //     // of the two numbers, i/2 and i+1 or i and (i+1)/2 depending on
        //     // which of the two is even
        //     if( i % 2 == 0 )
        //     {
        //         numDivisors = divCount(i/2) * divCount(i + 1) + 1;
        //     }
        //     else
        //     {
        //         // add one to count for the divisor '1'
        //         numDivisors *= divCount(i) * divCount((i + 1)/2) + 1;
        //     }
        //     Console.WriteLine(i*(i-1)/2);
        //     Console.WriteLine(numDivisors);
        //     i += 1;
        // }


        // // Display the number that has at least 500 factors
        // i = i - 1;
        // number = i * (i - 1) / 2;
        // Console.WriteLine(number);
        int number = 1;
        int i = 2;
        int cnt = 0;
        int Dn1 = 2;
        int Dn = 2;

        while (cnt < 500) {
            if (i % 2 == 0) {
                Dn = divCount(i + 1);
                cnt = Dn * Dn1;
            } else {
                Dn1 = divCount((i + 1) / 2);
                cnt = Dn*Dn1;
            }
            i++;
        }

        number = i * (i - 1) / 2;
        Console.WriteLine(number);
    }

    private static int divCount(int number) {
        Console.WriteLine("AAA"+number);
        int originalNum = number;
        int divisorCount = 1;
        int exponent;
        bool isPrime;
        for( int i = 2; i*i <= originalNum; i ++ )
        {

            isPrime = true;
            // if the number is not divisible by i go to next loop
            if( number % i != 0 )
            {
                continue;
            }
            // check to see the number is prime
            for ( int j = 2; j*j <= i; j++ )
            {
                // if the divisor is 2, skip this step
                if( i == 2 )
                {
                    break;
                }
                // i is not prime
                if( i % j == 0 )
                {
                    isPrime = false;
                    break;
                }
            }
            exponent = 0;
            if (isPrime)
            {
                while( number % i == 0 )
                {
                    number = number/i;
                    exponent += 1;
                }
                divisorCount *= exponent;
            }
        }
        Console.WriteLine("bbb" + divisorCount);
        return divisorCount;
    }

}
