using System;
using System.Reflection;

namespace CSharpPractice {
  class Start {
    static void Main(string[] args) {
      Console.WriteLine($"\nStarted: {DateTime.Now}\n");

      Type TestType = typeof(Test);
      var didAllTestsPass = true;

      foreach (var methodInfo in TestType.GetMethods(
        BindingFlags.DeclaredOnly |
        BindingFlags.Public |
        BindingFlags.Static)) {
        var res = (bool)methodInfo.Invoke(null, null);

        if (res) {
          Console.WriteLine($"{methodInfo.Name}: Success!!!");
        } else {
          Console.WriteLine($"{methodInfo.Name}: Failed");
          didAllTestsPass = false;
        }

      }

      Console.WriteLine();

      if (didAllTestsPass) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"All tests passed 😃\n");
        Console.ResetColor();
      } else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Some tests failed 😟\n");
        Console.ResetColor();
      }

      Console.WriteLine($"Ended: {DateTime.Now}\n");
    }
  }
}
