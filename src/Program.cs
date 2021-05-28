using System;

namespace CSharpPractice {
  class Program {
    static void Main(string[] args) {
      System.Console.WriteLine("Started" + DateTime.Now);

      if (Test.LongestSubstringWithoutRepeatingTest()) {
        Console.WriteLine("All tests passed successfully!!! 😃");
      } else {
        Console.WriteLine("Tests failed 😟");
      }

      System.Console.WriteLine("Ended" + DateTime.Now);
    }
  }
}
