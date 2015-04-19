using System;
using Microsoft.CSharp;
using System.Numerics;

class Problem16{
  static void Main()
    {
      ExecutionTimer.start();
      int sum = 0;
      BigInteger number = BigInteger.Pow(2, 1000);
      while (number > 0) {
          sum += (int) (number % 10);
          number /= 10;
      }
      Console.WriteLine(sum);
      ExecutionTimer.stop();
    }
}
