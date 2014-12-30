import java.io.*;
import java.util.HashMap;
import java.lang.Math;
public class Problem5
{
    public static void main(String[] args) throws IOException
    {
        int number = 1;
        int count = 0;
        int temp;

        // Every prime factor from 2 - 20
        final int[] primeFactors = { 2, 3, 5, 7, 11, 13, 17, 19 };
        HashMap<Integer, Integer> hm = new HashMap<Integer, Integer>();
        for(int factor : primeFactors)
        {
            hm.put(factor, 0);
        }
        for(int i = 2; i <= 20; i++)
        {
            for( int factor : primeFactors)
            {
                temp = i;
                while(temp % factor == 0)
                {
                    count ++;
                    temp /= factor;
                }
                hm.put(factor, Math.max(hm.get(factor), count));
                count = 0;
            }
        }
        for(int factor : primeFactors)
        {
            System.out.println(factor + " :      " + hm.get(factor));
            for(int i = 0; i < hm.get(factor); i++)
            {
                number *= factor;
            }
        }
        System.out.println(number);
    }
}
