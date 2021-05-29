using System.Collections.Generic;
using System.Linq;

public static partial class Solution {
  public static int FrogRiverOne(int X, int[] A) {
    var currPosition = 0;
    int[] arr = new int[5];

    for (int i = 0; i < A.Length; i++) {
      if (currPosition + 1 == A[i]) {

        currPosition++;
        System.Console.WriteLine("check passed " + currPosition);
        if (currPosition == X) {
          System.Console.WriteLine(i);
          return i;
        }
      }
    }

    System.Console.WriteLine(-1);

    return -1;
  }
}
