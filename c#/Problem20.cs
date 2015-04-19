using System;
using System.Numerics;

class Problem20
{
    static void Main()
    {
      ExecutionTimer.start();
      int sum = 0;
      BigInteger factorial = 1;
      for (int i = 1; i <= 100; i++) {
          factorial *= i;
      }
      while (factorial > 0) {
          sum += (int)(factorial % 10);
          factorial /= 10;
      }
      ExecutionTimer.stop();
      Console.WriteLine(sum);
    }
}
