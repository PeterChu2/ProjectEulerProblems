import java.io.*;
public class Problem4
{
    public static void main(String[] args) throws IOException
    {
        // initialize two numbers to largest 3 digit numbers
        int num1 = 999;
        int num2 = 999;
        int product;
        int count = 0;
        int largestPalindrome = 0;

        // run loops while numbers are two digit
        while (num1 >= 100)
        {
            while (num2 >= 100)
            {
                product = num1*num2;
                num2--;
                if(isPalindrome(product))
                {
                    if(product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }
            count ++;
            // subtract count from 999 to avoid double comparison
            num2 = 999 - count;
            num1--;
        }
        if(largestPalindrome == 1)
        {
            System.out.println("No palindromes exist that are"
                + " a product of two three digit numbers");
            return;
        }
        System.out.println("The largest palindrome"
                        + " of 2 three digit numbers is " + largestPalindrome);
                    return;
    }

    // function to determine if a number is a palindrome
    private static boolean isPalindrome(int number)
    {
        String palindrome = String.valueOf(number);

        for ( int i = 0; i < palindrome.length()/2; i++)
        {
            if( palindrome.charAt(i) !=
                palindrome.charAt(palindrome.length() - 1 - i) )
            {
                return false;
            }
        }
        return true;
    }
}
