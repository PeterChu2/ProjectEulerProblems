using System;
using System.IO;

class Problem14
{
    static void Main()
    {
      const int max = 1000000;
      long sequenceLength = 0;
      long startingNumber = 0;
      long sequence;

      for (int i = 2; i <= max; i++) {
          int length = 1;
          sequence = i;
          while (sequence != 1) {
              if ((sequence % 2) == 0) {
                  sequence = sequence / 2;
              } else {
                  sequence = sequence * 3 + 1;
              }
              length++;
          }

          // Record the greatest sequence length, and the starting number that
          // produced it
          if (length > sequenceLength) {
              sequenceLength = length;
              startingNumber = i;
          }
      }
      Console.WriteLine(startingNumber);
    }
}
