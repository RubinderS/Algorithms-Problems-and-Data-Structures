using System;
using System.Reflection;

namespace CSharpPractice {
  class Start {
    static void Main(string[] args) {
      Console.WriteLine($"\nStarted: {DateTime.Now}\n");

      var didAllTestsPass = true;
      Type TestType = typeof(Test);
      var methodsInfo = TestType.GetMethods(
        BindingFlags.DeclaredOnly |
        BindingFlags.Public |
        BindingFlags.Static);

      for (int i = 0; i < methodsInfo.Length; i++) {
        var res = (bool)methodsInfo[i].Invoke(null, null);

        if (res) {
          Console.WriteLine($"{i + 1}: {methodsInfo[i].Name}: Success!!!");
        } else {
          Console.WriteLine($"{i + 1}: {methodsInfo[i].Name}: Failed");
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
