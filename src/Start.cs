using System;

namespace CSharpPractice {
  class Start {
    static void Main(string[] args) {
      Console.WriteLine($"Started: {DateTime.Now}\n");

      if (Test.MaxCountersTest()) {
        Console.WriteLine("All tests passed successfully!!! 😃\n");
      } else {
        Console.WriteLine("Tests failed 😟\n");
      }

      Console.WriteLine($"Ended: {DateTime.Now}");
    }
  }
}