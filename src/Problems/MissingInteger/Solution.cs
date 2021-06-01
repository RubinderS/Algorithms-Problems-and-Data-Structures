using System;

public static partial class Solution {
  public static int MissingInteger(int[] A) {
    var smallestMissingInteger = 1;
    Array.Sort(A);

    foreach (var integer in A) {
      if (integer == smallestMissingInteger) {
        smallestMissingInteger++;
      }
    }

    return smallestMissingInteger;
  }
}
