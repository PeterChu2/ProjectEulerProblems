using System;
class Problem17 {
  static void Main()
  {
    int total = 0;
    ExecutionTimer.start();
    for(int i = 1; i <= 1000; i++){
      total += lettersUsed(numToString(i));
    }
    Console.WriteLine(total);
    ExecutionTimer.stop();
  }

  private static String numToString(int num) {
    const String THOUSAND = "thousand";
    const String HUNDRED = "hundred";
    String[] TEENS = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                         "sixteen", "seventeen", "eighteen", "nineteen"};
    String[] TENS = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
    String[] ONES = {"zero", "one", "two", "three", "four", "five", "six",
                        "seven", "eight", "nine"};
    int numModThousand = num % 1000;
    int numModHundred = num % 100;
    int numModTen = num % 10;

    if( num/1000 != 0 ) {
      if(numModThousand != 0) {
        return numToString(num/1000) + " " + THOUSAND + " and " + numToString(numModThousand);
      }
      else {
        return numToString(num/1000) + " " + THOUSAND;
      }
    }
    if( num/100 != 0 ) {
      if(numModHundred != 0) {
        return numToString(num/100) + " " + HUNDRED + " and " + numToString(numModHundred);
      }
      else {
        return numToString(num/100) + " " + HUNDRED;
      }
    }
    if( num/10 != 0 ) {
      if( numModHundred >= 10  && numModHundred <= 19) {
        return TEENS[numModTen];
      }
      else {
        // subtract two because twenty begins at index 0
        if(numModTen != 0) {
          return TENS[num/10 - 2] + "-" + numToString(numModTen);
        }
        else {
          return TENS[num/10 - 2];
        }
      }
    }
    // at this point numbers must be from 0-9
    return ONES[numModTen];
  }

  private static int lettersUsed(String number) {
    int total = 0;
    String[] words = number.Split(new Char[] {'-', ' '},
                                    StringSplitOptions.RemoveEmptyEntries);
    for(int i = 0; i < words.Length; i++) {
      total += words[i].Length;
    }
    return total;
  }
}
