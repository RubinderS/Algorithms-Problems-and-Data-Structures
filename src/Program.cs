using System;

namespace CSharpPractice {
  class Program {
    static void Main(string[] args) {
      System.Console.WriteLine($"Started: {DateTime.Now}\n");

      if (Test.FrogRiverOne()) {
        Console.WriteLine("All tests passed successfully!!! 😃\n");
      } else {
        Console.WriteLine("Tests failed 😟\n");
      }

      System.Console.WriteLine($"Ended: {DateTime.Now}");
    }
  }
}
