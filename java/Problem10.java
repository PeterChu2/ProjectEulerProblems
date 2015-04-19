import java.io.*;
import java.util.List;
import java.lang.Math;
import java.util.ArrayList;

public class Problem10
{
    public static void main(String[] args) throws IOException
    {
        final int primesBelowValue = 2000000;
        // get primes below 2000000
        List<Integer> primeList = getPrimeNumbers(primesBelowValue);

        long total = 0l;

        for(int prime : primeList) {
            total += prime;
        }

        System.out.println(total);

    }

    private static List<Integer> getPrimeNumbers(int maxVal) {
        int sieveBound = (int)(maxVal - 1) / 2;
        int upperSqrt = ((int)Math.sqrt(maxVal) - 1) / 2;

        boolean[] isPrime = new boolean[sieveBound + 1];
        for(int i = 1; i < isPrime.length; i++) {
            isPrime[i] = true;
        }

        for (int i = 1; i <= upperSqrt; i++) {
            if (isPrime[i]) {
                for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
                    isPrime[j] = false;
                }
            }
        }

        List<Integer> numbers = new ArrayList<Integer>();
        numbers.add(2);

        for (int i = 1; i <= sieveBound; i++) {
            if (isPrime[i]) {
                numbers.add(2 * i + 1);
            }
        }

        return numbers;
    }
}
