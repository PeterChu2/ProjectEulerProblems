using System;
using System.IO;
using Microsoft.CSharp;
using System.Numerics;

class Problem13
{
    static void Main()
    {
      BigInteger result = new BigInteger();
      string line;
      StreamReader reader = new StreamReader("InputProblem13.txt");

      while ((line = reader.ReadLine()) != null) {
          result += BigInteger.Parse(line);
      }

      reader.Close();

      Console.WriteLine(result);
    }
}
