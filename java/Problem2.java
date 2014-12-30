import java.io.*;
public class Problem2
{
    public static void main(String[] args) throws IOException
    {
        int sum = 0;
        int prev = 0;
        int curr = 1;
        int temp;

        // Loop while the value reached is not greater than 4000000
        while(curr <= 4000000)
        {
            // Check if number is even
            if (curr % 2 == 0)
            {
                sum += curr;
            }
            temp = curr;
            curr = prev + curr;
            prev = temp;
        }

        System.out.println(sum);
    }
}
