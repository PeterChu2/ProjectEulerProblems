using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

class Problem12
{
    /*
     * Note that 1 + 2 + 3 ... + (n-1) + n = (n)(n+1)/2
     * and note n is coprime to n+1
     */
    static void Main()
    {
        int number = 1;
        int i = 2;
        int cnt = 0;
        int Dn1 = 2;
        int Dn = 2;
        int[] primelist = getPrimeNumbers(1000);

        while (cnt < 500) {
            if (i % 2 == 0) {
                Dn = getNumberOfDivisors(i + 1, primelist);
                cnt = Dn * Dn1;
            } else {
                Dn1 = getNumberOfDivisors((i + 1) / 2, primelist);
                cnt = Dn*Dn1;
            }
            i++;
        }
        number = i * (i - 1) / 2;
        Console.WriteLine(number);
    }

    private static int getNumberOfDivisors(int number, int[] primelist) {
        int nod = 1;
        int exponent;
        int remain = number;

        for (int i = 0; i < primelist.Length; i++) {
            // In case there is a remainder this is a prime factor as well
            // The exponent of that factor is 1
            if (primelist[i] * primelist[i] > number) {
                return nod * 2;
            }

            exponent = 1;
            while (remain % primelist[i] == 0) {
                exponent++;
                remain = remain / primelist[i];
            }
            nod *= exponent;

            //If there is no remainder, return the count
            if (remain == 1) {
                return nod;
            }
        }
        return nod;
    }

    private static int[] getPrimeNumbers(int maxVal) {
        int sieveBound = (int)(maxVal - 1) / 2;
        int upperSqrt = ((int)Math.Sqrt(maxVal) - 1) / 2;

        BitArray IsPrime = new BitArray(sieveBound + 1, true);

        for (int i = 1; i <= upperSqrt; i++) {
            if (IsPrime.Get(i)) {
                for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
                    IsPrime.Set(j, false);
                }
            }
        }

        List<int> numbers = new List<int>((int)(maxVal / (Math.Log(maxVal) - 1.08366)));
        numbers.Add(2);

        for (int i = 1; i <= sieveBound; i++) {
            if (IsPrime.Get(i)) {
                numbers.Add(2 * i + 1);
            }
        }

        return numbers.ToArray();
    }

}
