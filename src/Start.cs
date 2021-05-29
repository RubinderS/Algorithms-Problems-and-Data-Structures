using System;

namespace CSharpPractice {
  class Start {
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