using System;
using System.Diagnostics;

public class ExecutionTimer {
    private static Stopwatch sWatch;
    public static void start() {
      sWatch = Stopwatch.StartNew();
    }

    public static void stop() {
      Console.WriteLine("Execution took " + sWatch.ElapsedMilliseconds +" ms");
    }
}
