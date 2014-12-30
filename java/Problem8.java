import java.io.*;
import java.lang.Math;
import java.util.*;

public class Problem8
{
    public static void main(String[] args) throws IOException
    {
        StringBuilder number = new StringBuilder();
        long max = 1;
        String line;

        // Create way to get input from external file
        BufferedReader br = new BufferedReader(
            new FileReader("inputProblem8.txt"));

        // initialize string with strings in entire file
        line = br.readLine();
        do
        {
            number.append(line);
            line = br.readLine();
        } while (line != null);

        // loop through the string until 13th to last character inclusive
        for (int i = 0; i <= number.length() - 13; i++) {
            long product = 1;
            for (int j = 0; j < 13; j++)
            {
                // subtract offset of character '0' to get integer value
                product *= number.charAt(i + j) - '0';
            }
            //compare and set max accordingly
            max = Math.max(product, max);
        }

        System.out.println(max);

    }
}
